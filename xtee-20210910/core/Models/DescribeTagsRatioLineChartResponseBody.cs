// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsRatioLineChartResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeTagsRatioLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeTagsRatioLineChartResponseBodyResultObject : TeaModel {
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeTagsRatioLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeTagsRatioLineChartResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeTagsRatioLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeTagsRatioLineChartResponseBodyResultObjectXaxis : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
