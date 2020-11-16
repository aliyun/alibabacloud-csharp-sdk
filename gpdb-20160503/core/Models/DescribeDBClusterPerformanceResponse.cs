// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBClusterPerformanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=true)]
        public string DBClusterId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public string EndTime { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=true)]
        public List<DescribeDBClusterPerformanceResponsePerformanceKeys> PerformanceKeys { get; set; }
        public class DescribeDBClusterPerformanceResponsePerformanceKeys : TeaModel {
            [NameInMap("Unit")]
            [Validation(Required=true)]
            public string Unit { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Series")]
            [Validation(Required=true)]
            public List<DescribeDBClusterPerformanceResponsePerformanceKeysSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponsePerformanceKeysSeries : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("Role")]
                [Validation(Required=true)]
                public string Role { get; set; }

                [NameInMap("Values")]
                [Validation(Required=true)]
                public List<DescribeDBClusterPerformanceResponsePerformanceKeysSeriesValues> Values { get; set; }
                public class DescribeDBClusterPerformanceResponsePerformanceKeysSeriesValues : TeaModel {
                    [NameInMap("Point")]
                    [Validation(Required=true)]
                    public List<string> Point { get; set; }

                }

            }

        }

    }

}
