namespace kkokkino.Dsl.Core.LdapExpression;

using kkokkino.Dsl.Core.LdapType;

public interface ILdapBinaryExpression : ILdapExpression
{
  ILdapExpression Left { get; }

  ILdapExpression Right { get; }
}

public interface ILdapBinaryExpression<TLdapType> : ILdapExpression<TLdapType>
  where TLdapType : ILdapType
{
  ILdapExpression<TLdapType> Left { get; }

  ILdapExpression<TLdapType> Right { get; }

  void Deconstruct(out ILdapExpression<TLdapType> left, out ILdapExpression<TLdapType> right);
}
