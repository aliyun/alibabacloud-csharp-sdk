// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateModelApplicationRequest : TeaModel {
        /// <summary>
        /// <para>应用编码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>应用并发请求数</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ApplicationCps")]
        [Validation(Required=false)]
        public long? ApplicationCps { get; set; }

        /// <summary>
        /// <para>模型应用名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CallAssistantHangup")]
        [Validation(Required=false)]
        public bool? CallAssistantHangup { get; set; }

        /// <summary>
        /// <para>通话助手识别</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("CallAssistantRecognize")]
        [Validation(Required=false)]
        public bool? CallAssistantRecognize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CallConnectedTriggerModel")]
        [Validation(Required=false)]
        public bool? CallConnectedTriggerModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("DtmfAllowedDigits")]
        [Validation(Required=false)]
        public string DtmfAllowedDigits { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DtmfAutoValidateEnable")]
        [Validation(Required=false)]
        public bool? DtmfAutoValidateEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfDigitCount")]
        [Validation(Required=false)]
        public long? DtmfDigitCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfInputTimeout")]
        [Validation(Required=false)]
        public long? DtmfInputTimeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RETURN_MODEL</para>
        /// </summary>
        [NameInMap("DtmfOutOfRangeAction")]
        [Validation(Required=false)]
        public string DtmfOutOfRangeAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfRetryPlayTimes")]
        [Validation(Required=false)]
        public long? DtmfRetryPlayTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("DtmfRetryPromptText")]
        [Validation(Required=false)]
        public string DtmfRetryPromptText { get; set; }

        /// <summary>
        /// <para>场景名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("DyvmsSceneName")]
        [Validation(Required=false)]
        public string DyvmsSceneName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDtmfReceive")]
        [Validation(Required=false)]
        public bool? EnableDtmfReceive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableMorse")]
        [Validation(Required=false)]
        public bool? EnableMorse { get; set; }

        /// <summary>
        /// <para>打断配置</para>
        /// </summary>
        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public UpdateModelApplicationRequestInterruptConfig InterruptConfig { get; set; }
        public class UpdateModelApplicationRequestInterruptConfig : TeaModel {
            /// <summary>
            /// <para>防止连续抢话功能配置</para>
            /// </summary>
            [NameInMap("AvoidInterruptDTO")]
            [Validation(Required=false)]
            public UpdateModelApplicationRequestInterruptConfigAvoidInterruptDTO AvoidInterruptDTO { get; set; }
            public class UpdateModelApplicationRequestInterruptConfigAvoidInterruptDTO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("InterruptNum")]
                [Validation(Required=false)]
                public long? InterruptNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16.417547</para>
                /// </summary>
                [NameInMap("InterruptProtectDuration")]
                [Validation(Required=false)]
                public double? InterruptProtectDuration { get; set; }

            }

            /// <summary>
            /// <para>防止连续抢话功能是否开启</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAvoidInterrupt")]
            [Validation(Required=false)]
            public bool? EnableAvoidInterrupt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableInterruptBackchannel")]
            [Validation(Required=false)]
            public bool? EnableInterruptBackchannel { get; set; }

            /// <summary>
            /// <para>开场白全程不打断</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStartwordEntireNotInterrupt")]
            [Validation(Required=false)]
            public bool? EnableStartwordEntireNotInterrupt { get; set; }

            /// <summary>
            /// <para>开场白不打断配置是否开启</para>
            /// </summary>
            [NameInMap("EnableStartwordNotInterrupt")]
            [Validation(Required=false)]
            public bool? EnableStartwordNotInterrupt { get; set; }

            /// <summary>
            /// <para>开场白保护时长</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.4699</para>
            /// </summary>
            [NameInMap("StartwordProtectDuration")]
            [Validation(Required=false)]
            public double? StartwordProtectDuration { get; set; }

        }

        /// <summary>
        /// <para>模型编码</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>模型版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// <para>第一个静音是否唤起模型</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MuteActive")]
        [Validation(Required=false)]
        public bool? MuteActive { get; set; }

        /// <summary>
        /// <para>静音时长</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("MuteDuration")]
        [Validation(Required=false)]
        public long? MuteDuration { get; set; }

        /// <summary>
        /// <para>连续多少个静音事件主动挂机</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MuteHangupNum")]
        [Validation(Required=false)]
        public long? MuteHangupNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>提示词</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>资质ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>61</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para>资质名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("RecordingFile")]
        [Validation(Required=false)]
        public string RecordingFile { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>最大通话时长</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public long? SessionTimeout { get; set; }

        /// <summary>
        /// <para>来源</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>话术内容</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("SpeechContent")]
        [Validation(Required=false)]
        public string SpeechContent { get; set; }

        /// <summary>
        /// <para>话束id</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SpeechId")]
        [Validation(Required=false)]
        public long? SpeechId { get; set; }

        /// <summary>
        /// <para>开场白</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("StartWord")]
        [Validation(Required=false)]
        public string StartWord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StartWordType")]
        [Validation(Required=false)]
        public long? StartWordType { get; set; }

        /// <summary>
        /// <para>tts配置，包括音色、音量、音速等。</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public UpdateModelApplicationRequestTtsConfig TtsConfig { get; set; }
        public class UpdateModelApplicationRequestTtsConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BackgroundEnabled")]
            [Validation(Required=false)]
            public bool? BackgroundEnabled { get; set; }

            /// <summary>
            /// <para>背景音id</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("BackgroundSound")]
            [Validation(Required=false)]
            public long? BackgroundSound { get; set; }

            /// <summary>
            /// <para>背景音音量(id)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BackgroundVolume")]
            [Validation(Required=false)]
            public long? BackgroundVolume { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("CustomerAccountId")]
            [Validation(Required=false)]
            public long? CustomerAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MixingEnabled")]
            [Validation(Required=false)]
            public bool? MixingEnabled { get; set; }

            /// <summary>
            /// <para>混音模版id</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("MixingTemplate")]
            [Validation(Required=false)]
            public long? MixingTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>TTS 变量播放时的声音速度。取值范围：-200~200，默认值为 0。</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TtsSpeed")]
            [Validation(Required=false)]
            public long? TtsSpeed { get; set; }

            /// <summary>
            /// <para>声音风格</para>
            /// 
            /// <b>Example:</b>
            /// <para>voice</para>
            /// </summary>
            [NameInMap("TtsStyle")]
            [Validation(Required=false)]
            public string TtsStyle { get; set; }

            /// <summary>
            /// <para>TTS 变量播放的音量。取值范围：0~100，默认值为 0。</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TtsVolume")]
            [Validation(Required=false)]
            public long? TtsVolume { get; set; }

            /// <summary>
            /// <para>声音编码</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("VoiceCode")]
            [Validation(Required=false)]
            public string VoiceCode { get; set; }

            /// <summary>
            /// <para>声音类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("VoiceType")]
            [Validation(Required=false)]
            public string VoiceType { get; set; }

        }

        /// <summary>
        /// <para>用途</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("UsageDesc")]
        [Validation(Required=false)]
        public string UsageDesc { get; set; }

    }

}
