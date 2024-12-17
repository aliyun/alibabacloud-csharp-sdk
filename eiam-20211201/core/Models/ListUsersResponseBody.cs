// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersResponseBody : TeaModel {
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
        /// <para>The number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of data objects of accounts.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyUsers> Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
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
            /// <para>Time When Password Expires</para>
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
