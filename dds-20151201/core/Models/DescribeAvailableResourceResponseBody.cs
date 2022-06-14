// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportedDBTypes")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodySupportedDBTypes SupportedDBTypes { get; set; }
        public class DescribeAvailableResourceResponseBodySupportedDBTypes : TeaModel {
            [NameInMap("SupportedDBType")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBType> SupportedDBType { get; set; }
            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBType : TeaModel {
                public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZones AvailableZones { get; set; }
                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZones : TeaModel {
                    [NameInMap("AvailableZone")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZone> AvailableZone { get; set; }
                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZone : TeaModel {
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("SupportedEngineVersions")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersions SupportedEngineVersions { get; set; }
                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersions : TeaModel {
                            [NameInMap("SupportedEngineVersion")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngines SupportedEngines { get; set; }
                                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngines : TeaModel {
                                    [NameInMap("SupportedEngine")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngine> SupportedEngine { get; set; }
                                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngine : TeaModel {
                                        [NameInMap("Engine")]
                                        [Validation(Required=false)]
                                        public string Engine { get; set; }

                                        [NameInMap("SupportedNodeTypes")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypes SupportedNodeTypes { get; set; }
                                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypes : TeaModel {
                                            [NameInMap("SupportedNodeType")]
                                            [Validation(Required=false)]
                                            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeType> SupportedNodeType { get; set; }
                                            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeType : TeaModel {
                                                public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResources AvailableResources { get; set; }
                                                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResources : TeaModel {
                                                    [NameInMap("AvailableResource")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource> AvailableResource { get; set; }
                                                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource : TeaModel {
                                                        [NameInMap("DBInstanceStorageRange")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZonesAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEnginesSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResourceDBInstanceStorageRange : TeaModel {
                                                            [NameInMap("Max")]
                                                            [Validation(Required=false)]
                                                            public int? Max { get; set; }
                                                            [NameInMap("Min")]
                                                            [Validation(Required=false)]
                                                            public int? Min { get; set; }
                                                            [NameInMap("Step")]
                                                            [Validation(Required=false)]
                                                            public int? Step { get; set; }
                                                        };

                                                        [NameInMap("InstanceClass")]
                                                        [Validation(Required=false)]
                                                        public string InstanceClass { get; set; }

                                                        [NameInMap("InstanceClassRemark")]
                                                        [Validation(Required=false)]
                                                        public string InstanceClassRemark { get; set; }

                                                    }

                                                }
                                                public string NetworkTypes { get; set; }
                                                public string NodeType { get; set; }
                                            }
                                        };

                                    }

                                }
                                public string Version { get; set; }
                            }
                        };

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }
                public string DbType { get; set; }
            }
        };

    }

}
