// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AccountLinkInfo : TeaModel {
        /// <summary>
        /// <para>The type of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mobile: mobile number</description></item>
        /// <item><description>email: email address</description></item>
        /// <item><description>ding: DingTalk account</description></item>
        /// <item><description>ram: Alibaba Cloud Resource Access Management (RAM) user</description></item>
        /// <item><description>wechat: WeCom account</description></item>
        /// <item><description>ldap: Lightweight Directory Access Protocol (LDAP) account</description></item>
        /// <item><description>custom: custom account</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mobile</para>
        /// </summary>
        [NameInMap("authentication_type")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// <para>The time when the account was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639762579768</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The display name of the account. For example, the unique identifier of an LDAP account is its UID, but the account display name can be the job number or other information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>001</para>
        /// </summary>
        [NameInMap("display_name")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The additional information about the account. If the account type is a mobile number, the value of this parameter indicates the country code. For example, the country code in the Chinese mainland is 86 and a value of 86 is returned only if authentication_type is set to mobile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>The unique identifier of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136***000</para>
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("last_login_time")]
        [Validation(Required=false)]
        public long? LastLoginTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The user ID of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00016a587b62b50003deea299a4f5b50</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
