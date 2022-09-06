// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyTTSConfigResponseBody : TeaModel {
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TTSConfig")]
        [Validation(Required=false)]
        public ModifyTTSConfigResponseBodyTTSConfig TTSConfig { get; set; }
        public class ModifyTTSConfigResponseBodyTTSConfig : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public string SpeechRate { get; set; }

            [NameInMap("TTSConfigId")]
            [Validation(Required=false)]
            public string TTSConfigId { get; set; }

            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public string Volume { get; set; }

        }

    }

}
