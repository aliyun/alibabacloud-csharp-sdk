// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstancesResponseBody : TeaModel {
        [NameInMap("DnsProducts")]
        [Validation(Required=false)]
        public DescribeDnsProductInstancesResponseBodyDnsProducts DnsProducts { get; set; }
        public class DescribeDnsProductInstancesResponseBodyDnsProducts : TeaModel {
            [NameInMap("DnsProduct")]
            [Validation(Required=false)]
            public List<DescribeDnsProductInstancesResponseBodyDnsProductsDnsProduct> DnsProduct { get; set; }
            public class DescribeDnsProductInstancesResponseBodyDnsProductsDnsProduct : TeaModel {
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                [NameInMap("BindCount")]
                [Validation(Required=false)]
                public long? BindCount { get; set; }

                [NameInMap("BindDomainCount")]
                [Validation(Required=false)]
                public long? BindDomainCount { get; set; }

                [NameInMap("BindDomainUsedCount")]
                [Validation(Required=false)]
                public long? BindDomainUsedCount { get; set; }

                [NameInMap("BindUsedCount")]
                [Validation(Required=false)]
                public long? BindUsedCount { get; set; }

                [NameInMap("DDosDefendFlow")]
                [Validation(Required=false)]
                public long? DDosDefendFlow { get; set; }

                [NameInMap("DDosDefendQuery")]
                [Validation(Required=false)]
                public long? DDosDefendQuery { get; set; }

                [NameInMap("DnsSLBCount")]
                [Validation(Required=false)]
                public long? DnsSLBCount { get; set; }

                [NameInMap("DnsSecurity")]
                [Validation(Required=false)]
                public string DnsSecurity { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                [NameInMap("Gslb")]
                [Validation(Required=false)]
                public bool? Gslb { get; set; }

                [NameInMap("ISPLines")]
                [Validation(Required=false)]
                public string ISPLines { get; set; }

                [NameInMap("ISPRegionLines")]
                [Validation(Required=false)]
                public string ISPRegionLines { get; set; }

                [NameInMap("InBlackHole")]
                [Validation(Required=false)]
                public bool? InBlackHole { get; set; }

                [NameInMap("InClean")]
                [Validation(Required=false)]
                public bool? InClean { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("MonitorFrequency")]
                [Validation(Required=false)]
                public long? MonitorFrequency { get; set; }

                [NameInMap("MonitorNodeCount")]
                [Validation(Required=false)]
                public long? MonitorNodeCount { get; set; }

                [NameInMap("MonitorTaskCount")]
                [Validation(Required=false)]
                public long? MonitorTaskCount { get; set; }

                [NameInMap("OverseaDDosDefendFlow")]
                [Validation(Required=false)]
                public long? OverseaDDosDefendFlow { get; set; }

                [NameInMap("OverseaLine")]
                [Validation(Required=false)]
                public string OverseaLine { get; set; }

                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                [NameInMap("RegionLines")]
                [Validation(Required=false)]
                public bool? RegionLines { get; set; }

                [NameInMap("SearchEngineLines")]
                [Validation(Required=false)]
                public string SearchEngineLines { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                [NameInMap("SubDomainLevel")]
                [Validation(Required=false)]
                public long? SubDomainLevel { get; set; }

                [NameInMap("TTLMinValue")]
                [Validation(Required=false)]
                public long? TTLMinValue { get; set; }

                [NameInMap("URLForwardCount")]
                [Validation(Required=false)]
                public long? URLForwardCount { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC (default): hosted public domain name</description></item>
        /// <item><description>CACHE: cached public domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
