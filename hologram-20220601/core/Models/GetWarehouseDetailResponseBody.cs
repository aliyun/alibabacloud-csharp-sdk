// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetWarehouseDetailResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The values returned.
        /// </summary>
        [NameInMap("WarehouseDetail")]
        [Validation(Required=false)]
        public GetWarehouseDetailResponseBodyWarehouseDetail WarehouseDetail { get; set; }
        public class GetWarehouseDetailResponseBodyWarehouseDetail : TeaModel {
            /// <summary>
            /// The remaining unallocated computing resources of the virtual warehouse instance.
            /// </summary>
            [NameInMap("RemainingCpu")]
            [Validation(Required=false)]
            public string RemainingCpu { get; set; }

            /// <summary>
            /// The reserved computing resources. The amount of computing resources in all running virtual warehouses in an instance cannot exceed the amount of reserved computing resources in the virtual warehouses.
            /// </summary>
            [NameInMap("ReservedCpu")]
            [Validation(Required=false)]
            public string ReservedCpu { get; set; }

            [NameInMap("TimedElasticCpu")]
            [Validation(Required=false)]
            public string TimedElasticCpu { get; set; }

            /// <summary>
            /// The list of virtual warehouses.
            /// </summary>
            [NameInMap("WarehouseList")]
            [Validation(Required=false)]
            public List<GetWarehouseDetailResponseBodyWarehouseDetailWarehouseList> WarehouseList { get; set; }
            public class GetWarehouseDetailResponseBodyWarehouseDetailWarehouseList : TeaModel {
                /// <summary>
                /// The number of CPU cores.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                [NameInMap("DefaultWarehouse")]
                [Validation(Required=false)]
                public bool? DefaultWarehouse { get; set; }

                [NameInMap("ElasticCpu")]
                [Validation(Required=false)]
                public long? ElasticCpu { get; set; }

                /// <summary>
                /// The ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The memory capacity.
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public long? Mem { get; set; }

                /// <summary>
                /// The name of the virtual warehouse instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of compute nodes.
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public long? NodeCount { get; set; }

                [NameInMap("RebalanceStatus")]
                [Validation(Required=false)]
                public string RebalanceStatus { get; set; }

                /// <summary>
                /// The status.
                /// 
                /// Valid values:
                /// 
                /// *   kRunning
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   kSuspended
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   kInit
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   kFailed
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   kAllocating
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
