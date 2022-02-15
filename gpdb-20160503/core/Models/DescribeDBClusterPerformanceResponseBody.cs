// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBClusterPerformanceResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeys> PerformanceKeys { get; set; }
        public class DescribeDBClusterPerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeries : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeriesValues> Values { get; set; }
                public class DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeriesValues : TeaModel {
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
