// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutSamecodereporecommendResponseBody : TeaModel {
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
        public List<GetLinkeBahamutSamecodereporecommendResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutSamecodereporecommendResponseBodyResult : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("CodeName")]
            [Validation(Required=false)]
            public string CodeName { get; set; }

            [NameInMap("CouldPushStage")]
            [Validation(Required=false)]
            public bool? CouldPushStage { get; set; }

            [NameInMap("CurrentStageName")]
            [Validation(Required=false)]
            public string CurrentStageName { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public List<string> Reason { get; set; }

        }

    }

}
