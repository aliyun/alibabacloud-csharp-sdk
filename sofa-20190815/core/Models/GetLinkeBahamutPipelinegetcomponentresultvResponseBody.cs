// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutPipelinegetcomponentresultvResponseBody : TeaModel {
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
        public GetLinkeBahamutPipelinegetcomponentresultvResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutPipelinegetcomponentresultvResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }
            [NameInMap("ExecutingData")]
            [Validation(Required=false)]
            public string ExecutingData { get; set; }
            [NameInMap("FailedData")]
            [Validation(Required=false)]
            public string FailedData { get; set; }
            [NameInMap("Html")]
            [Validation(Required=false)]
            public string Html { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PassedData")]
            [Validation(Required=false)]
            public string PassedData { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("WarnData")]
            [Validation(Required=false)]
            public string WarnData { get; set; }
            [NameInMap("OutPutList")]
            [Validation(Required=false)]
            public List<string> OutPutList { get; set; }
        };

    }

}
