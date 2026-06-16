// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>A client-provided token to ensure the idempotence of the request. This value must be unique for each request. The token can contain only ASCII characters and must be no more than 64 characters long. For more information, see <a href="~~~/doc-en/6a938a5b-2402-4c9d-b235-3733a1f813c9.dita">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of custom fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<CreateUserRequestCustomFields> CustomFields { get; set; }
        public class CreateUserRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The identifier of the custom field. You must create this field in the console before you can use it in a request. For more information, see the Custom Fields module in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the custom field. This value must comply with the constraints defined for the corresponding custom field.</para>
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
        /// <para>The display name. The maximum length is 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address. The local part of the address can contain uppercase letters, lowercase letters, digits, periods (.), underscores (_), or hyphens (-). The maximum length is 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Indicates whether the email address is verified. A verified address is considered trusted. This parameter is required if you specify the <c>Email</c> parameter. For typical use, set this to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A list of subordinate organizational unit IDs. A user can belong to multiple organizational units.</para>
        /// </summary>
        [NameInMap("OrganizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

        /// <summary>
        /// <para>The password. The format must comply with the password policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The settings for the password initialization policy.</para>
        /// </summary>
        [NameInMap("PasswordInitializationConfig")]
        [Validation(Required=false)]
        public CreateUserRequestPasswordInitializationConfig PasswordInitializationConfig { get; set; }
        public class CreateUserRequestPasswordInitializationConfig : TeaModel {
            /// <summary>
            /// <para>The status of forced password update. This setting is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>enabled</c>: Enables forced password updates.</para>
            /// </description></item>
            /// <item><description><para><c>disabled</c>: Disables forced password updates.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordForcedUpdateStatus")]
            [Validation(Required=false)]
            public string PasswordForcedUpdateStatus { get; set; }

            /// <summary>
            /// <para>The priority of the password initialization policy. This setting is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>global</c>: The service uses the instance-level password initialization policy and ignores the policy specified in this request. For more information, see the password initialization policy settings.</para>
            /// </description></item>
            /// <item><description><para><c>custom</c>: The service uses the password initialization policy defined in this request. This includes the forced password update setting, the password initialization method, and the notification channels.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("PasswordInitializationPolicyPriority")]
            [Validation(Required=false)]
            public string PasswordInitializationPolicyPriority { get; set; }

            /// <summary>
            /// <para>The password initialization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>random</c>: The system generates a random password.</description></item>
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
        /// <para>The phone number. It must be 6 to 15 digits long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678901</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Indicates whether the phone number is verified. A verified number is considered trusted. This parameter is required if you specify the <c>PhoneNumber</c> parameter. For typical use, set this to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PhoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The country code. It must contain 1 to 6 digits and must not include the plus sign (+).</para>
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
        /// <para>The external ID for associating the user with an external system. The maximum length is 128 characters. If this parameter is not specified, its value defaults to the system-generated user ID.</para>
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
