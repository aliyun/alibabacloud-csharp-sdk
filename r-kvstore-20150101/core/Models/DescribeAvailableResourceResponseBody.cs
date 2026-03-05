// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                [NameInMap("IsMainSale")]
                [Validation(Required=false)]
                public bool? IsMainSale { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SupportedEngines")]
                [Validation(Required=false)]
                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines SupportedEngines { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines : TeaModel {
                    [NameInMap("SupportedEngine")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine> SupportedEngine { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine : TeaModel {
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        [NameInMap("SupportedEditionTypes")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypes SupportedEditionTypes { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypes : TeaModel {
                            [NameInMap("SupportedEditionType")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionType> SupportedEditionType { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionType : TeaModel {
                                [NameInMap("EditionType")]
                                [Validation(Required=false)]
                                public string EditionType { get; set; }

                                [NameInMap("SupportedSeriesTypes")]
                                [Validation(Required=false)]
                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypes SupportedSeriesTypes { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypes : TeaModel {
                                    [NameInMap("SupportedSeriesType")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesType> SupportedSeriesType { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesType : TeaModel {
                                        [NameInMap("SeriesType")]
                                        [Validation(Required=false)]
                                        public string SeriesType { get; set; }

                                        [NameInMap("SupportedEngineVersions")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersions SupportedEngineVersions { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersions : TeaModel {
                                            [NameInMap("SupportedEngineVersion")]
                                            [Validation(Required=false)]
                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                                [NameInMap("SupportedArchitectureTypes")]
                                                [Validation(Required=false)]
                                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypes SupportedArchitectureTypes { get; set; }
                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypes : TeaModel {
                                                    [NameInMap("SupportedArchitectureType")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureType> SupportedArchitectureType { get; set; }
                                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureType : TeaModel {
                                                        [NameInMap("Architecture")]
                                                        [Validation(Required=false)]
                                                        public string Architecture { get; set; }

                                                        [NameInMap("SupportedShardNumbers")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbers SupportedShardNumbers { get; set; }
                                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbers : TeaModel {
                                                            [NameInMap("SupportedShardNumber")]
                                                            [Validation(Required=false)]
                                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumber> SupportedShardNumber { get; set; }
                                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumber : TeaModel {
                                                                [NameInMap("ShardNumber")]
                                                                [Validation(Required=false)]
                                                                public string ShardNumber { get; set; }

                                                                [NameInMap("SupportedNodeTypes")]
                                                                [Validation(Required=false)]
                                                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypes SupportedNodeTypes { get; set; }
                                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypes : TeaModel {
                                                                    [NameInMap("SupportedNodeType")]
                                                                    [Validation(Required=false)]
                                                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeType> SupportedNodeType { get; set; }
                                                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeType : TeaModel {
                                                                        [NameInMap("AvailableResources")]
                                                                        [Validation(Required=false)]
                                                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResources AvailableResources { get; set; }
                                                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResources : TeaModel {
                                                                            [NameInMap("AvailableResource")]
                                                                            [Validation(Required=false)]
                                                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource> AvailableResource { get; set; }
                                                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource : TeaModel {
                                                                                [NameInMap("Capacity")]
                                                                                [Validation(Required=false)]
                                                                                public long? Capacity { get; set; }

                                                                                [NameInMap("InstanceClass")]
                                                                                [Validation(Required=false)]
                                                                                public string InstanceClass { get; set; }

                                                                                [NameInMap("InstanceClassRemark")]
                                                                                [Validation(Required=false)]
                                                                                public string InstanceClassRemark { get; set; }

                                                                            }

                                                                        }

                                                                        [NameInMap("SupportedNodeType")]
                                                                        [Validation(Required=false)]
                                                                        public string SupportedNodeType { get; set; }

                                                                    }

                                                                }

                                                            }

                                                        }

                                                    }

                                                }

                                                [NameInMap("Version")]
                                                [Validation(Required=false)]
                                                public string Version { get; set; }

                                            }

                                        }

                                    }

                                }

                            }

                        }

                    }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>493B7308-D9C2-55F6-B042-0313BD63****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
