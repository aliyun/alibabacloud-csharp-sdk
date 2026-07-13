// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsCacheDomainRequest : TeaModel {
        /// <summary>
        /// <para>The maximum TTL for cached data retrieved from the origin server. The value ranges from 30 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("CacheTtlMax")]
        [Validation(Required=false)]
        public int? CacheTtlMax { get; set; }

        /// <summary>
        /// <para>The minimum time-to-live (TTL) for cached data retrieved from the origin server. The value ranges from 30 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CacheTtlMin")]
        [Validation(Required=false)]
        public int? CacheTtlMin { get; set; }

        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt; To query the domain name, call <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeDomains</a>.
        /// &lt;props=&quot;intl&quot;&gt;To query the domain name, call <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the authoritative proxy domain name instance.&lt;props=&quot;china&quot;&gt; To query the instance ID, call <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-listcloudgtminstances?spm=a2c4g.11186623.help-menu-search-29697.d_0">ListCloudGtmInstances</a>.
        /// &lt;props=&quot;intl&quot;&gt;To query the instance ID, call <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-listcloudgtminstances?spm=a2c63.p38356.help-menu-search-29697.d_0">ListCloudGtmInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns-sg-l*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// <para><b>zh</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>A list of origin DNS servers. You can add up to 10 servers.</para>
        /// </summary>
        [NameInMap("SourceDnsServer")]
        [Validation(Required=false)]
        public List<UpdateDnsCacheDomainRequestSourceDnsServer> SourceDnsServer { get; set; }
        public class UpdateDnsCacheDomainRequestSourceDnsServer : TeaModel {
            /// <summary>
            /// <para>The domain name or IP address of the origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The port of the origin DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the origin server supports Extension Mechanisms for DNS (EDNS).
        /// SUPPORT: The origin server supports EDNS.
        /// NOT_SUPPORT: The origin server does not support EDNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUPPORT</para>
        /// </summary>
        [NameInMap("SourceEdns")]
        [Validation(Required=false)]
        public string SourceEdns { get; set; }

        /// <summary>
        /// <para>The origin protocol. Valid values: TCP and UDP. Default value: UDP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UDP</para>
        /// </summary>
        [NameInMap("SourceProtocol")]
        [Validation(Required=false)]
        public string SourceProtocol { get; set; }

    }

}
