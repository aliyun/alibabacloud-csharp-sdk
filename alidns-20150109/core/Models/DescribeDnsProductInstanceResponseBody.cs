// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstanceResponseBody : TeaModel {
        /// <summary>
        /// The auto-renewal status of the instance. Valid values:
        /// 
        /// *   **true**: Auto-renewal is enabled.
        /// *   **false**: Auto-renewal is disabled.
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// The number of times that you can change the domain names that are bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of the custom edition.
        /// </summary>
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public long? BindCount { get; set; }

        /// <summary>
        /// The number of domain names that can be bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of Personal Edition, Enterprise Standard Edition, and Enterprise Ultimate Edition.
        /// </summary>
        [NameInMap("BindDomainCount")]
        [Validation(Required=false)]
        public long? BindDomainCount { get; set; }

        /// <summary>
        /// The number of domain names that are bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of Personal Edition, Enterprise Standard Edition, and Enterprise Ultimate Edition.
        /// </summary>
        [NameInMap("BindDomainUsedCount")]
        [Validation(Required=false)]
        public long? BindDomainUsedCount { get; set; }

        /// <summary>
        /// The number of times that you have changed the domain names that are bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of the custom edition.
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
        /// The DDoS protection frequency. Unit: 10,000 QPS. This parameter applies to Alibaba Cloud DNS instances of the custom edition.
        /// </summary>
        [NameInMap("DDosDefendQuery")]
        [Validation(Required=false)]
        public long? DDosDefendQuery { get; set; }

        /// <summary>
        /// The maximum number of IP addresses that are used for load balancing in a single line of a domain name.
        /// </summary>
        [NameInMap("DnsSLBCount")]
        [Validation(Required=false)]
        public long? DnsSLBCount { get; set; }

        /// <summary>
        /// The DNS protection level. Valid values:
        /// 
        /// *   **no**: DNS protection is not provided.
        /// *   **basic**: Basic DNS attack defense is provided.
        /// *   **advanced**: Advanced DNS attack defense is provided.
        /// </summary>
        [NameInMap("DnsSecurity")]
        [Validation(Required=false)]
        public string DnsSecurity { get; set; }

        /// <summary>
        /// The DNS servers configured for the domain names.
        /// </summary>
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public DescribeDnsProductInstanceResponseBodyDnsServers DnsServers { get; set; }
        public class DescribeDnsProductInstanceResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// The domain name that is bound to the paid instance.
        /// 
        /// If no value is returned for this parameter, no domain name is bound to the paid instance.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The type of the instance. Valid values:
        /// 
        /// *   PUBLIC: authoritative domain name
        /// *   CACHE: cache-accelerated domain name
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The time when the instance expired. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The time when the instance expired. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// Indicates whether global server load balancing (GSLB) is supported.
        /// </summary>
        [NameInMap("Gslb")]
        [Validation(Required=false)]
        public bool? Gslb { get; set; }

        /// <summary>
        /// The Internet service provider (ISP) lines for DNS resolution.
        /// </summary>
        [NameInMap("ISPLines")]
        [Validation(Required=false)]
        public string ISPLines { get; set; }

        /// <summary>
        /// The regional ISP lines for DNS resolution.
        /// </summary>
        [NameInMap("ISPRegionLines")]
        [Validation(Required=false)]
        public string ISPRegionLines { get; set; }

        /// <summary>
        /// Indicates whether the Domain Name System (DNS) servers stopped responding to all requests sent to the domain names.
        /// </summary>
        [NameInMap("InBlackHole")]
        [Validation(Required=false)]
        public bool? InBlackHole { get; set; }

        /// <summary>
        /// Indicates whether the DNS servers stopped responding to abnormal requests sent to the domain names.
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
        /// The interval at which the instance is monitored. Unit: minutes.
        /// </summary>
        [NameInMap("MonitorFrequency")]
        [Validation(Required=false)]
        public long? MonitorFrequency { get; set; }

        /// <summary>
        /// The number of monitoring nodes.
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
        /// The DDoS protection traffic outside the Chinese mainland. Unit: GB.
        /// </summary>
        [NameInMap("OverseaDDosDefendFlow")]
        [Validation(Required=false)]
        public long? OverseaDDosDefendFlow { get; set; }

        /// <summary>
        /// The line outside the Chinese mainland.
        /// </summary>
        [NameInMap("OverseaLine")]
        [Validation(Required=false)]
        public string OverseaLine { get; set; }

        /// <summary>
        /// The billing method.
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Indicates whether regional lines are supported.
        /// </summary>
        [NameInMap("RegionLines")]
        [Validation(Required=false)]
        public bool? RegionLines { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The search engine lines for DNS resolution.
        /// </summary>
        [NameInMap("SearchEngineLines")]
        [Validation(Required=false)]
        public string SearchEngineLines { get; set; }

        /// <summary>
        /// The time when the instance was purchased. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The time when the instance was purchased. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
        /// The minimum time-to-live (TTL) period. Unit: seconds.
        /// </summary>
        [NameInMap("TTLMinValue")]
        [Validation(Required=false)]
        public long? TTLMinValue { get; set; }

        /// <summary>
        /// The number of the forwarded URLs.
        /// </summary>
        [NameInMap("URLForwardCount")]
        [Validation(Required=false)]
        public long? URLForwardCount { get; set; }

        /// <summary>
        /// The version code of Alibaba Cloud DNS.
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        /// <summary>
        /// The edition of Alibaba Cloud DNS.
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
