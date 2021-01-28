// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                [NameInMap("SupportedEngine")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngine> SupportedEngine { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngine : TeaModel {
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    [NameInMap("SupportedEditionTypes")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypes SupportedEditionTypes { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypes : TeaModel {
                        [NameInMap("SupportedEditionType")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionType> SupportedEditionType { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionType : TeaModel {
                            [NameInMap("SupportedSeriesType")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesType> SupportedSeriesType { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesType : TeaModel {
                                [NameInMap("SupportedEngineVersions")]
                                [Validation(Required=false)]
                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersions SupportedEngineVersions { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersions : TeaModel {
                                    [NameInMap("SupportedEngineVersion")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                        [NameInMap("SupportedArchitectureType")]
                                        [Validation(Required=false)]
                                        public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureType> SupportedArchitectureType { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureType : TeaModel {
                                            [NameInMap("SupportedShardNumbers")]
                                            [Validation(Required=false)]
                                            public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbers SupportedShardNumbers { get; set; }
                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbers : TeaModel {
                                                [NameInMap("SupportedShardNumber")]
                                                [Validation(Required=false)]
                                                public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumber> SupportedShardNumber { get; set; }
                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumber : TeaModel {
                                                    [NameInMap("SupportedNodeType")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeType> SupportedNodeType { get; set; }
                                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeType : TeaModel {
                                                        [NameInMap("SupportedNodeType")]
                                                        [Validation(Required=false)]
                                                        public string SupportedNodeType { get; set; }

                                                        [NameInMap("AvailableResources")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypeAvailableResources AvailableResources { get; set; }
                                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypeAvailableResources : TeaModel {
                                                            [NameInMap("AvailableResource")]
                                                            [Validation(Required=false)]
                                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypeAvailableResourcesAvailableResource> AvailableResource { get; set; }
                                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypeAvailableResourcesAvailableResource : TeaModel {
                                                                public string InstanceClassRemark { get; set; }
                                                                public string InstanceClass { get; set; }
                                                            }
                                                        };

                                                    }

                                                }
                                            };

                                            [NameInMap("Architecture")]
                                            [Validation(Required=false)]
                                            public string Architecture { get; set; }

                                        }

                                    }
                                };

                                [NameInMap("SeriesType")]
                                [Validation(Required=false)]
                                public string SeriesType { get; set; }

                            }

                        }
                    };

                }

            }
        };

    }

}
