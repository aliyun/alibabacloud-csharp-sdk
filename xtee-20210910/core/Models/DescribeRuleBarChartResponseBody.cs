// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleBarChartResponseBody : TeaModel {
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
        public DescribeRuleBarChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRuleBarChartResponseBodyResultObject : TeaModel {
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeRuleBarChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeRuleBarChartResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeRuleBarChartResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeRuleBarChartResponseBodyResultObjectSeriesData : TeaModel {
                    [NameInMap("eventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    [NameInMap("num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    [NameInMap("ruleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("yaxis")]
            [Validation(Required=false)]
            public DescribeRuleBarChartResponseBodyResultObjectYaxis Yaxis { get; set; }
            public class DescribeRuleBarChartResponseBodyResultObjectYaxis : TeaModel {
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
