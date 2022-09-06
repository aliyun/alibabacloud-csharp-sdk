// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class WithdrawScriptReviewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Script")]
        [Validation(Required=false)]
        public WithdrawScriptReviewResponseBodyScript Script { get; set; }
        public class WithdrawScriptReviewResponseBodyScript : TeaModel {
            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }

            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            [NameInMap("IsDebugDrafted")]
            [Validation(Required=false)]
            public bool? IsDebugDrafted { get; set; }

            [NameInMap("IsDrafted")]
            [Validation(Required=false)]
            public bool? IsDrafted { get; set; }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("ScriptDescription")]
            [Validation(Required=false)]
            public string ScriptDescription { get; set; }

            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
