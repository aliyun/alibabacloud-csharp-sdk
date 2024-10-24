// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentTemplateConfig : TeaModel {
        [NameInMap("AvatarChat3D")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigAvatarChat3D AvatarChat3D { get; set; }
        public class AIAgentTemplateConfigAvatarChat3D : TeaModel {
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

        }

        [NameInMap("VisionChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVisionChat VisionChat { get; set; }
        public class AIAgentTemplateConfigVisionChat : TeaModel {
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

        }

        [NameInMap("VoiceChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVoiceChat VoiceChat { get; set; }
        public class AIAgentTemplateConfigVoiceChat : TeaModel {
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

        }

    }

}
