// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>344EE51D-8850-4935-B68B-58A8F4DCE3BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The supported database types.</para>
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
                /// <para>The available zones.</para>
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
                        /// <para>The ID of the region.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The supported storage engine versions.</para>
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
                                /// <para>The supported storage engines.</para>
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
                                        /// <para>The storage engine of the instance.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>WiredTiger</para>
                                        /// </summary>
                                        [NameInMap("Engine")]
                                        [Validation(Required=false)]
                                        public string Engine { get; set; }

                                        /// <summary>
                                        /// <para>The supported instance types.</para>
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
                                                /// <para>The details of the available resources.</para>
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
                                                        /// <para>The storage capacity range of the instance.</para>
                                                        /// </summary>
                                                        [NameInMap("DBInstanceStorageRange")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResourceDBInstanceStorageRange : TeaModel {
                                                            /// <summary>
                                                            /// <para>The maximum storage capacity. Unit: GB.</para>
                                                            /// 
                                                            /// <b>Example:</b>
                                                            /// <para>16000</para>
                                                            /// </summary>
                                                            [NameInMap("Max")]
                                                            [Validation(Required=false)]
                                                            public int? Max { get; set; }

                                                            /// <summary>
                                                            /// <para>The minimum storage capacity. Unit: GB.</para>
                                                            /// 
                                                            /// <b>Example:</b>
                                                            /// <para>20</para>
                                                            /// </summary>
                                                            [NameInMap("Min")]
                                                            [Validation(Required=false)]
                                                            public int? Min { get; set; }

                                                            /// <summary>
                                                            /// <para>The step size for adjusting the storage capacity. Unit: GB.</para>
                                                            /// 
                                                            /// <b>Example:</b>
                                                            /// <para>10</para>
                                                            /// </summary>
                                                            [NameInMap("Step")]
                                                            [Validation(Required=false)]
                                                            public int? Step { get; set; }

                                                        }

                                                        /// <summary>
                                                        /// <para>The instance family.</para>
                                                        /// 
                                                        /// <b>Example:</b>
                                                        /// <para>mdb.shard.2x.xlarge.d</para>
                                                        /// </summary>
                                                        [NameInMap("InstanceClass")]
                                                        [Validation(Required=false)]
                                                        public string InstanceClass { get; set; }

                                                        /// <summary>
                                                        /// <para>The type of the instance.</para>
                                                        /// 
                                                        /// <b>Example:</b>
                                                        /// <para>4 cores, 8 GB (Dedicated) (Current instance type: mdb.shard.2x.xlarge.d (4 cores, 8 GB (Dedicated cloud-disk), maximum connections: 3000, maximum IOPS: min{1800 + 50 × Storage capacity, 21000}))</para>
                                                        /// </summary>
                                                        [NameInMap("InstanceClassRemark")]
                                                        [Validation(Required=false)]
                                                        public string InstanceClassRemark { get; set; }

                                                    }

                                                }

                                                /// <summary>
                                                /// <para>The network type of the instance.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>VPC</para>
                                                /// </summary>
                                                [NameInMap("NetworkTypes")]
                                                [Validation(Required=false)]
                                                public string NetworkTypes { get; set; }

                                                /// <summary>
                                                /// <para>The number of nodes in the instance.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>3</para>
                                                /// </summary>
                                                [NameInMap("NodeType")]
                                                [Validation(Required=false)]
                                                public string NodeType { get; set; }

                                            }

                                        }

                                    }

                                }

                                /// <summary>
                                /// <para>The database engine version of the instance.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>4.0</para>
                                /// </summary>
                                [NameInMap("Version")]
                                [Validation(Required=false)]
                                public string Version { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The ID of the zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-h</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The architecture of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: replica set instance</description></item>
                /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sharding</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

            }

        }

    }

}
