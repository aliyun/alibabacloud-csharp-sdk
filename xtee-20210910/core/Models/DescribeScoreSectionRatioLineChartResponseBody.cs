// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionRatioLineChartResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeScoreSectionRatioLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeScoreSectionRatioLineChartResponseBodyResultObject : TeaModel {
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeScoreSectionRatioLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeScoreSectionRatioLineChartResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeScoreSectionRatioLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeScoreSectionRatioLineChartResponseBodyResultObjectXaxis : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
