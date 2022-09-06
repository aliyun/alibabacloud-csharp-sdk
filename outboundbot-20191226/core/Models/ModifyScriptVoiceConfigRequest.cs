// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyScriptVoiceConfigRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("ScriptVoiceConfigId")]
        [Validation(Required=false)]
        public string ScriptVoiceConfigId { get; set; }

        [NameInMap("ScriptWaveformRelation")]
        [Validation(Required=false)]
        public string ScriptWaveformRelation { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
