// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The password initialization method. Set the value to random,</para>
        /// <list type="bullet">
        /// <item><description>which indicates that the password is randomly generated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-demo</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The custom extended fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<CreateUserRequestCustomFields> CustomFields { get; set; }
        public class CreateUserRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The name of the extended field. You must create the extended field in advance. To create an extended field, log on to the IDaaS console. In the left-side navigation pane, choose Accounts &gt; Extended Fields, and then click Create Field on the Extended Fields page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the extended field. The value follows the limits on the properties of the extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The description of the organization. The value can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description text</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the account. The display name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the account. The name can be up to 64 characters in length and can contain letters, digits, underscores (_), periods (.), at signs (@), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The description of the account. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

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
        /// <para>Specifies whether the mobile phone number is a trusted mobile phone number. This parameter is required if the PhoneNumber parameter is specified. If you have no special business requirements, set this parameter to true.</para>
        /// </summary>
        [NameInMap("OrganizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

        /// <summary>
        /// <para>The password of the account. For more information,view the password policyof the instanceinthe IDaaS console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456xxx</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The configurations for password initialization.</para>
        /// </summary>
        [NameInMap("PasswordInitializationConfig")]
        [Validation(Required=false)]
        public CreateUserRequestPasswordInitializationConfig PasswordInitializationConfig { get; set; }
        public class CreateUserRequestPasswordInitializationConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to forcibly change the password status. Default value: disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled:forcibly changes the password status.</description></item>
            /// <item><description>disabled: does not forcibly change the password status.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordForcedUpdateStatus")]
            [Validation(Required=false)]
            public string PasswordForcedUpdateStatus { get; set; }

            /// <summary>
            /// <para>The priority of the password initialization policy. By default, this parameter does not take effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global:The password initialization policy globally takes effect.</description></item>
            /// <item><description>custom: The password initialization policy takes effect based on custom settings.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("PasswordInitializationPolicyPriority")]
            [Validation(Required=false)]
            public string PasswordInitializationPolicyPriority { get; set; }

            /// <summary>
            /// <para>The password initialization method. Set the value to random,</para>
            /// <list type="bullet">
            /// <item><description>whichindicates that the password is randomly generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>random</para>
            /// </summary>
            [NameInMap("PasswordInitializationType")]
            [Validation(Required=false)]
            public string PasswordInitializationType { get; set; }

            /// <summary>
            /// <para>The value of the extended field. The value follows the limits on the properties of the extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sms</para>
            /// </summary>
            [NameInMap("UserNotificationChannels")]
            [Validation(Required=false)]
            public List<string> UserNotificationChannels { get; set; }

        }

        /// <summary>
        /// <para>The ID of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678901xxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The email address of the user who owns the account. The email address prefix can contain letters, digits, underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PhoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The IDs of organizational units to which the account belongs. An account can belong to multiple organizational units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("PhoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>主组织ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("PrimaryOrganizationalUnitId")]
        [Validation(Required=false)]
        public string PrimaryOrganizationalUnitId { get; set; }

        /// <summary>
        /// <para>The display name of the account. The display name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("UserExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// <para>The name of the extended field. You must create the extended field in advance. To create an extended field, log on to the IDaaS console. In the left-side navigation pane, choose Accounts &gt; Extended Fields, and then click Create Field on the Extended Fields page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_001</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
