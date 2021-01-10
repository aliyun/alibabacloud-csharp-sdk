// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsDataTopksResponseBody : TeaModel {
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
        public QueryRmsDataTopksResponseBodyResponse Response { get; set; }
        public class QueryRmsDataTopksResponseBodyResponse : TeaModel {
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
            public QueryRmsDataTopksResponseBodyResponseData Data { get; set; }
            public class QueryRmsDataTopksResponseBodyResponseData : TeaModel {
                [NameInMap("ResultType")]
                [Validation(Required=false)]
                public string ResultType { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<QueryRmsDataTopksResponseBodyResponseDataResult> Result { get; set; }
                public class QueryRmsDataTopksResponseBodyResponseDataResult : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("TargetId")]
                    [Validation(Required=false)]
                    public string TargetId { get; set; }

                    [NameInMap("TargetName")]
                    [Validation(Required=false)]
                    public string TargetName { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public string Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }
        };

    }

}
