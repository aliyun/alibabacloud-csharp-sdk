// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data object of the account.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The time when the account expires. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("AccountExpireTime")]
            [Validation(Required=false)]
            public long? AccountExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the account was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of custom fields that describe the account.</para>
            /// </summary>
            [NameInMap("CustomFields")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserCustomFields> CustomFields { get; set; }
            public class GetUserResponseBodyUserCustomFields : TeaModel {
                /// <summary>
                /// <para>The identifier of the custom field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>The value of the custom field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            /// <summary>
            /// <para>The description of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test account</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>display_name001</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the user who owns the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user@example.com">user@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the email address has been verified. A value of true indicates that the email address has been verified by the user or has been set to the verified status by the administrator. A value of false indicates that the email address has not been verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailVerified")]
            [Validation(Required=false)]
            public bool? EmailVerified { get; set; }

            /// <summary>
            /// <para>The organizational units to which the account belongs.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserGroups> Groups { get; set; }
            public class GetUserResponseBodyUserGroups : TeaModel {
                /// <summary>
                /// <para>The description of the organizational unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is a test.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the organizational unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group_d6sbsuumeta4h66ec3il7yxxxx</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the organizational unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group_test_name</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the account lock expires. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("LockExpireTime")]
            [Validation(Required=false)]
            public long? LockExpireTime { get; set; }

            /// <summary>
            /// <para>The organizational units to which the account belongs.</para>
            /// </summary>
            [NameInMap("OrganizationalUnits")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserOrganizationalUnits> OrganizationalUnits { get; set; }
            public class GetUserResponseBodyUserOrganizationalUnits : TeaModel {
                /// <summary>
                /// <para>The ID of the organizational unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
                /// </summary>
                [NameInMap("OrganizationalUnitId")]
                [Validation(Required=false)]
                public string OrganizationalUnitId { get; set; }

                /// <summary>
                /// <para>The name of the organizational unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_ou_name</para>
                /// </summary>
                [NameInMap("OrganizationalUnitName")]
                [Validation(Required=false)]
                public string OrganizationalUnitName { get; set; }

                /// <summary>
                /// <para>Indicates whether the organization is the primary organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

            }

            /// <summary>
            /// <para>The time when the password of the account expires. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <list type="bullet">
            /// <item><description>If the value -1 is returned, the password does not expire.</description></item>
            /// <item><description>If no value is returned, the password does not expire.</description></item>
            /// <item><description>If a UNIX timestamp is returned, the password expires at the indicated point of time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("PasswordExpireTime")]
            [Validation(Required=false)]
            public long? PasswordExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether a password is set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordSet")]
            [Validation(Required=false)]
            public bool? PasswordSet { get; set; }

            /// <summary>
            /// <para>The mobile number of the user who owns the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156xxxxxxx</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>Indicates whether the mobile number has been verified. A value of true indicates that the mobile number has been verified by the user or has been set to the verified status by the administrator. A value of false indicates that the mobile number has not been verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PhoneNumberVerified")]
            [Validation(Required=false)]
            public bool? PhoneNumberVerified { get; set; }

            /// <summary>
            /// <para>The country code of the mobile number. For example, the country code of China is 86 without 00 or +.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("PhoneRegion")]
            [Validation(Required=false)]
            public string PhoneRegion { get; set; }

            /// <summary>
            /// <para>Preferred language</para>
            /// 
            /// <b>Example:</b>
            /// <para>en-US</para>
            /// </summary>
            [NameInMap("PreferredLanguage")]
            [Validation(Required=false)]
            public string PreferredLanguage { get; set; }

            /// <summary>
            /// <para>The ID of the primary organizational unit to which the account belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("PrimaryOrganizationalUnitId")]
            [Validation(Required=false)]
            public string PrimaryOrganizationalUnitId { get; set; }

            /// <summary>
            /// <para>The time when the account was registered. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public long? RegisterTime { get; set; }

            /// <summary>
            /// <para>The status of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: The account is enabled.</description></item>
            /// <item><description>disabled: The account is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the account was last updated. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The external ID of the account. The external ID can be used by external data to map the data of the account in IDaaS EIAM. By default, the external ID is the account ID.</para>
            /// <para>For accounts with the same source type and source ID, each account has a unique external ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserExternalId")]
            [Validation(Required=false)]
            public string UserExternalId { get; set; }

            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The source ID of the account.</para>
            /// <para>If the account was created in IDaaS, its source ID is the ID of the IDaaS instance. If the account was imported, its source ID is the enterprise ID in the source. For example, if the account was imported from DingTalk, its source ID is the corpId value of the enterprise in DingTalk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("UserSourceId")]
            [Validation(Required=false)]
            public string UserSourceId { get; set; }

            /// <summary>
            /// <para>The source type of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>build_in: The account was created in IDaaS.</description></item>
            /// <item><description>ding_talk: The account was imported from DingTalk.</description></item>
            /// <item><description>ad: The account was imported from Microsoft Active Directory (AD).</description></item>
            /// <item><description>ldap: The account was imported from a Lightweight Directory Access Protocol (LDAP) service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("UserSourceType")]
            [Validation(Required=false)]
            public string UserSourceType { get; set; }

            /// <summary>
            /// <para>The username of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name001</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
