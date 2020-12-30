// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListEmrAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("EmrZoneInfoList")]
        [Validation(Required=false)]
        public ListEmrAvailableResourceResponseBodyEmrZoneInfoList EmrZoneInfoList { get; set; }
        public class ListEmrAvailableResourceResponseBodyEmrZoneInfoList : TeaModel {
            [NameInMap("EmrZoneInfo")]
            [Validation(Required=false)]
            public List<ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfo> EmrZoneInfo { get; set; }
            public class ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfo : TeaModel {
                public string ZoneId { get; set; }
                public ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoList EmrResourceInfoList { get; set; }
                public class ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoList : TeaModel {
                    [NameInMap("EmrResourceInfo")]
                    [Validation(Required=false)]
                    public List<ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfo> EmrResourceInfo { get; set; }
                    public class ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfo : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("SupportedResourceList")]
                        [Validation(Required=false)]
                        public ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceList SupportedResourceList { get; set; }
                        public class ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceList : TeaModel {
                            [NameInMap("SupportedResource")]
                            [Validation(Required=false)]
                            public List<ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceListSupportedResource> SupportedResource { get; set; }
                            public class ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceListSupportedResource : TeaModel {
                                public string Value { get; set; }
                                public int? Max { get; set; }
                                public string Unit { get; set; }
                                public ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceListSupportedResourceEmrInstanceType EmrInstanceType { get; set; }
                                public class ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceListSupportedResourceEmrInstanceType : TeaModel {
                                    [NameInMap("InstanceBandwidthRx")]
                                    [Validation(Required=false)]
                                    public int? InstanceBandwidthRx { get; set; }

                                    [NameInMap("GPUSpec")]
                                    [Validation(Required=false)]
                                    public string GPUSpec { get; set; }

                                    [NameInMap("LocalStorageCategory")]
                                    [Validation(Required=false)]
                                    public string LocalStorageCategory { get; set; }

                                    [NameInMap("InstanceBandwidthTx")]
                                    [Validation(Required=false)]
                                    public int? InstanceBandwidthTx { get; set; }

                                    [NameInMap("GPUAmount")]
                                    [Validation(Required=false)]
                                    public int? GPUAmount { get; set; }

                                    [NameInMap("InstanceType")]
                                    [Validation(Required=false)]
                                    public string InstanceType { get; set; }

                                    [NameInMap("MemorySize")]
                                    [Validation(Required=false)]
                                    public int? MemorySize { get; set; }

                                    [NameInMap("InitialCredit")]
                                    [Validation(Required=false)]
                                    public int? InitialCredit { get; set; }

                                    [NameInMap("LocalStorageCapacity")]
                                    [Validation(Required=false)]
                                    public long? LocalStorageCapacity { get; set; }

                                    [NameInMap("LocalStorageAmount")]
                                    [Validation(Required=false)]
                                    public int? LocalStorageAmount { get; set; }

                                    [NameInMap("InstancePpsRx")]
                                    [Validation(Required=false)]
                                    public long? InstancePpsRx { get; set; }

                                    [NameInMap("BaselineCredit")]
                                    [Validation(Required=false)]
                                    public int? BaselineCredit { get; set; }

                                    [NameInMap("InstancePpsTx")]
                                    [Validation(Required=false)]
                                    public long? InstancePpsTx { get; set; }

                                    [NameInMap("CpuCoreCount")]
                                    [Validation(Required=false)]
                                    public int? CpuCoreCount { get; set; }

                                    [NameInMap("InstanceTypeFamily")]
                                    [Validation(Required=false)]
                                    public string InstanceTypeFamily { get; set; }

                                    [NameInMap("EniQuantity")]
                                    [Validation(Required=false)]
                                    public int? EniQuantity { get; set; }

                                }
                                public int? Min { get; set; }
                                public ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceListSupportedResourceSupportNodeTypeList SupportNodeTypeList { get; set; }
                                public class ListEmrAvailableResourceResponseBodyEmrZoneInfoListEmrZoneInfoEmrResourceInfoListEmrResourceInfoSupportedResourceListSupportedResourceSupportNodeTypeList : TeaModel {
                                    [NameInMap("SupportNodeType")]
                                    [Validation(Required=false)]
                                    public List<string> SupportNodeType { get; set; }

                                }
                            }
                        };

                    }

                }
            }
        };

    }

}
