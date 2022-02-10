namespace kkokkino.Dsl.Core.LdapExpression;

using kkokkino.Dsl.Core.LdapType;

public interface ILdapUnaryExpression : ILdapExpression
{
  ILdapExpression Value { get; }
}

public interface ILdapUnaryExpression<TLdapType> : ILdapExpression<TLdapType>
  where TLdapType : ILdapType
{
  ILdapExpression<TLdapType> Value { get; }

  void Deconstruct(out ILdapExpression<TLdapType> value);
}
