// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstancesResponseBody : TeaModel {
        /// <summary>
        /// The list of Alibaba Cloud DNS instances obtained by this operation.
        /// </summary>
        [NameInMap("DnsProducts")]
        [Validation(Required=false)]
        public DescribeDnsProductInstancesResponseBodyDnsProducts DnsProducts { get; set; }
        public class DescribeDnsProductInstancesResponseBodyDnsProducts : TeaModel {
            [NameInMap("DnsProduct")]
            [Validation(Required=false)]
            public List<DescribeDnsProductInstancesResponseBodyDnsProductsDnsProduct> DnsProduct { get; set; }
            public class DescribeDnsProductInstancesResponseBodyDnsProductsDnsProduct : TeaModel {
                /// <summary>
                /// Indicates whether auto-renewal is enabled for the extra internal bandwidth that you purchased. Valid values:
                /// 
                /// *   **true**: Auto-renewal is enabled.
                /// *   **false**: Auto-renewal is disabled.
                /// 
                /// > If no extra internal bandwidth is purchased, this parameter is not returned.
                /// </summary>
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// The number of times you can change domain names that are bound to the DNS instance. It can be specified by the user who uses Alibaba Cloud DNS of the custom version.
                /// </summary>
                [NameInMap("BindCount")]
                [Validation(Required=false)]
                public long? BindCount { get; set; }

                /// <summary>
                /// The number of domain names that can be bound to the DNS instance.
                /// </summary>
                [NameInMap("BindDomainCount")]
                [Validation(Required=false)]
                public long? BindDomainCount { get; set; }

                /// <summary>
                /// The number of domain names that have been bound to the DNS instance.
                /// </summary>
                [NameInMap("BindDomainUsedCount")]
                [Validation(Required=false)]
                public long? BindDomainUsedCount { get; set; }

                /// <summary>
                /// The number of times you have changed domain names that are bound to the DNS instance. It can be specified by the user who uses Alibaba Cloud DNS of the custom version.
                /// </summary>
                [NameInMap("BindUsedCount")]
                [Validation(Required=false)]
                public long? BindUsedCount { get; set; }

                /// <summary>
                /// The DDoS protection traffic. Unit: GB.
                /// </summary>
                [NameInMap("DDosDefendFlow")]
                [Validation(Required=false)]
                public long? DDosDefendFlow { get; set; }

                /// <summary>
                /// The DDoS protection frequency. Unit: 10,000 QPS.
                /// </summary>
                [NameInMap("DDosDefendQuery")]
                [Validation(Required=false)]
                public long? DDosDefendQuery { get; set; }

                /// <summary>
                /// The number of IP addresses supported by a domain name or line.
                /// </summary>
                [NameInMap("DnsSLBCount")]
                [Validation(Required=false)]
                public long? DnsSLBCount { get; set; }

                /// <summary>
                /// The DNS security policy. Valid values:
                /// 
                /// *   **no**: not required.
                /// *   **basic**: anti-DDoS basic.
                /// *   **advanced**: anti-DDoS advanced.
                /// </summary>
                [NameInMap("DnsSecurity")]
                [Validation(Required=false)]
                public string DnsSecurity { get; set; }

                /// <summary>
                /// The bound domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The time at which the instance expired.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The UNIX timestamp representing the expiration time of the instance.
                /// </summary>
                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// Indicates whether global server load balancing (GSLB) was allowed.
                /// </summary>
                [NameInMap("Gslb")]
                [Validation(Required=false)]
                public bool? Gslb { get; set; }

                /// <summary>
                /// The list of ISP lines.
                /// </summary>
                [NameInMap("ISPLines")]
                [Validation(Required=false)]
                public string ISPLines { get; set; }

                /// <summary>
                /// The list of ISP line subdivisions.
                /// </summary>
                [NameInMap("ISPRegionLines")]
                [Validation(Required=false)]
                public string ISPRegionLines { get; set; }

                /// <summary>
                /// Indicates whether the request for domain name resolution was in the black hole.
                /// </summary>
                [NameInMap("InBlackHole")]
                [Validation(Required=false)]
                public bool? InBlackHole { get; set; }

                /// <summary>
                /// Indicates whether the request for domain name resolution was being cleared.
                /// </summary>
                [NameInMap("InClean")]
                [Validation(Required=false)]
                public bool? InClean { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud DNS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The monitoring frequency. Unit: minutes.
                /// </summary>
                [NameInMap("MonitorFrequency")]
                [Validation(Required=false)]
                public long? MonitorFrequency { get; set; }

                /// <summary>
                /// The number of monitored nodes.
                /// </summary>
                [NameInMap("MonitorNodeCount")]
                [Validation(Required=false)]
                public long? MonitorNodeCount { get; set; }

                /// <summary>
                /// The number of monitoring tasks.
                /// </summary>
                [NameInMap("MonitorTaskCount")]
                [Validation(Required=false)]
                public long? MonitorTaskCount { get; set; }

                /// <summary>
                /// DDoS protection traffic outside China. Unit: GB.
                /// </summary>
                [NameInMap("OverseaDDosDefendFlow")]
                [Validation(Required=false)]
                public long? OverseaDDosDefendFlow { get; set; }

                /// <summary>
                /// The type of the overseas line.
                /// </summary>
                [NameInMap("OverseaLine")]
                [Validation(Required=false)]
                public string OverseaLine { get; set; }

                /// <summary>
                /// The billing method. Valid value:
                /// 
                /// *   Subscription: You can pay in advance for the use of resources.
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// Indicates whether regional lines were allowed.
                /// </summary>
                [NameInMap("RegionLines")]
                [Validation(Required=false)]
                public bool? RegionLines { get; set; }

                /// <summary>
                /// The list of search engine lines.
                /// </summary>
                [NameInMap("SearchEngineLines")]
                [Validation(Required=false)]
                public string SearchEngineLines { get; set; }

                /// <summary>
                /// The time when the DNS instance was purchased.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The UNIX timestamp representing when the DNS instance was purchased.
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// The number of subdomain name levels.
                /// </summary>
                [NameInMap("SubDomainLevel")]
                [Validation(Required=false)]
                public long? SubDomainLevel { get; set; }

                /// <summary>
                /// The minimum TTL. Unit: seconds.
                /// </summary>
                [NameInMap("TTLMinValue")]
                [Validation(Required=false)]
                public long? TTLMinValue { get; set; }

                /// <summary>
                /// The URL forwarding quantity.
                /// </summary>
                [NameInMap("URLForwardCount")]
                [Validation(Required=false)]
                public long? URLForwardCount { get; set; }

                /// <summary>
                /// The version code of the Alibaba Cloud DNS instance.
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                /// <summary>
                /// The version name of the Alibaba Cloud DNS instance.
                /// </summary>
                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

        }

        /// <summary>
        /// The type of the domain name. Valid values:
        /// 
        /// *   PUBLIC (default): hosted public domain name
        /// *   CACHE: cached public domain name
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of domain names.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
