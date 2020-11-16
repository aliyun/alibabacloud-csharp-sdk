// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeAvailableResourcesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=true)]
        public List<DescribeAvailableResourcesResponseResources> Resources { get; set; }
        public class DescribeAvailableResourcesResponseResources : TeaModel {
            [NameInMap("ZoneId")]
            [Validation(Required=true)]
            public string ZoneId { get; set; }

            [NameInMap("SupportedEngines")]
            [Validation(Required=true)]
            public List<DescribeAvailableResourcesResponseResourcesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableResourcesResponseResourcesSupportedEngines : TeaModel {
                [NameInMap("SupportedEngineVersion")]
                [Validation(Required=true)]
                public string SupportedEngineVersion { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=true)]
                public string Mode { get; set; }

                [NameInMap("SupportedInstanceClasses")]
                [Validation(Required=true)]
                public List<DescribeAvailableResourcesResponseResourcesSupportedEnginesSupportedInstanceClasses> SupportedInstanceClasses { get; set; }
                public class DescribeAvailableResourcesResponseResourcesSupportedEnginesSupportedInstanceClasses : TeaModel {
                    [NameInMap("DisplayClass")]
                    [Validation(Required=true)]
                    public string DisplayClass { get; set; }

                    [NameInMap("InstanceClass")]
                    [Validation(Required=true)]
                    public string InstanceClass { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=true)]
                    public string Description { get; set; }

                    [NameInMap("StorageType")]
                    [Validation(Required=true)]
                    public string StorageType { get; set; }

                    [NameInMap("NodeCount")]
                    [Validation(Required=true)]
                    public DescribeAvailableResourcesResponseResourcesSupportedEnginesSupportedInstanceClassesNodeCount NodeCount { get; set; }
                    public class DescribeAvailableResourcesResponseResourcesSupportedEnginesSupportedInstanceClassesNodeCount : TeaModel {
                        [NameInMap("MinCount")]
                        [Validation(Required=true)]
                        public string MinCount { get; set; }
                        [NameInMap("MaxCount")]
                        [Validation(Required=true)]
                        public string MaxCount { get; set; }
                        [NameInMap("Step")]
                        [Validation(Required=true)]
                        public string Step { get; set; }
                    };

                    [NameInMap("StorageSize")]
                    [Validation(Required=true)]
                    public DescribeAvailableResourcesResponseResourcesSupportedEnginesSupportedInstanceClassesStorageSize StorageSize { get; set; }
                    public class DescribeAvailableResourcesResponseResourcesSupportedEnginesSupportedInstanceClassesStorageSize : TeaModel {
                        [NameInMap("MinCount")]
                        [Validation(Required=true)]
                        public string MinCount { get; set; }
                        [NameInMap("MaxCount")]
                        [Validation(Required=true)]
                        public string MaxCount { get; set; }
                        [NameInMap("Step")]
                        [Validation(Required=true)]
                        public string Step { get; set; }
                    };

                }

            }

        }

    }

}
