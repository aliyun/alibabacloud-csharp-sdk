// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned list of address pools of the GTM instance.</para>
        /// </summary>
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeGtmInstanceAddressPoolsResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeGtmInstanceAddressPoolsResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool : TeaModel {
                /// <summary>
                /// <para>The number of addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// <para>The ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234abc</para>
                /// </summary>
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                /// <summary>
                /// <para>The time when this address pool was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The minimum number of available addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinAvailableAddrNum")]
                [Validation(Required=false)]
                public int? MinAvailableAddrNum { get; set; }

                /// <summary>
                /// <para>The health check ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100abc</para>
                /// </summary>
                [NameInMap("MonitorConfigId")]
                [Validation(Required=false)]
                public string MonitorConfigId { get; set; }

                /// <summary>
                /// <para>Indicates whether health check was enabled for the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OPEN</b>: Enabled</description></item>
                /// <item><description><b>CLOSE</b>: Disabled</description></item>
                /// <item><description><b>UNCONFIGURED</b>: Not configured</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("MonitorStatus")]
                [Validation(Required=false)]
                public string MonitorStatus { get; set; }

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The availability status of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AVAILABLE</b>: Available</description></item>
                /// <item><description><b>NOT_AVAILABLE</b>: Unavailable</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>IP</b>: IP address</description></item>
                /// <item><description><b>DOMAIN</b>: Domain name</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IP</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The last time when the address pool was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>A timestamp that indicates the last time the address pool was updated.</para>
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
        /// <para>The number of the page returned.</para>
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
        /// <para>20</para>
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
        /// <para>2</para>
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
