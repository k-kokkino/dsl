namespace kkokkino.Dsl.Core.LdapExpression;

using kkokkino.Dsl.Core.LdapType;
using kkokkino.Dsl.Core.LdapValues;

public abstract record LdapExpressionInt : ILdapExpression<ILdapInt>
{
  public static LdapExpressionInt operator +(LdapExpressionInt left, LdapExpressionInt right)
  => new LdapExpressionIntAdd(left, right);

  public static implicit operator LdapExpressionInt(int x) => new LdapIntValue(x);

}
