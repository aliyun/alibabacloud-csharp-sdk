// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeAvailableResourcesResponseBody : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeAvailableResourcesResponseBodyResources : TeaModel {
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableResourcesResponseBodyResourcesSupportedEngines : TeaModel {
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("SupportedEngineVersion")]
                [Validation(Required=false)]
                public string SupportedEngineVersion { get; set; }

                [NameInMap("SupportedInstanceClasses")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses> SupportedInstanceClasses { get; set; }
                public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DisplayClass")]
                    [Validation(Required=false)]
                    public string DisplayClass { get; set; }

                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount NodeCount { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount : TeaModel {
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public string Step { get; set; }
                    };

                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize StorageSize { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize : TeaModel {
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public string Step { get; set; }
                    };

                    [NameInMap("StorageType")]
                    [Validation(Required=false)]
                    public string StorageType { get; set; }

                }

            }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
