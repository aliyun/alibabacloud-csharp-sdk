// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeClassListResponseBody : TeaModel {
        /// <summary>
        /// <para>The specifications of the cluster.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeClassListResponseBodyItems> Items { get; set; }
        public class DescribeClassListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The specifications of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.medium</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The instance family of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exclusive package: dedicated</description></item>
            /// <item><description>Exclusive physical machine: dedicated host</description></item>
            /// <item><description>Beginner: starter</description></item>
            /// <item><description>Historical specifications: historical</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exclusive package</para>
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// <para>The specification type of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("ClassTypeLevel")]
            [Validation(Required=false)]
            public string ClassTypeLevel { get; set; }

            /// <summary>
            /// <para>The number of vCPU cores. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("EssdMaxStorageCapacity")]
            [Validation(Required=false)]
            public string EssdMaxStorageCapacity { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public string MaxConnections { get; set; }

            /// <summary>
            /// <para>The maximum IOPS. Unit: operations per second.</para>
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
            /// <para>The memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// <para>The maximum IOPS of an enhanced SSD (ESSD) of performance level 1 (PL1). Unit: operations per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("Pl1MaxIOPS")]
            [Validation(Required=false)]
            public string Pl1MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum IOPS of an ESSD of performance level 2 (PL2). Unit: operations per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("Pl2MaxIOPS")]
            [Validation(Required=false)]
            public string Pl2MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum IOPS of an ESSD of performance level 3 (PL3). Unit: operations per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("Pl3MaxIOPS")]
            [Validation(Required=false)]
            public string Pl3MaxIOPS { get; set; }

            [NameInMap("PolarStoreMaxStorageCapacity")]
            [Validation(Required=false)]
            public string PolarStoreMaxStorageCapacity { get; set; }

            /// <summary>
            /// <para>The maximum Input/output operations per second (IOPS) for PolarStore Level 4 (PSL4). Unit: operations per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48000</para>
            /// </summary>
            [NameInMap("Psl4MaxIOPS")]
            [Validation(Required=false)]
            public string Psl4MaxIOPS { get; set; }

            /// <summary>
            /// <para>The maximum IOPS for PolarStore Level 5 (PSL5). Unit: operations per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96000</para>
            /// </summary>
            [NameInMap("Psl5MaxIOPS")]
            [Validation(Required=false)]
            public string Psl5MaxIOPS { get; set; }

            /// <summary>
            /// <para>The additional price.</para>
            /// <para>Unit: cents (USD).</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If you set MasterHa to cluster or single, the value of ReferenceExtPrice is the same as the value of ReferencePrice.</description></item>
            /// <item><description>If you set MasterHa to cluster or single, the value of ReferenceExtPrice is the price of the single-node cluster.</description></item>
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
            /// <para>Unit: cents (USD).</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If you set CommodityCode to a commodity that uses the pay-as-you-go billing method, ReferencePrice indicates the hourly fee that you need to pay.</description></item>
            /// <item><description>If you set CommodityCode to a commodity that uses the subscription billing method, ReferencePrice indicates the monthly fee that you need to pay.</description></item>
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
        /// <para>The region ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69A85BAF-1089-4CDF-A82F-0A140F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
