// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UnbindInstanceDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The list of domain names.</para>
        /// <para>Separate multiple domain names with commas (,). You can specify up to 100 domain names.&lt;props=&quot;intl&quot;&gt; For more information, see <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describedomains">DescribeDomains</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.net</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The ID of the authoritative domain name instance.&lt;props=&quot;intl&quot;&gt; For more information, see <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-listcloudgtminstances">ListCloudGtmInstances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns-cn-9lb38ldq9**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
