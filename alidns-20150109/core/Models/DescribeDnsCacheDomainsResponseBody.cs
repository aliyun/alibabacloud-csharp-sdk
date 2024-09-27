// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsCacheDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDnsCacheDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDnsCacheDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The maximum time-to-live (TTL) period of the cached data retrieved from the origin DNS server. Unit: seconds. Valid values: 30 to 86400.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("CacheTtlMax")]
            [Validation(Required=false)]
            public int? CacheTtlMax { get; set; }

            /// <summary>
            /// <para>The minimum TTL period of the cached data retrieved from the origin DNS server. Unit: seconds. Valid values: 30 to 86400.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CacheTtlMin")]
            [Validation(Required=false)]
            public int? CacheTtlMin { get; set; }

            /// <summary>
            /// <para>The time when the domain name was added. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-17T06:13Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the domain name was added. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660546144000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the cache-accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00efd71a-770e-4255-b54e-6fe5659baffe</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The cache-accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dns-example.top</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02T16:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1692374400000</para>
            /// </summary>
            [NameInMap("ExpireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>The instance ID of the cache-accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-7bg</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The description of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The origin DNS servers.</para>
            /// </summary>
            [NameInMap("SourceDnsServers")]
            [Validation(Required=false)]
            public List<DescribeDnsCacheDomainsResponseBodyDomainsSourceDnsServers> SourceDnsServers { get; set; }
            public class DescribeDnsCacheDomainsResponseBodyDomainsSourceDnsServers : TeaModel {
                /// <summary>
                /// <para>The domain name or IP address of the origin DNS server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ns8.alidns.com</para>
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
            /// <para>Specifies whether the origin Domain Name System (DNS) server supports Extension Mechanisms for DNS (EDNS). Valid values: NOT_SUPPORT and SUPPORT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUPPORT</para>
            /// </summary>
            [NameInMap("SourceEdns")]
            [Validation(Required=false)]
            public string SourceEdns { get; set; }

            /// <summary>
            /// <para>The origin protocol policy. Valid values: TCP and UDP. Default value: UDP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UDP</para>
            /// </summary>
            [NameInMap("SourceProtocol")]
            [Validation(Required=false)]
            public string SourceProtocol { get; set; }

            /// <summary>
            /// <para>The time when the configurations of the domain name were updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-22T03:40Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The time when the configurations of the domain name were updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671690491000</para>
            /// </summary>
            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            /// <summary>
            /// <para>The edition code of Alibaba Cloud DNS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ultimate</para>
            /// </summary>
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57121A9C-CDCF-541F-AD39-275D89099420</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
