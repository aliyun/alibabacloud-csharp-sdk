// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutWebapigetlogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutWebapigetlogsResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutWebapigetlogsResponseBodyResult : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ContentDetail")]
            [Validation(Required=false)]
            public string ContentDetail { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("PostValue")]
            [Validation(Required=false)]
            public string PostValue { get; set; }

            [NameInMap("PreValue")]
            [Validation(Required=false)]
            public string PreValue { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
