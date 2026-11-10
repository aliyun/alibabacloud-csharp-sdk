// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate a parameter value, but you must ensure that the parameter value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see the References: How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of extended fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<CreateUserRequestCustomFields> CustomFields { get; set; }
        public class CreateUserRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The identifier of the extended field. You must create the extended field in advance. For more information, refer to the Extended Fields module in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the extended field. The value must comply with the attribute limits of the corresponding extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The description. The maximum length is 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description text</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the account. The maximum length is 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address. The email prefix can contain uppercase letters, lowercase letters, digits, periods (.), underscores (_), and hyphens (-). The maximum length is 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Specifies whether the email address is verified and trusted. If the email address is specified, this parameter is required. If no special business requirements exist, set this parameter to true.</para>
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
        /// <para>The IDs of the organizational units to which the account belongs. An account can belong to multiple organizational units.</para>
        /// </summary>
        [NameInMap("OrganizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

        /// <summary>
        /// <para>The password. For specific format requirements, refer to the password policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The password initialization configuration.</para>
        /// </summary>
        [NameInMap("PasswordInitializationConfig")]
        [Validation(Required=false)]
        public CreateUserRequestPasswordInitializationConfig PasswordInitializationConfig { get; set; }
        public class CreateUserRequestPasswordInitializationConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to force the user to change the password. By default, this feature is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enables the feature.</description></item>
            /// <item><description>disabled: Disables the feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordForcedUpdateStatus")]
            [Validation(Required=false)]
            public string PasswordForcedUpdateStatus { get; set; }

            /// <summary>
            /// <para>The password initialization policy priority. By default, this parameter does not take effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global: Global priority. The instance-level password initialization policy is used. The password initialization policy specified in the Settings is invalid. For more information, refer to the password initialization policy in the password-related policies.</description></item>
            /// <item><description>custom: Custom priority. The password initialization policy defined in the Settings is used, including whether to force password changes, the password initialization method, and the notification channels.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("PasswordInitializationPolicyPriority")]
            [Validation(Required=false)]
            public string PasswordInitializationPolicyPriority { get; set; }

            /// <summary>
            /// <para>The password initialization method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>random: Generates a random password.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>random</para>
            /// </summary>
            [NameInMap("PasswordInitializationType")]
            [Validation(Required=false)]
            public string PasswordInitializationType { get; set; }

            /// <summary>
            /// <para>The list of password notification channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sms</para>
            /// </summary>
            [NameInMap("UserNotificationChannels")]
            [Validation(Required=false)]
            public List<string> UserNotificationChannels { get; set; }

        }

        /// <summary>
        /// <para>The mobile phone number. It must be 6 to 15 digits in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678901</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether the mobile phone number is verified and trusted. If the mobile phone number is specified, this parameter is required. If no special business requirements exist, set this parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PhoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The country code for the mobile phone number. It must be 1 to 6 digits in length and cannot contain a plus sign (+).</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("PhoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>The ID of the primary organizational unit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("PrimaryOrganizationalUnitId")]
        [Validation(Required=false)]
        public string PrimaryOrganizationalUnitId { get; set; }

        /// <summary>
        /// <para>The external ID of the account, which is used to associate the account with an external system. The maximum length is 128 characters. If this parameter is not specified, the account ID is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("UserExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// <para>The username. It can contain letters, digits, and the following special characters: underscores (_), periods (.), at signs (@), and hyphens (-). The maximum length is 256 characters.</para>
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
