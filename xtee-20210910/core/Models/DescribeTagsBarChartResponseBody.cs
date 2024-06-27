// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsBarChartResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeTagsBarChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeTagsBarChartResponseBodyResultObject : TeaModel {
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeTagsBarChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeTagsBarChartResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeTagsBarChartResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeTagsBarChartResponseBodyResultObjectSeriesData : TeaModel {
                    [NameInMap("num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    [NameInMap("scale")]
                    [Validation(Required=false)]
                    public string Scale { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("stack")]
                [Validation(Required=false)]
                public string Stack { get; set; }

            }

            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeTagsBarChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeTagsBarChartResponseBodyResultObjectXaxis : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
