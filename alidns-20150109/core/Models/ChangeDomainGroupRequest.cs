// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ChangeDomainGroupRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt; Call <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeDomains</a> to obtain the domain name.
        /// &lt;props=&quot;intl&quot;&gt;Call <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a> to obtain the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the target domain name group.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify GroupId, the domain name is moved to the default group.</para>
        /// </description></item>
        /// <item><description><para>If GroupId is an empty string (&quot;&quot;), the domain name is moved to the default group.</para>
        /// </description></item>
        /// <item><description><para>If GroupId is defaultGroup, the domain name is moved to the default group.</para>
        /// </description></item>
        /// <item><description><para>If GroupId is a different value, the system checks if the group exists. If the group exists, the domain name\&quot;s group is updated. If the group does not exist, the group is not updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60bb3ef15ace449082cf914ed3ea****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
