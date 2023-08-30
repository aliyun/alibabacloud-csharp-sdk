// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetServiceMethodPageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceMethodPageResponseBodyData Data { get; set; }
        public class GetServiceMethodPageResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetServiceMethodPageResponseBodyDataResult> Result { get; set; }
            public class GetServiceMethodPageResponseBodyDataResult : TeaModel {
                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NameDetail")]
                [Validation(Required=false)]
                public string NameDetail { get; set; }

                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public List<GetServiceMethodPageResponseBodyDataResultParameterDefinitions> ParameterDefinitions { get; set; }
                public class GetServiceMethodPageResponseBodyDataResultParameterDefinitions : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("ParameterDetails")]
                [Validation(Required=false)]
                public List<string> ParameterDetails { get; set; }

                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public List<string> ParameterTypes { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public List<string> RequestMethods { get; set; }

                [NameInMap("ReturnDetails")]
                [Validation(Required=false)]
                public string ReturnDetails { get; set; }

                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
