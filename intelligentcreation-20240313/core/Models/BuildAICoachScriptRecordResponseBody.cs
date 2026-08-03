// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BuildAICoachScriptRecordResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public BuildAICoachScriptRecordResponseBodyData Data { get; set; }
        public class BuildAICoachScriptRecordResponseBodyData : TeaModel {
            [NameInMap("scriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
