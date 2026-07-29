// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data objects.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyData> Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the account expires. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("accountExpireTime")]
            [Validation(Required=false)]
            public long? AccountExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the account was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试账户</para>
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
            /// <para>The email address of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:example@example.com">example@example.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the email address is verified. A value of true indicates that the email address is verified by the user or set to verified by the administrator. A value of false indicates that the email address is not verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("emailVerified")]
            [Validation(Required=false)]
            public bool? EmailVerified { get; set; }

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
            /// <para>The time when the account lock expires. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("lockExpireTime")]
            [Validation(Required=false)]
            public long? LockExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether a password is set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("passwordSet")]
            [Validation(Required=false)]
            public bool? PasswordSet { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156xxxxxxx</para>
            /// </summary>
            [NameInMap("phoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>Indicates whether the mobile phone number is verified. A value of true indicates that the mobile phone number is verified by the user or set to verified by the administrator. A value of false indicates that the mobile phone number is not verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("phoneNumberVerified")]
            [Validation(Required=false)]
            public bool? PhoneNumberVerified { get; set; }

            /// <summary>
            /// <para>The area code for the mobile phone number. For example, the area code for a mobile phone number in the Chinese mainland is 86. Do not add 00 or a plus sign (+).</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("phoneRegion")]
            [Validation(Required=false)]
            public string PhoneRegion { get; set; }

            /// <summary>
            /// <para>The time when the account was registered. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("registerTime")]
            [Validation(Required=false)]
            public long? RegisterTime { get; set; }

            /// <summary>
            /// <para>The status of the account. Valid values: enabled: The account is enabled. disabled: The account is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the account was last updated. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The external ID of the account. This ID is used to map external data to the IDaaS account. By default, this parameter is the same as the IDaaS account ID.</para>
            /// <para>Note: The external ID must be unique for the same source type and source ID.</para>
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
            /// <para>For accounts created in IDaaS, the default value is the instance ID. For other types of accounts, the value is the enterprise ID from the source. For example, for an account from DingTalk, the value is the corpId of the DingTalk enterprise.</para>
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
            /// <item><description><para>build_in: The account is created in IDaaS.</para>
            /// </description></item>
            /// <item><description><para>ding_talk: The account is imported from DingTalk.</para>
            /// </description></item>
            /// <item><description><para>ad: The account is imported from Active Directory (AD).</para>
            /// </description></item>
            /// <item><description><para>ldap: The account is imported from LDAP.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("userSourceType")]
            [Validation(Required=false)]
            public string UserSourceType { get; set; }

            /// <summary>
            /// <para>The account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name001</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
