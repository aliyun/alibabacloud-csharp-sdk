// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateScriptRequest : TeaModel {
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public string AsrConfig { get; set; }

        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LongWaitEnable")]
        [Validation(Required=false)]
        public bool? LongWaitEnable { get; set; }

        [NameInMap("MiniPlaybackConfigListJsonString")]
        [Validation(Required=false)]
        public string MiniPlaybackConfigListJsonString { get; set; }

        [NameInMap("MiniPlaybackEnable")]
        [Validation(Required=false)]
        public bool? MiniPlaybackEnable { get; set; }

        [NameInMap("NewBargeInEnable")]
        [Validation(Required=false)]
        public bool? NewBargeInEnable { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public List<string> ScriptContent { get; set; }

        [NameInMap("ScriptDescription")]
        [Validation(Required=false)]
        public string ScriptDescription { get; set; }

        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        [NameInMap("ScriptWaveform")]
        [Validation(Required=false)]
        public List<string> ScriptWaveform { get; set; }

        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public string TtsConfig { get; set; }

    }

}
