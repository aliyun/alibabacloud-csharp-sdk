// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// The extended fields.
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<CreateUserRequestCustomFields> CustomFields { get; set; }
        public class CreateUserRequestCustomFields : TeaModel {
            /// <summary>
            /// The name of the extended field. You must create the extended field in advance. To create an extended field, log on to the IDaaS console. In the left-side navigation pane, choose Accounts > Extended Fields, and then click Create Field on the Extended Fields page.
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// The value of the extended field. The value follows the limits on the properties of the extended field.
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// The description of the organizational unit. The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the account. The display name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the user who owns the account. The email address prefix can contain letters, digits, underscores (_), periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// Specifies whether the email address is a trusted email address. This parameter is required if the Email parameter is specified. If you have no special business requirements, set this parameter to true.
        /// </summary>
        [NameInMap("EmailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IDs of organizational units to which the account belongs. An account can belong to multiple organizational units.
        /// </summary>
        [NameInMap("OrganizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

        /// <summary>
        /// The password of the account. For more information, view the password policy of the instance in the IDaaS console.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The configurations for password initialization.
        /// </summary>
        [NameInMap("PasswordInitializationConfig")]
        [Validation(Required=false)]
        public CreateUserRequestPasswordInitializationConfig PasswordInitializationConfig { get; set; }
        public class CreateUserRequestPasswordInitializationConfig : TeaModel {
            /// <summary>
            /// Specifies whether to forcibly change the password status. Default value: disabled. Valid values:
            /// 
            /// *   enabled: forcibly changes the password status.
            /// *   disabled: does not forcibly change the password status.
            /// </summary>
            [NameInMap("PasswordForcedUpdateStatus")]
            [Validation(Required=false)]
            public string PasswordForcedUpdateStatus { get; set; }

            /// <summary>
            /// The priority of the password initialization policy. By default, this parameter does not take effect. Valid values:
            /// 
            /// *   global: The password initialization policy globally takes effect.
            /// *   custom: The password initialization policy takes effect based on custom settings.
            /// </summary>
            [NameInMap("PasswordInitializationPolicyPriority")]
            [Validation(Required=false)]
            public string PasswordInitializationPolicyPriority { get; set; }

            /// <summary>
            /// The password initialization method. Set the value to random,
            /// 
            /// *   which indicates that the password is randomly generated.
            /// </summary>
            [NameInMap("PasswordInitializationType")]
            [Validation(Required=false)]
            public string PasswordInitializationType { get; set; }

            /// <summary>
            /// The password notification methods.
            /// </summary>
            [NameInMap("UserNotificationChannels")]
            [Validation(Required=false)]
            public List<string> UserNotificationChannels { get; set; }

        }

        /// <summary>
        /// The mobile phone number, which contains 6 to 15 digits.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Specifies whether the mobile phone number is a trusted mobile phone number. This parameter is required if the PhoneNumber parameter is specified. If you have no special business requirements, set this parameter to true.
        /// </summary>
        [NameInMap("PhoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// The country code of the mobile phone number. The country code contains only digits and does not contain a plus sign (+).
        /// </summary>
        [NameInMap("PhoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// The ID of the primary organizational unit to which the account belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PrimaryOrganizationalUnitId")]
        [Validation(Required=false)]
        public string PrimaryOrganizationalUnitId { get; set; }

        /// <summary>
        /// The external ID of the account. The external ID can be used to associate the account with an external system. The external ID can be up to 64 characters in length. If you do not specify an external ID for the account, the ID of the account is used as the external ID by default.
        /// </summary>
        [NameInMap("UserExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// The name of the account. The name can be up to 64 characters in length and can contain letters, digits, underscores (_), periods (.), at signs (@), and hyphens (-).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
