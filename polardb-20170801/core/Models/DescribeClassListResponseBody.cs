// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeClassListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cluster specifications.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeClassListResponseBodyItems> Items { get; set; }
        public class DescribeClassListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The cluster specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.medium</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The family of the cluster specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Exclusive package</para>
            /// </description></item>
            /// <item><description><para>Exclusive physical machine</para>
            /// </description></item>
            /// <item><description><para>Beginner</para>
            /// </description></item>
            /// <item><description><para>Historical specifications</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exclusive package</para>
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// <para>The specification type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("ClassTypeLevel")]
            [Validation(Required=false)]
            public string ClassTypeLevel { get; set; }

            /// <summary>
            /// <para>The number of CPU cores. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The maximum storage capacity of an ESSD. Unit: TB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("EssdMaxStorageCapacity")]
            [Validation(Required=false)]
            public string EssdMaxStorageCapacity { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections to the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public string MaxConnections { get; set; }

            /// <summary>
            /// <para>The maximum IOPS. Unit: IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32000</para>
            /// </summary>
            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public string MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum storage capacity. Unit: TB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxStorageCapacity")]
            [Validation(Required=false)]
            public string MaxStorageCapacity { get; set; }

            /// <summary>
            /// <para>The memory capacity. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// <para>The maximum IOPS of an Enhanced SSD (ESSD) at performance level 1 (PL1). Unit: IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("Pl1MaxIOPS")]
            [Validation(Required=false)]
            public string Pl1MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum IOPS of an ESSD at PL2. Unit: IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("Pl2MaxIOPS")]
            [Validation(Required=false)]
            public string Pl2MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum IOPS of an ESSD at PL3. Unit: IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("Pl3MaxIOPS")]
            [Validation(Required=false)]
            public string Pl3MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum storage capacity of PSL4/PSL5. Unit: TB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("PolarStoreMaxStorageCapacity")]
            [Validation(Required=false)]
            public string PolarStoreMaxStorageCapacity { get; set; }

            /// <summary>
            /// <para>The maximum input/output operations per second (IOPS) of PSL4. Unit: IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48000</para>
            /// </summary>
            [NameInMap("Psl4MaxIOPS")]
            [Validation(Required=false)]
            public string Psl4MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum IOPS of PSL5. Unit: IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96000</para>
            /// </summary>
            [NameInMap("Psl5MaxIOPS")]
            [Validation(Required=false)]
            public string Psl5MaxIOPS { get; set; }

            /// <summary>
            /// <para>The additional price.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;Unit: cents (CNY).
            /// &lt;props=&quot;intl&quot;&gt;Unit: cents (USD).</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If you set the MasterHa parameter to cluster or single, the value of this parameter is the same as the value of the ReferencePrice parameter.</para>
            /// </description></item>
            /// <item><description><para>If you set the MasterHa parameter to cluster or single, the price for a single-node commodity is returned.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>200000</para>
            /// </summary>
            [NameInMap("ReferenceExtPrice")]
            [Validation(Required=false)]
            public string ReferenceExtPrice { get; set; }

            /// <summary>
            /// <para>The price.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;Unit: cents (CNY).
            /// &lt;props=&quot;intl&quot;&gt;Unit: cents (USD).</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If you set the CommodityCode parameter to a pay-as-you-go commodity code, the hourly price is returned.</para>
            /// </description></item>
            /// <item><description><para>If you set the CommodityCode parameter to a subscription commodity code, the monthly price is returned.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>200000</para>
            /// </summary>
            [NameInMap("ReferencePrice")]
            [Validation(Required=false)]
            public string ReferencePrice { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69A85BAF-1089-4CDF-A82F-0A140F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
