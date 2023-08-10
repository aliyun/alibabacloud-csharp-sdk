// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The data object of the account.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// The time when the account expires. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("AccountExpireTime")]
            [Validation(Required=false)]
            public long? AccountExpireTime { get; set; }

            /// <summary>
            /// The time when the account was created. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The list of custom fields that describe the account.
            /// </summary>
            [NameInMap("CustomFields")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserCustomFields> CustomFields { get; set; }
            public class GetUserResponseBodyUserCustomFields : TeaModel {
                /// <summary>
                /// The identifier of the custom field.
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// The value of the custom field.
                /// </summary>
                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            /// <summary>
            /// The description of the account.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The display name of the account.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The email address of the user who owns the account.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// Indicates whether the email address has been verified. A value of true indicates that the email address has been verified by the user or has been set to the verified status by the administrator. A value of false indicates that the email address has not been verified.
            /// </summary>
            [NameInMap("EmailVerified")]
            [Validation(Required=false)]
            public bool? EmailVerified { get; set; }

            /// <summary>
            /// The organizational units to which the account belongs.
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserGroups> Groups { get; set; }
            public class GetUserResponseBodyUserGroups : TeaModel {
                /// <summary>
                /// The description of the organizational unit.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the organizational unit.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the organizational unit.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// The ID of the instance
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the account lock expires. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("LockExpireTime")]
            [Validation(Required=false)]
            public long? LockExpireTime { get; set; }

            /// <summary>
            /// The organizational units to which the account belongs.
            /// </summary>
            [NameInMap("OrganizationalUnits")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserOrganizationalUnits> OrganizationalUnits { get; set; }
            public class GetUserResponseBodyUserOrganizationalUnits : TeaModel {
                /// <summary>
                /// The ID of the organizational unit.
                /// </summary>
                [NameInMap("OrganizationalUnitId")]
                [Validation(Required=false)]
                public string OrganizationalUnitId { get; set; }

                /// <summary>
                /// The name of the organizational unit.
                /// </summary>
                [NameInMap("OrganizationalUnitName")]
                [Validation(Required=false)]
                public string OrganizationalUnitName { get; set; }

                /// <summary>
                /// Indicates whether the organization is the primary organization.
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

            }

            /// <summary>
            /// The time when the password of the account expires. This value is a UNIX timestamp. Unit: milliseconds.
            /// 
            /// *   If the value -1 is returned, the password does not expire.
            /// *   If no value is returned, the password does not expire.
            /// *   If a UNIX timestamp is returned, the password expires at the indicated point of time.
            /// </summary>
            [NameInMap("PasswordExpireTime")]
            [Validation(Required=false)]
            public long? PasswordExpireTime { get; set; }

            /// <summary>
            /// Indicates whether a password is set.
            /// </summary>
            [NameInMap("PasswordSet")]
            [Validation(Required=false)]
            public bool? PasswordSet { get; set; }

            /// <summary>
            /// The mobile number of the user who owns the account.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// Indicates whether the mobile number has been verified. A value of true indicates that the mobile number has been verified by the user or has been set to the verified status by the administrator. A value of false indicates that the mobile number has not been verified.
            /// </summary>
            [NameInMap("PhoneNumberVerified")]
            [Validation(Required=false)]
            public bool? PhoneNumberVerified { get; set; }

            /// <summary>
            /// The country code of the mobile number. For example, the country code of China is 86 without 00 or +.
            /// </summary>
            [NameInMap("PhoneRegion")]
            [Validation(Required=false)]
            public string PhoneRegion { get; set; }

            /// <summary>
            /// The ID of the primary organizational unit to which the account belongs.
            /// </summary>
            [NameInMap("PrimaryOrganizationalUnitId")]
            [Validation(Required=false)]
            public string PrimaryOrganizationalUnitId { get; set; }

            /// <summary>
            /// The time when the account was registered. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public long? RegisterTime { get; set; }

            /// <summary>
            /// The status of the account. Valid values:
            /// 
            /// *   enabled: The account is enabled.
            /// *   disabled: The account is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the account was last updated. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// The external ID of the account. The external ID can be used by external data to map the data of the account in IDaaS EIAM. By default, the external ID is the account ID.
            /// 
            /// For accounts with the same source type and source ID, each account has a unique external ID.
            /// </summary>
            [NameInMap("UserExternalId")]
            [Validation(Required=false)]
            public string UserExternalId { get; set; }

            /// <summary>
            /// The ID of the account.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The source ID of the account.
            /// 
            /// If the account was created in IDaaS, its source ID is the ID of the IDaaS instance. If the account was imported, its source ID is the enterprise ID in the source. For example, if the account was imported from DingTalk, its source ID is the corpId value of the enterprise in DingTalk.
            /// </summary>
            [NameInMap("UserSourceId")]
            [Validation(Required=false)]
            public string UserSourceId { get; set; }

            /// <summary>
            /// The source type of the account. Valid values:
            /// 
            /// *   build_in: The account was created in IDaaS.
            /// *   ding_talk: The account was imported from DingTalk.
            /// *   ad: The account was imported from Microsoft Active Directory (AD).
            /// *   ldap: The account was imported from a Lightweight Directory Access Protocol (LDAP) service.
            /// </summary>
            [NameInMap("UserSourceType")]
            [Validation(Required=false)]
            public string UserSourceType { get; set; }

            /// <summary>
            /// The username of the account.
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
