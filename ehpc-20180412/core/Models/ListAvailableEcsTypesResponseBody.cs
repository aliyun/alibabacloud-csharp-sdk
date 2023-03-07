// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListAvailableEcsTypesResponseBody : TeaModel {
        /// <summary>
        /// The instance family to which the instance type belongs.
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public ListAvailableEcsTypesResponseBodyInstanceTypeFamilies InstanceTypeFamilies { get; set; }
        public class ListAvailableEcsTypesResponseBodyInstanceTypeFamilies : TeaModel {
            [NameInMap("InstanceTypeFamilyInfo")]
            [Validation(Required=false)]
            public List<ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfo> InstanceTypeFamilyInfo { get; set; }
            public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfo : TeaModel {
                /// <summary>
                /// The instance family.
                /// </summary>
                [NameInMap("Generation")]
                [Validation(Required=false)]
                public string Generation { get; set; }

                /// <summary>
                /// The ID of the instance family. For more information, see [Instance families](~~25378~~).
                /// </summary>
                [NameInMap("InstanceTypeFamilyId")]
                [Validation(Required=false)]
                public string InstanceTypeFamilyId { get; set; }

                /// <summary>
                /// The list of instance types.
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypes Types { get; set; }
                public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypes : TeaModel {
                    [NameInMap("TypesInfo")]
                    [Validation(Required=false)]
                    public List<ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfo> TypesInfo { get; set; }
                    public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfo : TeaModel {
                        /// <summary>
                        /// The number of vCPUs.
                        /// </summary>
                        [NameInMap("CpuCoreCount")]
                        [Validation(Required=false)]
                        public int? CpuCoreCount { get; set; }

                        /// <summary>
                        /// The maximum number of elastic network interfaces (ENIs) that can be bound to an ECS instance.
                        /// </summary>
                        [NameInMap("EniQuantity")]
                        [Validation(Required=false)]
                        public int? EniQuantity { get; set; }

                        /// <summary>
                        /// The number of GPUs of an ECS instance.
                        /// </summary>
                        [NameInMap("GPUAmount")]
                        [Validation(Required=false)]
                        public int? GPUAmount { get; set; }

                        /// <summary>
                        /// The GPU type of the ECS instance.
                        /// </summary>
                        [NameInMap("GPUSpec")]
                        [Validation(Required=false)]
                        public string GPUSpec { get; set; }

                        /// <summary>
                        /// The maximum inbound internal bandwidth. Unit: Kbit/s.
                        /// </summary>
                        [NameInMap("InstanceBandwidthRx")]
                        [Validation(Required=false)]
                        public int? InstanceBandwidthRx { get; set; }

                        /// <summary>
                        /// The maximum outbound internal bandwidth. Unit: Kbit/s.
                        /// </summary>
                        [NameInMap("InstanceBandwidthTx")]
                        [Validation(Required=false)]
                        public int? InstanceBandwidthTx { get; set; }

                        /// <summary>
                        /// The inbound packet forwarding rate over the internal network. Unit: pps
                        /// </summary>
                        [NameInMap("InstancePpsRx")]
                        [Validation(Required=false)]
                        public int? InstancePpsRx { get; set; }

                        /// <summary>
                        /// The outbound packet forwarding rate over the internal network. Unit: pps
                        /// </summary>
                        [NameInMap("InstancePpsTx")]
                        [Validation(Required=false)]
                        public int? InstancePpsTx { get; set; }

                        /// <summary>
                        /// The ID of the ECS instance type.
                        /// </summary>
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public string InstanceTypeId { get; set; }

                        /// <summary>
                        /// The memory size of the ECS instance. Unit: GiB
                        /// </summary>
                        [NameInMap("MemorySize")]
                        [Validation(Required=false)]
                        public int? MemorySize { get; set; }

                        /// <summary>
                        /// The status of the ECS instance. Valid values:
                        /// 
                        /// *   SoldOut
                        /// *   Available
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The list of zone IDs.
                        /// </summary>
                        [NameInMap("ZoneIds")]
                        [Validation(Required=false)]
                        public ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfoZoneIds ZoneIds { get; set; }
                        public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfoZoneIds : TeaModel {
                            [NameInMap("ZoneId")]
                            [Validation(Required=false)]
                            public List<string> ZoneId { get; set; }

                        }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Specifies whether preemptible instances are supported. Valid values:
        /// 
        /// *   false: not supported
        /// *   true: supported
        /// </summary>
        [NameInMap("SupportSpotInstance")]
        [Validation(Required=false)]
        public bool? SupportSpotInstance { get; set; }

    }

}
