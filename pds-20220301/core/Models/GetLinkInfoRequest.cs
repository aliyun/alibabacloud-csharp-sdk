// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetLinkInfoRequest : TeaModel {
        /// <summary>
        /// <para>The additional information about the unique identifier of the account. For example, if type is set to mobile, set the value of extra to a country code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>The unique identifier of the account, such as a mobile number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130***</para>
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        /// <summary>
        /// <para>The account type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mobile: a mobile number.</description></item>
        /// <item><description>email: an email address.</description></item>
        /// <item><description>ding: a DingTalk account.</description></item>
        /// <item><description>ram: an Alibaba Cloud Resource Access Management (RAM) user.</description></item>
        /// <item><description>wechat: a WeCom account.</description></item>
        /// <item><description>ldap: a Lightweight Directory Access Protocol (LDAP) account.</description></item>
        /// <item><description>custom: a custom account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobile</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
