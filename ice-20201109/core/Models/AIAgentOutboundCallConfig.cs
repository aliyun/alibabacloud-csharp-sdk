// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentOutboundCallConfig : TeaModel {
        [NameInMap("AmbientSoundConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAmbientSoundConfig AmbientSoundConfig { get; set; }
        public class AIAgentOutboundCallConfigAmbientSoundConfig : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAsrConfig AsrConfig { get; set; }
        public class AIAgentOutboundCallConfigAsrConfig : TeaModel {
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

        [NameInMap("AutoSpeechConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAutoSpeechConfig AutoSpeechConfig { get; set; }
        public class AIAgentOutboundCallConfigAutoSpeechConfig : TeaModel {
            [NameInMap("LlmPending")]
            [Validation(Required=false)]
            public AIAgentOutboundCallConfigAutoSpeechConfigLlmPending LlmPending { get; set; }
            public class AIAgentOutboundCallConfigAutoSpeechConfigLlmPending : TeaModel {
                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentOutboundCallConfigAutoSpeechConfigLlmPendingMessages> Messages { get; set; }
                public class AIAgentOutboundCallConfigAutoSpeechConfigLlmPendingMessages : TeaModel {
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

            [NameInMap("UserIdle")]
            [Validation(Required=false)]
            public AIAgentOutboundCallConfigAutoSpeechConfigUserIdle UserIdle { get; set; }
            public class AIAgentOutboundCallConfigAutoSpeechConfigUserIdle : TeaModel {
                [NameInMap("MaxRepeats")]
                [Validation(Required=false)]
                public int? MaxRepeats { get; set; }

                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentOutboundCallConfigAutoSpeechConfigUserIdleMessages> Messages { get; set; }
                public class AIAgentOutboundCallConfigAutoSpeechConfigUserIdleMessages : TeaModel {
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

        }

        [NameInMap("EnableIntelligentSegment")]
        [Validation(Required=false)]
        public bool? EnableIntelligentSegment { get; set; }

        [NameInMap("ExperimentalConfig")]
        [Validation(Required=false)]
        public string ExperimentalConfig { get; set; }

        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        [NameInMap("GreetingDelay")]
        [Validation(Required=false)]
        public int? GreetingDelay { get; set; }

        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigInterruptConfig InterruptConfig { get; set; }
        public class AIAgentOutboundCallConfigInterruptConfig : TeaModel {
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

        }

        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigLlmConfig LlmConfig { get; set; }
        public class AIAgentOutboundCallConfigLlmConfig : TeaModel {
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("FunctionMap")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigLlmConfigFunctionMap> FunctionMap { get; set; }
            public class AIAgentOutboundCallConfigLlmConfigFunctionMap : TeaModel {
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                [NameInMap("MatchFunction")]
                [Validation(Required=false)]
                public string MatchFunction { get; set; }

            }

            [NameInMap("HistorySyncWithTTS")]
            [Validation(Required=false)]
            public bool? HistorySyncWithTTS { get; set; }

            [NameInMap("LlmCompleteReply")]
            [Validation(Required=false)]
            public bool? LlmCompleteReply { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigLlmConfigLlmHistory> LlmHistory { get; set; }
            public class AIAgentOutboundCallConfigLlmConfigLlmHistory : TeaModel {
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
            public string OutputMaxDelay { get; set; }

            [NameInMap("OutputMinLength")]
            [Validation(Required=false)]
            public int? OutputMinLength { get; set; }

        }

        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public int? MaxIdleTime { get; set; }

        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigTtsConfig TtsConfig { get; set; }
        public class AIAgentOutboundCallConfigTtsConfig : TeaModel {
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
            public List<AIAgentOutboundCallConfigTtsConfigPronunciationRules> PronunciationRules { get; set; }
            public class AIAgentOutboundCallConfigTtsConfigPronunciationRules : TeaModel {
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
        public AIAgentOutboundCallConfigTurnDetectionConfig TurnDetectionConfig { get; set; }
        public class AIAgentOutboundCallConfigTurnDetectionConfig : TeaModel {
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

    }

}
