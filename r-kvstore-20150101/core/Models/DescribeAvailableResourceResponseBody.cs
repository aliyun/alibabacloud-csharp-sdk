// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// Details of the zones.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The available database engines.
                /// </summary>
                [NameInMap("SupportedEngines")]
                [Validation(Required=false)]
                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines SupportedEngines { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines : TeaModel {
                    [NameInMap("SupportedEngine")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine> SupportedEngine { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine : TeaModel {
                        /// <summary>
                        /// The database engine of the instance.
                        /// </summary>
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        /// <summary>
                        /// The available instance editions.
                        /// </summary>
                        [NameInMap("SupportedEditionTypes")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypes SupportedEditionTypes { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypes : TeaModel {
                            [NameInMap("SupportedEditionType")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionType> SupportedEditionType { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionType : TeaModel {
                                /// <summary>
                                /// The edition of the instance. Valid values:
                                /// 
                                /// *   **Community**: Community Edition
                                /// *   **Enterprise**: Enhanced Edition (Tair)
                                /// </summary>
                                [NameInMap("EditionType")]
                                [Validation(Required=false)]
                                public string EditionType { get; set; }

                                /// <summary>
                                /// The available instance series.
                                /// </summary>
                                [NameInMap("SupportedSeriesTypes")]
                                [Validation(Required=false)]
                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypes SupportedSeriesTypes { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypes : TeaModel {
                                    [NameInMap("SupportedSeriesType")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesType> SupportedSeriesType { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesType : TeaModel {
                                        /// <summary>
                                        /// The instance series. Valid values:
                                        /// 
                                        /// *   **enhanced_performance_type**: ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance
                                        /// *   **hybrid_storage**: ApsaraDB for Redis Community Edition hybrid-storage instance
                                        /// </summary>
                                        [NameInMap("SeriesType")]
                                        [Validation(Required=false)]
                                        public string SeriesType { get; set; }

                                        /// <summary>
                                        /// The available engine versions.
                                        /// </summary>
                                        [NameInMap("SupportedEngineVersions")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersions SupportedEngineVersions { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersions : TeaModel {
                                            [NameInMap("SupportedEngineVersion")]
                                            [Validation(Required=false)]
                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                                /// <summary>
                                                /// The available instance architectures.
                                                /// </summary>
                                                [NameInMap("SupportedArchitectureTypes")]
                                                [Validation(Required=false)]
                                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypes SupportedArchitectureTypes { get; set; }
                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypes : TeaModel {
                                                    [NameInMap("SupportedArchitectureType")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureType> SupportedArchitectureType { get; set; }
                                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureType : TeaModel {
                                                        /// <summary>
                                                        /// The architecture of the instance. Valid values:
                                                        /// 
                                                        /// *   **standard**: standard architecture
                                                        /// *   **cluster**: cluster architecture
                                                        /// *   **rwsplit**: read/write splitting architecture
                                                        /// </summary>
                                                        [NameInMap("Architecture")]
                                                        [Validation(Required=false)]
                                                        public string Architecture { get; set; }

                                                        /// <summary>
                                                        /// The numbers of shards that are allowed.
                                                        /// </summary>
                                                        [NameInMap("SupportedShardNumbers")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbers SupportedShardNumbers { get; set; }
                                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbers : TeaModel {
                                                            [NameInMap("SupportedShardNumber")]
                                                            [Validation(Required=false)]
                                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumber> SupportedShardNumber { get; set; }
                                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumber : TeaModel {
                                                                /// <summary>
                                                                /// The number of shards.
                                                                /// </summary>
                                                                [NameInMap("ShardNumber")]
                                                                [Validation(Required=false)]
                                                                public string ShardNumber { get; set; }

                                                                /// <summary>
                                                                /// The available node types.
                                                                /// </summary>
                                                                [NameInMap("SupportedNodeTypes")]
                                                                [Validation(Required=false)]
                                                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypes SupportedNodeTypes { get; set; }
                                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypes : TeaModel {
                                                                    [NameInMap("SupportedNodeType")]
                                                                    [Validation(Required=false)]
                                                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeType> SupportedNodeType { get; set; }
                                                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeType : TeaModel {
                                                                        /// <summary>
                                                                        /// The available instance types.
                                                                        /// </summary>
                                                                        [NameInMap("AvailableResources")]
                                                                        [Validation(Required=false)]
                                                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResources AvailableResources { get; set; }
                                                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResources : TeaModel {
                                                                            [NameInMap("AvailableResource")]
                                                                            [Validation(Required=false)]
                                                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource> AvailableResource { get; set; }
                                                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEditionTypesSupportedEditionTypeSupportedSeriesTypesSupportedSeriesTypeSupportedEngineVersionsSupportedEngineVersionSupportedArchitectureTypesSupportedArchitectureTypeSupportedShardNumbersSupportedShardNumberSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource : TeaModel {
                                                                                /// <summary>
                                                                                /// The memory size of the instance. Unit: MB.
                                                                                /// </summary>
                                                                                [NameInMap("Capacity")]
                                                                                [Validation(Required=false)]
                                                                                public long? Capacity { get; set; }

                                                                                /// <summary>
                                                                                /// The code of the instance type. If you want to view the code of an instance type, you can search for the code of the instance type in Help Center.
                                                                                /// </summary>
                                                                                [NameInMap("InstanceClass")]
                                                                                [Validation(Required=false)]
                                                                                public string InstanceClass { get; set; }

                                                                                /// <summary>
                                                                                /// The description of the instance type.
                                                                                /// </summary>
                                                                                [NameInMap("InstanceClassRemark")]
                                                                                [Validation(Required=false)]
                                                                                public string InstanceClassRemark { get; set; }

                                                                            }

                                                                        }

                                                                        /// <summary>
                                                                        /// The node type of the instance. Valid values:
                                                                        /// 
                                                                        /// *   **single**: standalone
                                                                        /// *   **double**: master-replica
                                                                        /// </summary>
                                                                        [NameInMap("SupportedNodeType")]
                                                                        [Validation(Required=false)]
                                                                        public string SupportedNodeType { get; set; }

                                                                    }

                                                                }

                                                            }

                                                        }

                                                    }

                                                }

                                                /// <summary>
                                                /// The engine version of the instance.
                                                /// </summary>
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

                /// <summary>
                /// The ID of the zone in which the instance is located.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The name of the zone.
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
