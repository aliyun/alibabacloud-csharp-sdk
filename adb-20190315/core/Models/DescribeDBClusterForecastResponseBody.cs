// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterForecastResponseBody : TeaModel {
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterForecastResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterForecastResponseBodyPerformances : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterForecastResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribeDBClusterForecastResponseBodyPerformancesSeries : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public string Values { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
