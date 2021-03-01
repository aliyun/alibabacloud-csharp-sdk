// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceMethodPageResponseBody : TeaModel {
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceMethodPageResponseBodyData Data { get; set; }
        public class GetServiceMethodPageResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetServiceMethodPageResponseBodyDataResult> Result { get; set; }
            public class GetServiceMethodPageResponseBodyDataResult : TeaModel {
                public string ParameterDetails { get; set; }
                public string ParameterNames { get; set; }
                public string Paths { get; set; }
                public string ParameterTypes { get; set; }
                public string ReturnType { get; set; }
                public string NameDetail { get; set; }
                public string ParameterDefinitions { get; set; }
                public GetServiceMethodPageResponseBodyDataResultReturnDefinition ReturnDefinition { get; set; }
                public class GetServiceMethodPageResponseBodyDataResultReturnDefinition : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }
                public string RequestMethods { get; set; }
                public string ReturnDetails { get; set; }
                public string Name { get; set; }
                public string MethodController { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
