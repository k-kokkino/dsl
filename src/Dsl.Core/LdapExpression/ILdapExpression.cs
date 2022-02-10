namespace kkokkino.Dsl.Core.LdapExpression;

using kkokkino.Dsl.Core.LdapType;

public interface ILdapExpression
{
}

public interface ILdapExpression<out TLdapType> : ILdapExpression
where TLdapType : ILdapType
{
}
