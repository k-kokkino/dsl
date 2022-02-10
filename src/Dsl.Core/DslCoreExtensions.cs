namespace Dsl.Core;

using kkokkino.Dsl.Core.LdapExpression;
using kkokkino.Dsl.Core.LdapValues;

public static class DslCoreExtensions
{
  public static string Compile(this ILdapExpression expression)
    => expression switch
    {
      LdapIntValue(var value) => value.ToString(),
      LdapExpressionIntAdd(var left, var right) => $"({left.Compile()} + {right.Compile()})",

      _ => throw new NotImplementedException($"Expression {nameof(expression)} is not supported."),
    };

  public static ILdapExpression Optimize(this ILdapExpression expression)
  {
    var optimized = expression.ConstantFolding();
    return expression.Equals(optimized)
      ? optimized
      : optimized.Optimize();
  }

  internal static ILdapExpression ConstantFolding(this ILdapExpression expression)
    => expression switch
    {
      LdapExpressionIntAdd(var left, LdapIntValue(0)) => left,
      LdapExpressionIntAdd(LdapIntValue(0), var right) => right,
      LdapExpressionIntAdd(LdapIntValue(var left), LdapIntValue(var right)) => new LdapIntValue(left + right),
      LdapExpressionIntAdd(var left, var right) => new LdapExpressionIntAdd(left.ConstantFolding() as LdapExpressionInt, right.ConstantFolding() as LdapExpressionInt),

      _ => expression,
    };
}
