// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned address pools.</para>
        /// </summary>
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool : TeaModel {
                /// <summary>
                /// <para>The number of addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// <para>The ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pool-1</para>
                /// </summary>
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                /// <summary>
                /// <para>The time when the address pool was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the address pool was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The load balancing policy of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALL_RR: returns all addresses.</description></item>
                /// <item><description>RATIO: returns addresses by weight.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all_rr</para>
                /// </summary>
                [NameInMap("LbaStrategy")]
                [Validation(Required=false)]
                public string LbaStrategy { get; set; }

                /// <summary>
                /// <para>The ID of the health check task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc123</para>
                /// </summary>
                [NameInMap("MonitorConfigId")]
                [Validation(Required=false)]
                public string MonitorConfigId { get; set; }

                /// <summary>
                /// <para>Indicates whether health checks are configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OPEN: enabled</description></item>
                /// <item><description>CLOSE: disabled</description></item>
                /// <item><description>UNCONFIGURED: not configured</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>open</para>
                /// </summary>
                [NameInMap("MonitorStatus")]
                [Validation(Required=false)]
                public string MonitorStatus { get; set; }

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testpool</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IPV4: IPv4 address</description></item>
                /// <item><description>IPV6: IPv6 address</description></item>
                /// <item><description>DOMAIN: domain name</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time when the address pool was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the address pool was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned on all pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
