// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptVoiceConfigsResponseBody : TeaModel {
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

        [NameInMap("ScriptVoiceConfigs")]
        [Validation(Required=false)]
        public ListScriptVoiceConfigsResponseBodyScriptVoiceConfigs ScriptVoiceConfigs { get; set; }
        public class ListScriptVoiceConfigsResponseBodyScriptVoiceConfigs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListScriptVoiceConfigsResponseBodyScriptVoiceConfigsList> List { get; set; }
            public class ListScriptVoiceConfigsResponseBodyScriptVoiceConfigsList : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ScriptContent")]
                [Validation(Required=false)]
                public string ScriptContent { get; set; }

                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                [NameInMap("ScriptVoiceConfigId")]
                [Validation(Required=false)]
                public string ScriptVoiceConfigId { get; set; }

                [NameInMap("ScriptWaveformRelation")]
                [Validation(Required=false)]
                public string ScriptWaveformRelation { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
