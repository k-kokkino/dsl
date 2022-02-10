namespace kkokkino.Dsl.Core.LdapExpression;

using kkokkino.Dsl.Core.LdapType;

public record LdapExpressionIntAdd(ILdapExpression<ILdapInt> Left, ILdapExpression<ILdapInt> Right) : LdapExpressionInt, ILdapBinaryExpression<ILdapInt>
{
}
