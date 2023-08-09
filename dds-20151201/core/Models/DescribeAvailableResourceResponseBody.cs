// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The supported database types.
        /// </summary>
        [NameInMap("SupportedDBTypes")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodySupportedDBTypes SupportedDBTypes { get; set; }
        public class DescribeAvailableResourceResponseBodySupportedDBTypes : TeaModel {
            [NameInMap("SupportedDBType")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBType> SupportedDBType { get; set; }
            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBType : TeaModel {
                /// <summary>
                /// The available zones.
                /// </summary>
                [NameInMap("AvailableZones")]
                [Validation(Required=false)]
                public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZones AvailableZones { get; set; }
                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZones : TeaModel {
                    [NameInMap("AvailableZone")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZone> AvailableZone { get; set; }
                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZone : TeaModel {
                        /// <summary>
                        /// The ID of the region.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The supported storage engine versions.
                        /// </summary>
                        [NameInMap("SupportedEngineVersions")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersions SupportedEngineVersions { get; set; }
                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersions : TeaModel {
                            [NameInMap("SupportedEngineVersion")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                /// <summary>
                                /// The supported storage engines.
                                /// </summary>
                                [NameInMap("SupportedEngines")]
                                [Validation(Required=false)]
                                public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngines SupportedEngines { get; set; }
                                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngines : TeaModel {
                                    [NameInMap("SupportedEngine")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngine> SupportedEngine { get; set; }
                                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngine : TeaModel {
                                        /// <summary>
                                        /// The storage engine of the instance.
                                        /// </summary>
                                        [NameInMap("Engine")]
                                        [Validation(Required=false)]
                                        public string Engine { get; set; }

                                        /// <summary>
                                        /// The supported instance types.
                                        /// </summary>
                                        [NameInMap("SupportedNodeTypes")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypes SupportedNodeTypes { get; set; }
                                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypes : TeaModel {
                                            [NameInMap("SupportedNodeType")]
                                            [Validation(Required=false)]
                                            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeType> SupportedNodeType { get; set; }
                                            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeType : TeaModel {
                                                /// <summary>
                                                /// The details of the available resources.
                                                /// </summary>
                                                [NameInMap("AvailableResources")]
                                                [Validation(Required=false)]
                                                public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResources AvailableResources { get; set; }
                                                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResources : TeaModel {
                                                    [NameInMap("AvailableResource")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource> AvailableResource { get; set; }
                                                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource : TeaModel {
                                                        /// <summary>
                                                        /// The storage capacity range of the instance.
                                                        /// </summary>
                                                        [NameInMap("DBInstanceStorageRange")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResourceDBInstanceStorageRange : TeaModel {
                                                            /// <summary>
                                                            /// The maximum storage capacity. Unit: GB.
                                                            /// </summary>
                                                            [NameInMap("Max")]
                                                            [Validation(Required=false)]
                                                            public int? Max { get; set; }

                                                            /// <summary>
                                                            /// The minimum storage capacity. Unit: GB.
                                                            /// </summary>
                                                            [NameInMap("Min")]
                                                            [Validation(Required=false)]
                                                            public int? Min { get; set; }

                                                            /// <summary>
                                                            /// The step size for adjusting the storage capacity. Unit: GB.
                                                            /// </summary>
                                                            [NameInMap("Step")]
                                                            [Validation(Required=false)]
                                                            public int? Step { get; set; }

                                                        }

                                                        /// <summary>
                                                        /// The instance family.
                                                        /// </summary>
                                                        [NameInMap("InstanceClass")]
                                                        [Validation(Required=false)]
                                                        public string InstanceClass { get; set; }

                                                        /// <summary>
                                                        /// The type of the instance.
                                                        /// </summary>
                                                        [NameInMap("InstanceClassRemark")]
                                                        [Validation(Required=false)]
                                                        public string InstanceClassRemark { get; set; }

                                                    }

                                                }

                                                /// <summary>
                                                /// The network type of the instance.
                                                /// </summary>
                                                [NameInMap("NetworkTypes")]
                                                [Validation(Required=false)]
                                                public string NetworkTypes { get; set; }

                                                /// <summary>
                                                /// The number of nodes in the instance.
                                                /// </summary>
                                                [NameInMap("NodeType")]
                                                [Validation(Required=false)]
                                                public string NodeType { get; set; }

                                            }

                                        }

                                    }

                                }

                                /// <summary>
                                /// The database engine version of the instance.
                                /// </summary>
                                [NameInMap("Version")]
                                [Validation(Required=false)]
                                public string Version { get; set; }

                            }

                        }

                        /// <summary>
                        /// The ID of the zone.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// The architecture of the instance. Valid values:
                /// 
                /// *   **normal**: replica set instance
                /// *   **sharding**: sharded cluster instance
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

            }

        }

    }

}
