namespace kkokkino.Dsl.Core.LdapValues;

using kkokkino.Dsl.Core.LdapExpression;

public record LdapIntValue(int Value) : LdapExpressionInt
{
  public static implicit operator LdapIntValue(int x) => new LdapIntValue(x);
}
