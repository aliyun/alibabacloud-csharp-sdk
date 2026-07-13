// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsCacheDomainRequest : TeaModel {
        /// <summary>
        /// <para>The maximum TTL for cached data from an origin fetch. The value must be an integer from 30 to 86400.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("CacheTtlMax")]
        [Validation(Required=false)]
        public int? CacheTtlMax { get; set; }

        /// <summary>
        /// <para>The minimum time-to-live (TTL) for cached data from an origin fetch. The value must be an integer from 30 to 86400.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CacheTtlMin")]
        [Validation(Required=false)]
        public int? CacheTtlMin { get; set; }

        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt; Call the <a href="https://help.aliyun.com/en/dns/api-alidns-2015-01-09-describedomains">DescribeDomains</a> operation to query the domain name.
        /// &lt;props=&quot;intl&quot;&gt;Call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describedomains">DescribeDomains</a> operation to query the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the authoritative proxy instance.&lt;props=&quot;china&quot;&gt; Call the <a href="https://help.aliyun.com/en/dns/api-alidns-2015-01-09-listcloudgtminstances">ListCloudGtmInstances</a> operation to query the instance ID.
        /// &lt;props=&quot;intl&quot;&gt;Call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-listcloudgtminstances">ListCloudGtmInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns-cn-*****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is zh. Valid values:</para>
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

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>A list of origin DNS servers. You can specify up to 10 servers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceDnsServer")]
        [Validation(Required=false)]
        public List<AddDnsCacheDomainRequestSourceDnsServer> SourceDnsServer { get; set; }
        public class AddDnsCacheDomainRequestSourceDnsServer : TeaModel {
            /// <summary>
            /// <para>The domain name or IP address of the origin server.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The port of the origin DNS server.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>SUPPORT: The origin server supports EDNS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUPPORT</para>
        /// </summary>
        [NameInMap("SourceEdns")]
        [Validation(Required=false)]
        public string SourceEdns { get; set; }

        /// <summary>
        /// <para>The protocol used for origin fetch. Valid values: TCP and UDP. The default value is UDP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UDP</para>
        /// </summary>
        [NameInMap("SourceProtocol")]
        [Validation(Required=false)]
        public string SourceProtocol { get; set; }

    }

}
