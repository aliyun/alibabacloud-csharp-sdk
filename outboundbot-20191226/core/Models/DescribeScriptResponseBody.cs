// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeScriptResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NlsConfig")]
        [Validation(Required=false)]
        public string NlsConfig { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Script")]
        [Validation(Required=false)]
        public DescribeScriptResponseBodyScript Script { get; set; }
        public class DescribeScriptResponseBodyScript : TeaModel {
            [NameInMap("AsrConfig")]
            [Validation(Required=false)]
            public string AsrConfig { get; set; }

            [NameInMap("ChatbotId")]
            [Validation(Required=false)]
            public string ChatbotId { get; set; }

            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }

            [NameInMap("EmotionEnable")]
            [Validation(Required=false)]
            public bool? EmotionEnable { get; set; }

            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            [NameInMap("IsDebugDrafted")]
            [Validation(Required=false)]
            public bool? IsDebugDrafted { get; set; }

            [NameInMap("IsDrafted")]
            [Validation(Required=false)]
            public bool? IsDrafted { get; set; }

            [NameInMap("LongWaitEnable")]
            [Validation(Required=false)]
            public bool? LongWaitEnable { get; set; }

            [NameInMap("MiniPlaybackEnable")]
            [Validation(Required=false)]
            public bool? MiniPlaybackEnable { get; set; }

            [NameInMap("NewBargeInEnable")]
            [Validation(Required=false)]
            public bool? NewBargeInEnable { get; set; }

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

            [NameInMap("TtsConfig")]
            [Validation(Required=false)]
            public string TtsConfig { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
