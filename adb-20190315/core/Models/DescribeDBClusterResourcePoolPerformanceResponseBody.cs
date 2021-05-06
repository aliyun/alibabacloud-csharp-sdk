// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterResourcePoolPerformanceResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformances : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("ResourcePoolPerformances")]
            [Validation(Required=false)]
            public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformances> ResourcePoolPerformances { get; set; }
            public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformances : TeaModel {
                [NameInMap("ResourcePoolName")]
                [Validation(Required=false)]
                public string ResourcePoolName { get; set; }

                [NameInMap("ResourcePoolSeries")]
                [Validation(Required=false)]
                public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformancesResourcePoolSeries> ResourcePoolSeries { get; set; }
                public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformancesResourcePoolSeries : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

    }

}
