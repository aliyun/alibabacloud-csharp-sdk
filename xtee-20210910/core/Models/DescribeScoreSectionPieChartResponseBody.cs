// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionPieChartResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeScoreSectionPieChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeScoreSectionPieChartResponseBodyResultObject : TeaModel {
            [NameInMap("animation")]
            [Validation(Required=false)]
            public bool? Animation { get; set; }

            [NameInMap("grid")]
            [Validation(Required=false)]
            public DescribeScoreSectionPieChartResponseBodyResultObjectGrid Grid { get; set; }
            public class DescribeScoreSectionPieChartResponseBodyResultObjectGrid : TeaModel {
                [NameInMap("show")]
                [Validation(Required=false)]
                public bool? Show { get; set; }

            }

            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeScoreSectionPieChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeScoreSectionPieChartResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeScoreSectionPieChartResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeScoreSectionPieChartResponseBodyResultObjectSeriesData : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("roseType")]
                [Validation(Required=false)]
                public bool? RoseType { get; set; }

            }

        }

    }

}
