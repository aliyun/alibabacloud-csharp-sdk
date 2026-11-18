// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetIdentityProviderAuthnConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The automatic creation rule configuration for accounts.</para>
        /// </summary>
        [NameInMap("AutoCreateUserConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestAutoCreateUserConfig AutoCreateUserConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestAutoCreateUserConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether automatic creation of accounts is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoCreateUserStatus")]
            [Validation(Required=false)]
            public string AutoCreateUserStatus { get; set; }

            /// <summary>
            /// <para>The organization IDs.</para>
            /// </summary>
            [NameInMap("TargetOrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> TargetOrganizationalUnitIds { get; set; }

        }

        /// <summary>
        /// <para>The automatic account update configuration.</para>
        /// </summary>
        [NameInMap("AutoUpdateUserConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestAutoUpdateUserConfig AutoUpdateUserConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestAutoUpdateUserConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether automatic account updates are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoUpdateUserStatus")]
            [Validation(Required=false)]
            public string AutoUpdateUserStatus { get; set; }

        }

        /// <summary>
        /// <para>The account binding rule configuration.</para>
        /// </summary>
        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestBindingConfig BindingConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestBindingConfig : TeaModel {
            /// <summary>
            /// <para>The rules for automatic account matching.</para>
            /// </summary>
            [NameInMap("AutoMatchUserProfileExpressions")]
            [Validation(Required=false)]
            public List<SetIdentityProviderAuthnConfigurationRequestBindingConfigAutoMatchUserProfileExpressions> AutoMatchUserProfileExpressions { get; set; }
            public class SetIdentityProviderAuthnConfigurationRequestBindingConfigAutoMatchUserProfileExpressions : TeaModel {
                /// <summary>
                /// <para>The type of the expression.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field</para>
                /// </summary>
                [NameInMap("ExpressionMappingType")]
                [Validation(Required=false)]
                public string ExpressionMappingType { get; set; }

                /// <summary>
                /// <para>The expression for the source attribute value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idpUser.userId</para>
                /// </summary>
                [NameInMap("SourceValueExpression")]
                [Validation(Required=false)]
                public string SourceValueExpression { get; set; }

                /// <summary>
                /// <para>The name of the target attribute for mapping.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetField")]
                [Validation(Required=false)]
                public string TargetField { get; set; }

                /// <summary>
                /// <para>The name of the target attribute for mapping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("TargetFieldDescription")]
                [Validation(Required=false)]
                public string TargetFieldDescription { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether automatic account matching is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoMatchUserStatus")]
            [Validation(Required=false)]
            public string AutoMatchUserStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether manual account binding is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("MappingBindingStatus")]
            [Validation(Required=false)]
            public string MappingBindingStatus { get; set; }

        }

        /// <summary>
        /// <para>The identity provider ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_11111</para>
        /// </summary>
        [NameInMap("IdentityProviderId")]
        [Validation(Required=false)]
        public string IdentityProviderId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The AD/LDAP authentication configuration.</para>
        /// </summary>
        [NameInMap("LdapAuthnConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestLdapAuthnConfig LdapAuthnConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestLdapAuthnConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether automatic password updates are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoUpdatePasswordStatus")]
            [Validation(Required=false)]
            public string AutoUpdatePasswordStatus { get; set; }

            /// <summary>
            /// <para>The user logon identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>email</para>
            /// </summary>
            [NameInMap("UserLoginIdentifier")]
            [Validation(Required=false)]
            public string UserLoginIdentifier { get; set; }

            /// <summary>
            /// <para>The user object class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>posixAccount</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

        }

    }

}
