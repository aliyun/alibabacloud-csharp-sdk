// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsNumLineChartResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeTagsNumLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeTagsNumLineChartResponseBodyResultObject : TeaModel {
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeTagsNumLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeTagsNumLineChartResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeTagsNumLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeTagsNumLineChartResponseBodyResultObjectXaxis : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
