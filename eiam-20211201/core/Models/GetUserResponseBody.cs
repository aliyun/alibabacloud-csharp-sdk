// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The account object data.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The expiration time of the account, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("AccountExpireTime")]
            [Validation(Required=false)]
            public long? AccountExpireTime { get; set; }

            /// <summary>
            /// <para>The creation time of the account, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of custom fields of the account.</para>
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
            /// <para>The email address of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user@example.com">user@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the email address is verified. A value of true indicates that the email address has been verified by the user or set as verified by the administrator. A value of false indicates that the email address is not verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailVerified")]
            [Validation(Required=false)]
            public bool? EmailVerified { get; set; }

            /// <summary>
            /// <para>The list of groups to which the account belongs.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserGroups> Groups { get; set; }
            public class GetUserResponseBodyUserGroups : TeaModel {
                /// <summary>
                /// <para>The group description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is a test.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group_d6sbsuumeta4h66ec3il7yxxxx</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group_test_name</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The lock expiration time, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("LockExpireTime")]
            [Validation(Required=false)]
            public long? LockExpireTime { get; set; }

            /// <summary>
            /// <para>The list of organizational units to which the account belongs.</para>
            /// </summary>
            [NameInMap("OrganizationalUnits")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUserOrganizationalUnits> OrganizationalUnits { get; set; }
            public class GetUserResponseBodyUserOrganizationalUnits : TeaModel {
                /// <summary>
                /// <para>The organizational unit ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
                /// </summary>
                [NameInMap("OrganizationalUnitId")]
                [Validation(Required=false)]
                public string OrganizationalUnitId { get; set; }

                /// <summary>
                /// <para>The organizational unit name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_ou_name</para>
                /// </summary>
                [NameInMap("OrganizationalUnitName")]
                [Validation(Required=false)]
                public string OrganizationalUnitName { get; set; }

                /// <summary>
                /// <para>Indicates whether this is the primary organizational unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

            }

            /// <summary>
            /// <para>The expiration time of the password, in UNIX timestamp format. Unit: milliseconds.</para>
            /// <list type="bullet">
            /// <item><description><para>A return value of -1 indicates that the password does not expire.</para>
            /// </description></item>
            /// <item><description><para>No return value indicates that the password does not expire.</para>
            /// </description></item>
            /// <item><description><para>A specific timestamp value indicates the exact password expiration time.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("PasswordExpireTime")]
            [Validation(Required=false)]
            public long? PasswordExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the password is set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordSet")]
            [Validation(Required=false)]
            public bool? PasswordSet { get; set; }

            /// <summary>
            /// <para>The phone number of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156xxxxxxx</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>Indicates whether the phone number is verified. A value of true indicates that the phone number has been verified by the user or set as verified by the administrator. A value of false indicates that the phone number is not verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PhoneNumberVerified")]
            [Validation(Required=false)]
            public bool? PhoneNumberVerified { get; set; }

            /// <summary>
            /// <para>The country calling code of the phone number. Example: 86 for the Chinese mainland. The code does not include the 00 or + prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("PhoneRegion")]
            [Validation(Required=false)]
            public string PhoneRegion { get; set; }

            /// <summary>
            /// <para>The preferred language.</para>
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
            /// <para>The registration time of the account, in UNIX timestamp format. Unit: milliseconds.</para>
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
            /// <item><description><para>enabled: enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The most recent update time of the account, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The external ID of the account. This ID is used to associate external data with the IDaaS account. The default value is the IDaaS account ID.</para>
            /// <remarks>
            /// <para>Note: The external ID must be unique within the same source type and source ID.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserExternalId")]
            [Validation(Required=false)]
            public string UserExternalId { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The source ID of the account.</para>
            /// <para>For the self-built type, the default value is the instance ID. For other types, the value corresponds to the enterprise ID of the respective source. For example, the DingTalk source corresponds to the corpId of the DingTalk enterprise.</para>
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
            /// <item><description><para>build_in: self-built.</para>
            /// </description></item>
            /// <item><description><para>ding_talk: imported from DingTalk.</para>
            /// </description></item>
            /// <item><description><para>ad: imported from AD.</para>
            /// </description></item>
            /// <item><description><para>ldap: imported from LDAP.</para>
            /// </description></item>
            /// <item><description><para>we_com: imported from WeCom.</para>
            /// </description></item>
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
