// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasTaskLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasTaskLogResponseBodyData> Data { get; set; }
        public class QueryCasTaskLogResponseBodyData : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public string LogTime { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskTimes")]
            [Validation(Required=false)]
            public long? TaskTimes { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("IaasErrorInfo")]
            [Validation(Required=false)]
            public QueryCasTaskLogResponseBodyDataIaasErrorInfo IaasErrorInfo { get; set; }
            public class QueryCasTaskLogResponseBodyDataIaasErrorInfo : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }
                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public long? StatusCode { get; set; }
            };

            [NameInMap("IaasRequest")]
            [Validation(Required=false)]
            public QueryCasTaskLogResponseBodyDataIaasRequest IaasRequest { get; set; }
            public class QueryCasTaskLogResponseBodyDataIaasRequest : TeaModel {
                [NameInMap("RequestBody")]
                [Validation(Required=false)]
                public string RequestBody { get; set; }
                [NameInMap("RequestMethod")]
                [Validation(Required=false)]
                public string RequestMethod { get; set; }
                [NameInMap("RequestUrl")]
                [Validation(Required=false)]
                public string RequestUrl { get; set; }
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public List<QueryCasTaskLogResponseBodyDataIaasRequestRequestHeaders> RequestHeaders { get; set; }
                public class QueryCasTaskLogResponseBodyDataIaasRequestRequestHeaders : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            };

            [NameInMap("IaasResponse")]
            [Validation(Required=false)]
            public QueryCasTaskLogResponseBodyDataIaasResponse IaasResponse { get; set; }
            public class QueryCasTaskLogResponseBodyDataIaasResponse : TeaModel {
                [NameInMap("ResponseBody")]
                [Validation(Required=false)]
                public string ResponseBody { get; set; }
                [NameInMap("ResponseHeaders")]
                [Validation(Required=false)]
                public List<QueryCasTaskLogResponseBodyDataIaasResponseResponseHeaders> ResponseHeaders { get; set; }
                public class QueryCasTaskLogResponseBodyDataIaasResponseResponseHeaders : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            };

        }

    }

}
