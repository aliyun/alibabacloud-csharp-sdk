// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentConfig : TeaModel {
        [NameInMap("AmbientSoundConfig")]
        [Validation(Required=false)]
        public AIAgentConfigAmbientSoundConfig AmbientSoundConfig { get; set; }
        public class AIAgentConfigAmbientSoundConfig : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

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

            [NameInMap("CustomParams")]
            [Validation(Required=false)]
            public string CustomParams { get; set; }

            [NameInMap("VadDuration")]
            [Validation(Required=false)]
            public int? VadDuration { get; set; }

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

            [NameInMap("FunctionMap")]
            [Validation(Required=false)]
            public List<AIAgentConfigLlmConfigFunctionMap> FunctionMap { get; set; }
            public class AIAgentConfigLlmConfigFunctionMap : TeaModel {
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                [NameInMap("MatchFunction")]
                [Validation(Required=false)]
                public string MatchFunction { get; set; }

            }

            [NameInMap("LlmCompleteReply")]
            [Validation(Required=false)]
            public bool? LlmCompleteReply { get; set; }

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

            [NameInMap("OpenAIExtraQuery")]
            [Validation(Required=false)]
            public string OpenAIExtraQuery { get; set; }

            [NameInMap("OutputMaxDelay")]
            [Validation(Required=false)]
            public int? OutputMaxDelay { get; set; }

            [NameInMap("OutputMinLength")]
            [Validation(Required=false)]
            public int? OutputMinLength { get; set; }

        }

        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public int? MaxIdleTime { get; set; }

        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public AIAgentConfigTtsConfig TtsConfig { get; set; }
        public class AIAgentConfigTtsConfig : TeaModel {
            [NameInMap("Emotion")]
            [Validation(Required=false)]
            public string Emotion { get; set; }

            [NameInMap("LanguageId")]
            [Validation(Required=false)]
            public string LanguageId { get; set; }

            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("PronunciationRules")]
            [Validation(Required=false)]
            public List<AIAgentConfigTtsConfigPronunciationRules> PronunciationRules { get; set; }
            public class AIAgentConfigTtsConfigPronunciationRules : TeaModel {
                [NameInMap("Pronunciation")]
                [Validation(Required=false)]
                public string Pronunciation { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public double? SpeechRate { get; set; }

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
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("SemanticWaitDuration")]
            [Validation(Required=false)]
            public int? SemanticWaitDuration { get; set; }

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

        [NameInMap("VcrConfig")]
        [Validation(Required=false)]
        public AIAgentConfigVcrConfig VcrConfig { get; set; }
        public class AIAgentConfigVcrConfig : TeaModel {
            [NameInMap("Equipment")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigEquipment Equipment { get; set; }
            public class AIAgentConfigVcrConfigEquipment : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("HeadMotion")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigHeadMotion HeadMotion { get; set; }
            public class AIAgentConfigVcrConfigHeadMotion : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("InvalidFrameMotion")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigInvalidFrameMotion InvalidFrameMotion { get; set; }
            public class AIAgentConfigVcrConfigInvalidFrameMotion : TeaModel {
                [NameInMap("CallbackDelay")]
                [Validation(Required=false)]
                public int? CallbackDelay { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("LookAway")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigLookAway LookAway { get; set; }
            public class AIAgentConfigVcrConfigLookAway : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("PeopleCount")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigPeopleCount PeopleCount { get; set; }
            public class AIAgentConfigVcrConfigPeopleCount : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("StillFrameMotion")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigStillFrameMotion StillFrameMotion { get; set; }
            public class AIAgentConfigVcrConfigStillFrameMotion : TeaModel {
                [NameInMap("CallbackDelay")]
                [Validation(Required=false)]
                public int? CallbackDelay { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

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
