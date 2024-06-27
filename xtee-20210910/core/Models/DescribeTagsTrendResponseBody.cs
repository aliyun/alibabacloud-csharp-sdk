// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsTrendResponseBody : TeaModel {
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
        public DescribeTagsTrendResponseBodyResultObject ResultObject { get; set; }
        public class DescribeTagsTrendResponseBodyResultObject : TeaModel {
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeTagsTrendResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeTagsTrendResponseBodyResultObjectSeries : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeTagsTrendResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeTagsTrendResponseBodyResultObjectSeriesData : TeaModel {
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

            }

            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeTagsTrendResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeTagsTrendResponseBodyResultObjectXaxis : TeaModel {
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
