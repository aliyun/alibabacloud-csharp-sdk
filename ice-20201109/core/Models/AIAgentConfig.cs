// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentConfig : TeaModel {
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public AIAgentConfigAsrConfig AsrConfig { get; set; }
        public class AIAgentConfigAsrConfig : TeaModel {
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

        }

        [NameInMap("AvatarConfig")]
        [Validation(Required=false)]
        public AIAgentConfigAvatarConfig AvatarConfig { get; set; }
        public class AIAgentConfigAvatarConfig : TeaModel {
            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

        }

        [NameInMap("AvatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("AvatarUrlType")]
        [Validation(Required=false)]
        public string AvatarUrlType { get; set; }

        [NameInMap("EnableIntelligentSegment")]
        [Validation(Required=false)]
        public bool? EnableIntelligentSegment { get; set; }

        [NameInMap("EnablePushToTalk")]
        [Validation(Required=false)]
        public bool? EnablePushToTalk { get; set; }

        [NameInMap("ExperimentalConfig")]
        [Validation(Required=false)]
        public string ExperimentalConfig { get; set; }

        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public AIAgentConfigInterruptConfig InterruptConfig { get; set; }
        public class AIAgentConfigInterruptConfig : TeaModel {
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

        }

        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public AIAgentConfigLlmConfig LlmConfig { get; set; }
        public class AIAgentConfigLlmConfig : TeaModel {
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentConfigLlmConfigLlmHistory> LlmHistory { get; set; }
            public class AIAgentConfigLlmConfigLlmHistory : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

        }

        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public int? MaxIdleTime { get; set; }

        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public AIAgentConfigTtsConfig TtsConfig { get; set; }
        public class AIAgentConfigTtsConfig : TeaModel {
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

        }

        [NameInMap("TurnDetectionConfig")]
        [Validation(Required=false)]
        public AIAgentConfigTurnDetectionConfig TurnDetectionConfig { get; set; }
        public class AIAgentConfigTurnDetectionConfig : TeaModel {
            [NameInMap("TurnEndWords")]
            [Validation(Required=false)]
            public List<string> TurnEndWords { get; set; }

        }

        [NameInMap("UserOfflineTimeout")]
        [Validation(Required=false)]
        public int? UserOfflineTimeout { get; set; }

        [NameInMap("UserOnlineTimeout")]
        [Validation(Required=false)]
        public int? UserOnlineTimeout { get; set; }

        [NameInMap("VoiceprintConfig")]
        [Validation(Required=false)]
        public AIAgentConfigVoiceprintConfig VoiceprintConfig { get; set; }
        public class AIAgentConfigVoiceprintConfig : TeaModel {
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

        }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

        [NameInMap("WakeUpQuery")]
        [Validation(Required=false)]
        public string WakeUpQuery { get; set; }

        [NameInMap("WorkflowOverrideParams")]
        [Validation(Required=false)]
        public string WorkflowOverrideParams { get; set; }

    }

}
