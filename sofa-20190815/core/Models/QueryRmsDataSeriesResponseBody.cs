// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsDataSeriesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsDataSeriesResponseBodyResponse Response { get; set; }
        public class QueryRmsDataSeriesResponseBodyResponse : TeaModel {
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryRmsDataSeriesResponseBodyResponseData Data { get; set; }
            public class QueryRmsDataSeriesResponseBodyResponseData : TeaModel {
                [NameInMap("ResultType")]
                [Validation(Required=false)]
                public string ResultType { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<QueryRmsDataSeriesResponseBodyResponseDataResult> Result { get; set; }
                public class QueryRmsDataSeriesResponseBodyResponseDataResult : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }
        };

    }

}
