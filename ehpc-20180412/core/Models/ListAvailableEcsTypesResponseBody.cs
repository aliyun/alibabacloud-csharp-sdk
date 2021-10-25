// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListAvailableEcsTypesResponseBody : TeaModel {
        [NameInMap("SupportSpotInstance")]
        [Validation(Required=false)]
        public bool? SupportSpotInstance { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public ListAvailableEcsTypesResponseBodyInstanceTypeFamilies InstanceTypeFamilies { get; set; }
        public class ListAvailableEcsTypesResponseBodyInstanceTypeFamilies : TeaModel {
            [NameInMap("InstanceTypeFamilyInfo")]
            [Validation(Required=false)]
            public List<ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfo> InstanceTypeFamilyInfo { get; set; }
            public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfo : TeaModel {
                public string Generation { get; set; }
                public string InstanceTypeFamilyId { get; set; }
                public ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypes Types { get; set; }
                public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypes : TeaModel {
                    [NameInMap("TypesInfo")]
                    [Validation(Required=false)]
                    public List<ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfo> TypesInfo { get; set; }
                    public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfo : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public string InstanceTypeId { get; set; }

                        [NameInMap("InstanceBandwidthRx")]
                        [Validation(Required=false)]
                        public int? InstanceBandwidthRx { get; set; }

                        [NameInMap("GPUSpec")]
                        [Validation(Required=false)]
                        public string GPUSpec { get; set; }

                        [NameInMap("InstanceBandwidthTx")]
                        [Validation(Required=false)]
                        public int? InstanceBandwidthTx { get; set; }

                        [NameInMap("InstancePpsRx")]
                        [Validation(Required=false)]
                        public int? InstancePpsRx { get; set; }

                        [NameInMap("InstancePpsTx")]
                        [Validation(Required=false)]
                        public int? InstancePpsTx { get; set; }

                        [NameInMap("GPUAmount")]
                        [Validation(Required=false)]
                        public int? GPUAmount { get; set; }

                        [NameInMap("CpuCoreCount")]
                        [Validation(Required=false)]
                        public int? CpuCoreCount { get; set; }

                        [NameInMap("MemorySize")]
                        [Validation(Required=false)]
                        public int? MemorySize { get; set; }

                        [NameInMap("EniQuantity")]
                        [Validation(Required=false)]
                        public int? EniQuantity { get; set; }

                        [NameInMap("ZoneIds")]
                        [Validation(Required=false)]
                        public ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfoZoneIds ZoneIds { get; set; }
                        public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfoZoneIds : TeaModel {
                            [NameInMap("ZoneId")]
                            [Validation(Required=false)]
                            public List<string> ZoneId { get; set; }
                        };

                    }

                }
            }
        };

    }

}
