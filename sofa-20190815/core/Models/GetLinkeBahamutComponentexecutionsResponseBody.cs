// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutComponentexecutionsResponseBody : TeaModel {
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
        public List<GetLinkeBahamutComponentexecutionsResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutComponentexecutionsResponseBodyResult : TeaModel {
            [NameInMap("CausedBy")]
            [Validation(Required=false)]
            public string CausedBy { get; set; }

            [NameInMap("ComponentDisplayName")]
            [Validation(Required=false)]
            public string ComponentDisplayName { get; set; }

            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            [NameInMap("DetailStatus")]
            [Validation(Required=false)]
            public string DetailStatus { get; set; }

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("ExecutionResult")]
            [Validation(Required=false)]
            public string ExecutionResult { get; set; }

            [NameInMap("ExecutionTaskId")]
            [Validation(Required=false)]
            public string ExecutionTaskId { get; set; }

            [NameInMap("ExpressionData")]
            [Validation(Required=false)]
            public string ExpressionData { get; set; }

            [NameInMap("ExpressionDesc")]
            [Validation(Required=false)]
            public string ExpressionDesc { get; set; }

            [NameInMap("ExpressionRule")]
            [Validation(Required=false)]
            public string ExpressionRule { get; set; }

            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("HtmlText")]
            [Validation(Required=false)]
            public string HtmlText { get; set; }

            [NameInMap("LoggerUrl")]
            [Validation(Required=false)]
            public string LoggerUrl { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TipHtml")]
            [Validation(Required=false)]
            public string TipHtml { get; set; }

        }

    }

}
