// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionNumLineChartResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeScoreSectionNumLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeScoreSectionNumLineChartResponseBodyResultObject : TeaModel {
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeScoreSectionNumLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeScoreSectionNumLineChartResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeScoreSectionNumLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeScoreSectionNumLineChartResponseBodyResultObjectXaxis : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
