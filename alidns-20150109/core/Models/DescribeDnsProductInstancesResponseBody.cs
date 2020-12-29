// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstancesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("DnsProducts")]
        [Validation(Required=false)]
        public List<DescribeDnsProductInstancesResponseBodyDnsProducts> DnsProducts { get; set; }
        public class DescribeDnsProductInstancesResponseBodyDnsProducts : TeaModel {
            [NameInMap("OverseaLine")]
            [Validation(Required=false)]
            public string OverseaLine { get; set; }

            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("MonitorNodeCount")]
            [Validation(Required=false)]
            public long? MonitorNodeCount { get; set; }

            [NameInMap("InBlackHole")]
            [Validation(Required=false)]
            public bool? InBlackHole { get; set; }

            [NameInMap("BindDomainUsedCount")]
            [Validation(Required=false)]
            public long? BindDomainUsedCount { get; set; }

            [NameInMap("ISPRegionLines")]
            [Validation(Required=false)]
            public string ISPRegionLines { get; set; }

            [NameInMap("TTLMinValue")]
            [Validation(Required=false)]
            public long? TTLMinValue { get; set; }

            [NameInMap("ISPLines")]
            [Validation(Required=false)]
            public string ISPLines { get; set; }

            [NameInMap("SearchEngineLines")]
            [Validation(Required=false)]
            public string SearchEngineLines { get; set; }

            [NameInMap("EndTimestamp")]
            [Validation(Required=false)]
            public long? EndTimestamp { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

            [NameInMap("MonitorTaskCount")]
            [Validation(Required=false)]
            public long? MonitorTaskCount { get; set; }

            [NameInMap("BindUsedCount")]
            [Validation(Required=false)]
            public long? BindUsedCount { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("MonitorFrequency")]
            [Validation(Required=false)]
            public long? MonitorFrequency { get; set; }

            [NameInMap("InClean")]
            [Validation(Required=false)]
            public bool? InClean { get; set; }

            [NameInMap("URLForwardCount")]
            [Validation(Required=false)]
            public long? URLForwardCount { get; set; }

            [NameInMap("StartTimestamp")]
            [Validation(Required=false)]
            public long? StartTimestamp { get; set; }

            [NameInMap("DDosDefendQuery")]
            [Validation(Required=false)]
            public long? DDosDefendQuery { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("DDosDefendFlow")]
            [Validation(Required=false)]
            public long? DDosDefendFlow { get; set; }

            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public long? BindCount { get; set; }

            [NameInMap("SubDomainLevel")]
            [Validation(Required=false)]
            public long? SubDomainLevel { get; set; }

            [NameInMap("BindDomainCount")]
            [Validation(Required=false)]
            public long? BindDomainCount { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("OverseaDDosDefendFlow")]
            [Validation(Required=false)]
            public long? OverseaDDosDefendFlow { get; set; }

            [NameInMap("RegionLines")]
            [Validation(Required=false)]
            public bool? RegionLines { get; set; }

            [NameInMap("Gslb")]
            [Validation(Required=false)]
            public bool? Gslb { get; set; }

            [NameInMap("DnsSecurity")]
            [Validation(Required=false)]
            public string DnsSecurity { get; set; }

            [NameInMap("DnsSLBCount")]
            [Validation(Required=false)]
            public long? DnsSLBCount { get; set; }

        }

    }

}
