// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>A list of custom fields for the account.</para>
        /// </summary>
        [NameInMap("customFields")]
        [Validation(Required=false)]
        public List<CreateUserRequestCustomFields> CustomFields { get; set; }
        public class CreateUserRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The name of the custom field. You can view the field\&quot;s data type and value range in the IDaaS console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the custom field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fieldValue_001</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The account description. The maximum length is 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试账户</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name. The maximum length is 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>display_name001</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address. The local-part of the address can contain uppercase and lowercase letters, digits, periods (<c>.</c>), underscores (<c>_</c>), and hyphens (<c>-</c>). The maximum length is 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Specifies whether the email is verified. This parameter is required if <c>email</c> is set. Typically, set this to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("emailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// <para>The account password. For password complexity rules, see the password policy in the IDaaS console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The password initialization configuration.</para>
        /// </summary>
        [NameInMap("passwordInitializationConfig")]
        [Validation(Required=false)]
        public CreateUserRequestPasswordInitializationConfig PasswordInitializationConfig { get; set; }
        public class CreateUserRequestPasswordInitializationConfig : TeaModel {
            /// <summary>
            /// <para>The password forced update status. By default, this feature is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>enabled</c>: Enables the feature.</para>
            /// </description></item>
            /// <item><description><para><c>disabled</c>: Disables the feature.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("passwordForcedUpdateStatus")]
            [Validation(Required=false)]
            public string PasswordForcedUpdateStatus { get; set; }

            /// <summary>
            /// <para>The priority of the password initialization policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>global</c>: Uses the instance-level password initialization policy and ignores the custom settings in this request. For more information, see the password initialization policy configuration in the IDaaS console.</para>
            /// </description></item>
            /// <item><description><para><c>custom</c>: Uses the custom password initialization policy defined in this request. This includes settings for forced password updates, the initialization type, and notification channels.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("passwordInitializationPolicyPriority")]
            [Validation(Required=false)]
            public string PasswordInitializationPolicyPriority { get; set; }

            /// <summary>
            /// <para>The password initialization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>random</c>: A randomly generated password.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>random</para>
            /// </summary>
            [NameInMap("passwordInitializationType")]
            [Validation(Required=false)]
            public string PasswordInitializationType { get; set; }

            /// <summary>
            /// <para>The user notification channels. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>email</c>: Email</para>
            /// </description></item>
            /// <item><description><para><c>sms</c>: SMS</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sms</para>
            /// </summary>
            [NameInMap("userNotificationChannels")]
            [Validation(Required=false)]
            public List<string> UserNotificationChannels { get; set; }

        }

        /// <summary>
        /// <para>The account phone number. It must be 6 to 15 digits long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxx</para>
        /// </summary>
        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether the phone number is verified. This parameter is required if <c>phoneNumber</c> is set. Typically, set this to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("phoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The phone region code. For example, the code for the Chinese mainland is <c>86</c>. Do not include a <c>00</c> prefix or a plus sign (<c>+</c>). This parameter is required if <c>phoneNumber</c> is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("phoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>The ID of the primary organizational unit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("primaryOrganizationalUnitId")]
        [Validation(Required=false)]
        public string PrimaryOrganizationalUnitId { get; set; }

        /// <summary>
        /// <para>The external user ID, used to associate the account with an external system. The maximum length is 128 characters. If unspecified, it defaults to the account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("userExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// <para>The username. It can contain letters, digits, and the following special characters: underscore (<c>_</c>), period (<c>.</c>), at sign (<c>@</c>), and hyphen (<c>-</c>). The maximum length is 256 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name001</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
