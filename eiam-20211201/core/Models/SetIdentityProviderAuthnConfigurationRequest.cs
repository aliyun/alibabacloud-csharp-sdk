// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetIdentityProviderAuthnConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>Automatic Account Creation Rule Configuration.</para>
        /// </summary>
        [NameInMap("AutoCreateUserConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestAutoCreateUserConfig AutoCreateUserConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestAutoCreateUserConfig : TeaModel {
            /// <summary>
            /// <para>Automatic account creation status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoCreateUserStatus")]
            [Validation(Required=false)]
            public string AutoCreateUserStatus { get; set; }

            /// <summary>
            /// <para>Organization ID</para>
            /// </summary>
            [NameInMap("TargetOrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> TargetOrganizationalUnitIds { get; set; }

        }

        /// <summary>
        /// <para>Automatic Account Update Configuration</para>
        /// </summary>
        [NameInMap("AutoUpdateUserConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestAutoUpdateUserConfig AutoUpdateUserConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestAutoUpdateUserConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic account updates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoUpdateUserStatus")]
            [Validation(Required=false)]
            public string AutoUpdateUserStatus { get; set; }

        }

        /// <summary>
        /// <para>Account Binding Rule Configuration</para>
        /// </summary>
        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestBindingConfig BindingConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestBindingConfig : TeaModel {
            /// <summary>
            /// <para>Rules for automatic account matching.</para>
            /// </summary>
            [NameInMap("AutoMatchUserProfileExpressions")]
            [Validation(Required=false)]
            public List<SetIdentityProviderAuthnConfigurationRequestBindingConfigAutoMatchUserProfileExpressions> AutoMatchUserProfileExpressions { get; set; }
            public class SetIdentityProviderAuthnConfigurationRequestBindingConfigAutoMatchUserProfileExpressions : TeaModel {
                /// <summary>
                /// <para>Type of expression.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field</para>
                /// </summary>
                [NameInMap("ExpressionMappingType")]
                [Validation(Required=false)]
                public string ExpressionMappingType { get; set; }

                /// <summary>
                /// <para>Expression for mapping attribute value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idpUser.userId</para>
                /// </summary>
                [NameInMap("SourceValueExpression")]
                [Validation(Required=false)]
                public string SourceValueExpression { get; set; }

                /// <summary>
                /// <para>Target attribute name for mapping.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetField")]
                [Validation(Required=false)]
                public string TargetField { get; set; }

                /// <summary>
                /// <para>Target attribute name for mapping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("TargetFieldDescription")]
                [Validation(Required=false)]
                public string TargetFieldDescription { get; set; }

            }

            /// <summary>
            /// <para>Automatic account matching status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoMatchUserStatus")]
            [Validation(Required=false)]
            public string AutoMatchUserStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether the manual account binding feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("MappingBindingStatus")]
            [Validation(Required=false)]
            public string MappingBindingStatus { get; set; }

        }

        /// <summary>
        /// <para>Identity Provider ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_11111</para>
        /// </summary>
        [NameInMap("IdentityProviderId")]
        [Validation(Required=false)]
        public string IdentityProviderId { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>AD/LDAP Authentication Configuration</para>
        /// </summary>
        [NameInMap("LdapAuthnConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderAuthnConfigurationRequestLdapAuthnConfig LdapAuthnConfig { get; set; }
        public class SetIdentityProviderAuthnConfigurationRequestLdapAuthnConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically update passwords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoUpdatePasswordStatus")]
            [Validation(Required=false)]
            public string AutoUpdatePasswordStatus { get; set; }

            /// <summary>
            /// <para>User Login Identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>email</para>
            /// </summary>
            [NameInMap("UserLoginIdentifier")]
            [Validation(Required=false)]
            public string UserLoginIdentifier { get; set; }

            /// <summary>
            /// <para>User ObjectClass</para>
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
