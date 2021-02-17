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
                [NameInMap("AvailableZone")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZone> AvailableZone { get; set; }
                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZone : TeaModel {
                    [NameInMap("SupportedEngineVersions")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersions SupportedEngineVersions { get; set; }
                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersions : TeaModel {
                        [NameInMap("SupportedEngineVersion")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                            [NameInMap("SupportedEngine")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngine> SupportedEngine { get; set; }
                            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngine : TeaModel {
                                [NameInMap("SupportedNodeTypes")]
                                [Validation(Required=false)]
                                public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypes SupportedNodeTypes { get; set; }
                                public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypes : TeaModel {
                                    [NameInMap("SupportedNodeType")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypesSupportedNodeType> SupportedNodeType { get; set; }
                                    public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypesSupportedNodeType : TeaModel {
                                        public string NodeType { get; set; }
                                        public string NetworkTypes { get; set; }
                                        public DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResources AvailableResources { get; set; }
                                        public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResources : TeaModel {
                                            [NameInMap("AvailableResource")]
                                            [Validation(Required=false)]
                                            public List<DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource> AvailableResource { get; set; }
                                            public class DescribeAvailableResourceResponseBodySupportedDBTypesSupportedDBTypeAvailableZoneSupportedEngineVersionsSupportedEngineVersionSupportedEngineSupportedNodeTypesSupportedNodeTypeAvailableResourcesAvailableResource : TeaModel {
                                                [NameInMap("InstanceClassRemark")]
                                                [Validation(Required=false)]
                                                public string InstanceClassRemark { get; set; }

                                                [NameInMap("InstanceClass")]
                                                [Validation(Required=false)]
                                                public string InstanceClass { get; set; }

                                            }

                                        }
                                    }
                                };

                                [NameInMap("Engine")]
                                [Validation(Required=false)]
                                public string Engine { get; set; }

                            }

                        }
                    };

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

            }
        };

    }

}
