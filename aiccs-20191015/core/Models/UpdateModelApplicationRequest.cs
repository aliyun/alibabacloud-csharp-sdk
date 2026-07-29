// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateModelApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The application code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DKSDLSA</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>The number of concurrent requests for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ApplicationCps")]
        [Validation(Required=false)]
        public long? ApplicationCps { get; set; }

        /// <summary>
        /// <para>The name of the model application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试应用</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>Specifies whether to hang up when an intelligent answering service is detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CallAssistantHangup")]
        [Validation(Required=false)]
        public bool? CallAssistantHangup { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable call assistant recognition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CallAssistantRecognize")]
        [Validation(Required=false)]
        public bool? CallAssistantRecognize { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable call-connected event push. Disabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CallConnectedTriggerModel")]
        [Validation(Required=false)]
        public bool? CallConnectedTriggerModel { get; set; }

        /// <summary>
        /// <para>The enumeration of allowed key digits, separated by commas, such as 1,2,3. Maximum of 20 values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfAllowedDigits")]
        [Validation(Required=false)]
        public string DtmfAllowedDigits { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic validation of key values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DtmfAutoValidateEnable")]
        [Validation(Required=false)]
        public bool? DtmfAutoValidateEnable { get; set; }

        /// <summary>
        /// <para>The number of DTMF key digits. Valid values: 1 to 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfDigitCount")]
        [Validation(Required=false)]
        public long? DtmfDigitCount { get; set; }

        /// <summary>
        /// <para>The DTMF input timeout period in seconds. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfInputTimeout")]
        [Validation(Required=false)]
        public long? DtmfInputTimeout { get; set; }

        /// <summary>
        /// <para>The action to take when the input is out of range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RETURN_MODEL: return to the model</description></item>
        /// <item><description>AUTO_RETRY: automatically retry</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RETURN_MODEL</para>
        /// </summary>
        [NameInMap("DtmfOutOfRangeAction")]
        [Validation(Required=false)]
        public string DtmfOutOfRangeAction { get; set; }

        /// <summary>
        /// <para>The number of retry attempts (PlayTimes). Valid values: 1 to 3. Takes effect only when DtmfOutOfRangeAction is set to AUTO_RETRY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfRetryPlayTimes")]
        [Validation(Required=false)]
        public long? DtmfRetryPlayTimes { get; set; }

        /// <summary>
        /// <para>The custom retry prompt text. Maximum length: 50 characters. If left empty, the default message is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试文本</para>
        /// </summary>
        [NameInMap("DtmfRetryPromptText")]
        [Validation(Required=false)]
        public string DtmfRetryPromptText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("DtmfSendMaxCount")]
        [Validation(Required=false)]
        public long? DtmfSendMaxCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("DtmfSendWaitTimeout")]
        [Validation(Required=false)]
        public long? DtmfSendWaitTimeout { get; set; }

        /// <summary>
        /// <para>The scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试场景</para>
        /// </summary>
        [NameInMap("DyvmsSceneName")]
        [Validation(Required=false)]
        public string DyvmsSceneName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable DTMF key collection. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDtmfReceive")]
        [Validation(Required=false)]
        public bool? EnableDtmfReceive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDtmfSend")]
        [Validation(Required=false)]
        public bool? EnableDtmfSend { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Morse code configuration. Disabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableMorse")]
        [Validation(Required=false)]
        public bool? EnableMorse { get; set; }

        /// <summary>
        /// <para>The interruption configuration.</para>
        /// </summary>
        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public UpdateModelApplicationRequestInterruptConfig InterruptConfig { get; set; }
        public class UpdateModelApplicationRequestInterruptConfig : TeaModel {
            /// <summary>
            /// <para>The configuration for consecutive interruption prevention.</para>
            /// </summary>
            [NameInMap("AvoidInterruptDTO")]
            [Validation(Required=false)]
            public UpdateModelApplicationRequestInterruptConfigAvoidInterruptDTO AvoidInterruptDTO { get; set; }
            public class UpdateModelApplicationRequestInterruptConfigAvoidInterruptDTO : TeaModel {
                /// <summary>
                /// <para>The number of consecutive interruptions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("InterruptNum")]
                [Validation(Required=false)]
                public long? InterruptNum { get; set; }

                /// <summary>
                /// <para>The interruption protection duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16.417547</para>
                /// </summary>
                [NameInMap("InterruptProtectDuration")]
                [Validation(Required=false)]
                public double? InterruptProtectDuration { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable consecutive interruption prevention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAvoidInterrupt")]
            [Validation(Required=false)]
            public bool? EnableAvoidInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the interruption filler word configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableInterruptBackchannel")]
            [Validation(Required=false)]
            public bool? EnableInterruptBackchannel { get; set; }

            /// <summary>
            /// <para>Specifies whether to prevent interruption during the entire opening statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStartwordEntireNotInterrupt")]
            [Validation(Required=false)]
            public bool? EnableStartwordEntireNotInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the no-interruption configuration for the opening statement.</para>
            /// </summary>
            [NameInMap("EnableStartwordNotInterrupt")]
            [Validation(Required=false)]
            public bool? EnableStartwordNotInterrupt { get; set; }

            /// <summary>
            /// <para>The protection duration for the opening statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.4699</para>
            /// </summary>
            [NameInMap("StartwordProtectDuration")]
            [Validation(Required=false)]
            public double? StartwordProtectDuration { get; set; }

        }

        /// <summary>
        /// <para>The model code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>The model version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether the first mute event triggers the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MuteActive")]
        [Validation(Required=false)]
        public bool? MuteActive { get; set; }

        /// <summary>
        /// <para>The mute duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("MuteDuration")]
        [Validation(Required=false)]
        public long? MuteDuration { get; set; }

        /// <summary>
        /// <para>The number of consecutive mute events after which the system proactively hangs up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MuteHangupNum")]
        [Validation(Required=false)]
        public long? MuteHangupNum { get; set; }

        /// <summary>
        /// <para>The push mode for mute events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FIRST_ONLY</para>
        /// </summary>
        [NameInMap("MutePushMode")]
        [Validation(Required=false)]
        public string MutePushMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ASR recognition pause duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>350</para>
        /// </summary>
        [NameInMap("PauseTime")]
        [Validation(Required=false)]
        public long? PauseTime { get; set; }

        /// <summary>
        /// <para>The prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试提示词</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The qualification ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para>The qualification name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试质检</para>
        /// </summary>
        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        /// <summary>
        /// <para>The URL of the recording audio file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxxxxxxxxx.wav">https://xxxxxxxxxxxxxxx.wav</a></para>
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
        /// <para>The maximum call duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public long? SessionTimeout { get; set; }

        /// <summary>
        /// <para>The source. Fixed value: USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The speech script content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试话术</para>
        /// </summary>
        [NameInMap("SpeechContent")]
        [Validation(Required=false)]
        public string SpeechContent { get; set; }

        /// <summary>
        /// <para>The speech script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SpeechId")]
        [Validation(Required=false)]
        public long? SpeechId { get; set; }

        /// <summary>
        /// <para>The opening statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好，这是个测试开场白</para>
        /// </summary>
        [NameInMap("StartWord")]
        [Validation(Required=false)]
        public string StartWord { get; set; }

        /// <summary>
        /// <para>The type of the opening statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0：文本
        /// 1：录音</para>
        /// </summary>
        [NameInMap("StartWordType")]
        [Validation(Required=false)]
        public long? StartWordType { get; set; }

        /// <summary>
        /// <para>The text-to-speech (TTS) configuration, including voice, volume, and speed.</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public UpdateModelApplicationRequestTtsConfig TtsConfig { get; set; }
        public class UpdateModelApplicationRequestTtsConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable background sound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BackgroundEnabled")]
            [Validation(Required=false)]
            public bool? BackgroundEnabled { get; set; }

            /// <summary>
            /// <para>The background sound ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("BackgroundSound")]
            [Validation(Required=false)]
            public long? BackgroundSound { get; set; }

            /// <summary>
            /// <para>The background sound volume. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: low</description></item>
            /// <item><description>1: medium</description></item>
            /// <item><description>2: high</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BackgroundVolume")]
            [Validation(Required=false)]
            public long? BackgroundVolume { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("CustomerAccountId")]
            [Validation(Required=false)]
            public long? CustomerAccountId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable audio mixing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MixingEnabled")]
            [Validation(Required=false)]
            public bool? MixingEnabled { get; set; }

            /// <summary>
            /// <para>The mixing template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("MixingTemplate")]
            [Validation(Required=false)]
            public long? MixingTemplate { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The speed for TTS variable playback. Valid values: -200 to 200. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TtsSpeed")]
            [Validation(Required=false)]
            public long? TtsSpeed { get; set; }

            /// <summary>
            /// <para>The voice style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>voice</para>
            /// </summary>
            [NameInMap("TtsStyle")]
            [Validation(Required=false)]
            public string TtsStyle { get; set; }

            /// <summary>
            /// <para>The volume for TTS variable playback. Valid values: 0 to 100. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TtsVolume")]
            [Validation(Required=false)]
            public long? TtsVolume { get; set; }

            /// <summary>
            /// <para>The voice code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12123213123</para>
            /// </summary>
            [NameInMap("VoiceCode")]
            [Validation(Required=false)]
            public string VoiceCode { get; set; }

            /// <summary>
            /// <para>The voice type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: system voice</description></item>
            /// <item><description>COSYCLONE: cloned voice</description></item>
            /// <item><description>BL-CUSTOM: custom premium cloned voice</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("VoiceType")]
            [Validation(Required=false)]
            public string VoiceType { get; set; }

        }

        /// <summary>
        /// <para>The usage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试用途</para>
        /// </summary>
        [NameInMap("UsageDesc")]
        [Validation(Required=false)]
        public string UsageDesc { get; set; }

    }

}
