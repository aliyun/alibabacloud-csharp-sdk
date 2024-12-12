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

            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigAvatarChat3DLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigAvatarChat3DLlmHistory : TeaModel {
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

            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

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

        [NameInMap("VisionChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVisionChat VisionChat { get; set; }
        public class AIAgentTemplateConfigVisionChat : TeaModel {
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigVisionChatLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigVisionChatLlmHistory : TeaModel {
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

            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

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

        [NameInMap("VoiceChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVoiceChat VoiceChat { get; set; }
        public class AIAgentTemplateConfigVoiceChat : TeaModel {
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("AvatarUrlType")]
            [Validation(Required=false)]
            public string AvatarUrlType { get; set; }

            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigVoiceChatLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigVoiceChatLlmHistory : TeaModel {
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

            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

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

}
