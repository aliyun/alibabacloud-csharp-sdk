// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the zones.</para>
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
                /// <para>An internal parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsMainSale")]
                [Validation(Required=false)]
                public bool? IsMainSale { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The supported engines.</para>
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
                        /// <para>The database engine of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Redis</para>
                        /// </summary>
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        /// <summary>
                        /// <para>The instance edition types.</para>
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
                                /// <para>The edition of the instance. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>Community</b>: Community Edition</description></item>
                                /// <item><description><b>Enterprise</b>: Enhanced Edition (Tair)</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Enterprise</para>
                                /// </summary>
                                [NameInMap("EditionType")]
                                [Validation(Required=false)]
                                public string EditionType { get; set; }

                                /// <summary>
                                /// <para>The instance series types.</para>
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
                                        /// <para>The instance series. Valid values:</para>
                                        /// <list type="bullet">
                                        /// <item><description><b>enhanced_performance_type</b>: Tair (Enterprise Edition) DRAM-based instance</description></item>
                                        /// <item><description><b>hybrid_storage</b>: Redis Open-Source Edition hybrid-storage instance</description></item>
                                        /// </list>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>enhanced_performance_type</para>
                                        /// </summary>
                                        [NameInMap("SeriesType")]
                                        [Validation(Required=false)]
                                        public string SeriesType { get; set; }

                                        /// <summary>
                                        /// <para>The available engine versions.</para>
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
                                                /// <para>The available architectures.</para>
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
                                                        /// <para>The architecture of the instance. Valid values:</para>
                                                        /// <list type="bullet">
                                                        /// <item><description><b>standard</b>: standard architecture</description></item>
                                                        /// <item><description><b>cluster</b>: cluster architecture</description></item>
                                                        /// <item><description><b>rwsplit</b>: read/write splitting architecture</description></item>
                                                        /// </list>
                                                        /// 
                                                        /// <b>Example:</b>
                                                        /// <para>cluster</para>
                                                        /// </summary>
                                                        [NameInMap("Architecture")]
                                                        [Validation(Required=false)]
                                                        public string Architecture { get; set; }

                                                        /// <summary>
                                                        /// <para>The numbers of available shards.</para>
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
                                                                /// <para>The number of shards.</para>
                                                                /// 
                                                                /// <b>Example:</b>
                                                                /// <para>8</para>
                                                                /// </summary>
                                                                [NameInMap("ShardNumber")]
                                                                [Validation(Required=false)]
                                                                public string ShardNumber { get; set; }

                                                                /// <summary>
                                                                /// <para>The supported node types.</para>
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
                                                                        /// <para>The available instance types.</para>
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
                                                                                /// <para>The memory size of the instance. Unit: MB.</para>
                                                                                /// 
                                                                                /// <b>Example:</b>
                                                                                /// <para>16384</para>
                                                                                /// </summary>
                                                                                [NameInMap("Capacity")]
                                                                                [Validation(Required=false)]
                                                                                public long? Capacity { get; set; }

                                                                                /// <summary>
                                                                                /// <para>The code of the instance type. If you want to view the code of an instance type, you can search for the code of the instance type in Help Center.</para>
                                                                                /// 
                                                                                /// <b>Example:</b>
                                                                                /// <para>redis.amber.logic.sharding.2g.8db.0rodb.24proxy.multithread</para>
                                                                                /// </summary>
                                                                                [NameInMap("InstanceClass")]
                                                                                [Validation(Required=false)]
                                                                                public string InstanceClass { get; set; }

                                                                                /// <summary>
                                                                                /// <para>The description of the instance type.</para>
                                                                                /// 
                                                                                /// <b>Example:</b>
                                                                                /// <para>16 GB cluster instance with 8 nodes (1,920,000 queries per second and 240,000 connections)</para>
                                                                                /// </summary>
                                                                                [NameInMap("InstanceClassRemark")]
                                                                                [Validation(Required=false)]
                                                                                public string InstanceClassRemark { get; set; }

                                                                            }

                                                                        }

                                                                        /// <summary>
                                                                        /// <para>The node type of the instance. Valid values:</para>
                                                                        /// <list type="bullet">
                                                                        /// <item><description><b>single</b>: standalone</description></item>
                                                                        /// <item><description><b>double</b>: master-replica</description></item>
                                                                        /// </list>
                                                                        /// 
                                                                        /// <b>Example:</b>
                                                                        /// <para>double</para>
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
                                                /// <para>The engine version of the instance.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>5.0</para>
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
                /// <para>The ID of the zone in which the instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The name of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou Zone H</para>
                /// </summary>
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
