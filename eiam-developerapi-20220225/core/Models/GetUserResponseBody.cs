// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the account expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652085686179</para>
        /// </summary>
        [NameInMap("accountExpireTime")]
        [Validation(Required=false)]
        public long? AccountExpireTime { get; set; }

        /// <summary>
        /// <para>The time when the account was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652085686179</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The extended fields of the account.</para>
        /// </summary>
        [NameInMap("customFields")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyCustomFields> CustomFields { get; set; }
        public class GetUserResponseBodyCustomFields : TeaModel {
            /// <summary>
            /// <para>The name of the extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the extended field. Field values are returned as strings regardless of the data types of the fields. For example, true or false is returned for a Boolean field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>字段数据值</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The description of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>display_name001</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Indicates whether the email address has been verified. A value of true indicates that the email address has been verified by the user or has been set to the verified status by the administrator. A value of false indicates that the email address has not been verified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("emailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// <para>账户所属组列表。</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyGroups> Groups { get; set; }
        public class GetUserResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>组描述。</para>
            /// 
            /// <b>Example:</b>
            /// <para>description_demo</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>组ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_ufdsasn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>组名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>name_test</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The time when the account lock expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652085686179</para>
        /// </summary>
        [NameInMap("lockExpireTime")]
        [Validation(Required=false)]
        public long? LockExpireTime { get; set; }

        /// <summary>
        /// <para>The organizational units to which the account belongs.</para>
        /// </summary>
        [NameInMap("organizationalUnits")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyOrganizationalUnits> OrganizationalUnits { get; set; }
        public class GetUserResponseBodyOrganizationalUnits : TeaModel {
            /// <summary>
            /// <para>The ID of the organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("organizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// <para>The name of the organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name001</para>
            /// </summary>
            [NameInMap("organizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            /// <summary>
            /// <para>Indicates whether the organizational unit is the primary organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("primary")]
            [Validation(Required=false)]
            public bool? Primary { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the password is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("passwordSet")]
        [Validation(Required=false)]
        public bool? PasswordSet { get; set; }

        /// <summary>
        /// <para>The mobile number of the user who owns the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxx</para>
        /// </summary>
        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Indicates whether the mobile number has been verified. A value of true indicates that the mobile number has been verified by the user or has been set to the verified status by the administrator. A value of false indicates that the mobile number has not been verified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("phoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The country code of the mobile number. For example, the country code of China is 86 without 00 or +.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("phoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>The ID of the primary organizational unit of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("primaryOrganizationalUnitId")]
        [Validation(Required=false)]
        public string PrimaryOrganizationalUnitId { get; set; }

        /// <summary>
        /// <para>The time when the account was registered. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652085686179</para>
        /// </summary>
        [NameInMap("registerTime")]
        [Validation(Required=false)]
        public long? RegisterTime { get; set; }

        /// <summary>
        /// <para>The status of the account. Valid values: enabled disabled</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the account was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652085686179</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// <para>The external ID of the account. The external ID can be used to map external data to the data of the account in EIAM of Identity as a Service (IDaaS). By default, the external ID is the account ID.</para>
        /// <para>Note: For accounts with the same source type and source ID, each account has a unique external ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("userExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The source ID of the account.</para>
        /// <para>If the account was created in IDaaS, its source ID is the ID of the IDaaS instance. If the account was imported, its source ID is the enterprise ID in the source. For example, if the account was imported from DingTalk, its source ID is the corpId value of the enterprise in DingTalk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("userSourceId")]
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
        [NameInMap("userSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

        /// <summary>
        /// <para>The username of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name001</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
