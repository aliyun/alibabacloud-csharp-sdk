// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeClassListResponseBody : TeaModel {
        /// <summary>
        /// The specifications of the cluster.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeClassListResponseBodyItems> Items { get; set; }
        public class DescribeClassListResponseBodyItems : TeaModel {
            /// <summary>
            /// The specifications of the cluster.
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// The instance family of the cluster. Valid values:
            /// 
            /// *   Exclusive package: dedicated
            /// *   Exclusive physical machine: dedicated host
            /// *   Beginner: starter
            /// *   Historical specifications: historical
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// The specification type of the cluster.
            /// </summary>
            [NameInMap("ClassTypeLevel")]
            [Validation(Required=false)]
            public string ClassTypeLevel { get; set; }

            /// <summary>
            /// The number of vCPU cores. Unit: cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections in the cluster.
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public string MaxConnections { get; set; }

            /// <summary>
            /// The maximum IOPS. Unit: operations per second.
            /// </summary>
            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public string MaxIOPS { get; set; }

            /// <summary>
            /// The maximum storage capacity. Unit: TB.
            /// </summary>
            [NameInMap("MaxStorageCapacity")]
            [Validation(Required=false)]
            public string MaxStorageCapacity { get; set; }

            /// <summary>
            /// The memory size. Unit: GB.
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// The maximum IOPS of an enhanced SSD (ESSD) of performance level 1 (PL1). Unit: operations per second.
            /// </summary>
            [NameInMap("Pl1MaxIOPS")]
            [Validation(Required=false)]
            public string Pl1MaxIOPS { get; set; }

            /// <summary>
            /// The maximum IOPS of an ESSD of performance level 2 (PL2). Unit: operations per second.
            /// </summary>
            [NameInMap("Pl2MaxIOPS")]
            [Validation(Required=false)]
            public string Pl2MaxIOPS { get; set; }

            /// <summary>
            /// The maximum IOPS of an ESSD of performance level 3 (PL3). Unit: operations per second.
            /// </summary>
            [NameInMap("Pl3MaxIOPS")]
            [Validation(Required=false)]
            public string Pl3MaxIOPS { get; set; }

            /// <summary>
            /// The maximum Input/output operations per second (IOPS) for PolarStore Level 4 (PSL4). Unit: operations per second.
            /// </summary>
            [NameInMap("Psl4MaxIOPS")]
            [Validation(Required=false)]
            public string Psl4MaxIOPS { get; set; }

            /// <summary>
            /// The maximum IOPS for PolarStore Level 5 (PSL5). Unit: operations per second.
            /// </summary>
            [NameInMap("Psl5MaxIOPS")]
            [Validation(Required=false)]
            public string Psl5MaxIOPS { get; set; }

            /// <summary>
            /// The additional price.
            /// 
            /// Unit: cents (USD).
            /// 
            /// >- If you set MasterHa to cluster or single, the value of ReferenceExtPrice is the same as the value of ReferencePrice.
            /// >- If you set MasterHa to cluster or single, the value of ReferenceExtPrice is the price of the single-node cluster.
            /// </summary>
            [NameInMap("ReferenceExtPrice")]
            [Validation(Required=false)]
            public string ReferenceExtPrice { get; set; }

            /// <summary>
            /// The price.
            /// 
            /// Unit: cents (USD).
            /// 
            /// >- If you set CommodityCode to a commodity that uses the pay-as-you-go billing method, ReferencePrice indicates the hourly fee that you need to pay.
            /// >- If you set CommodityCode to a commodity that uses the subscription billing method, ReferencePrice indicates the monthly fee that you need to pay.
            /// </summary>
            [NameInMap("ReferencePrice")]
            [Validation(Required=false)]
            public string ReferencePrice { get; set; }

        }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
