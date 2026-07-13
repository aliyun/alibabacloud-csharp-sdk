// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class RetrieveDomainRequest : TeaModel {
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
        /// <para>The language of the return value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
