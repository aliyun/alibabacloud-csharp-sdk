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
        /// <para>Specifies whether to hang up the call when a call assistant is detected.</para>
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
        /// <para>Specifies whether to trigger the model immediately after the call is connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CallConnectedTriggerModel")]
        [Validation(Required=false)]
        public bool? CallConnectedTriggerModel { get; set; }

        /// <summary>
        /// <para>The allowed DTMF digits, specified as a comma-separated string such as <c>1,2,3</c>. You can specify a maximum of 20 digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfAllowedDigits")]
        [Validation(Required=false)]
        public string DtmfAllowedDigits { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically validate the DTMF digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DtmfAutoValidateEnable")]
        [Validation(Required=false)]
        public bool? DtmfAutoValidateEnable { get; set; }

        /// <summary>
        /// <para>The number of DTMF digits to collect. The value must be between 1 and 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfDigitCount")]
        [Validation(Required=false)]
        public long? DtmfDigitCount { get; set; }

        /// <summary>
        /// <para>The timeout for DTMF input, in seconds. The value must be between 1 and 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfInputTimeout")]
        [Validation(Required=false)]
        public long? DtmfInputTimeout { get; set; }

        /// <summary>
        /// <para>The action to take when the input is outside the allowed range. Valid values: <c>RETURN_MODEL</c> and <c>AUTO_RETRY</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RETURN_MODEL</para>
        /// </summary>
        [NameInMap("DtmfOutOfRangeAction")]
        [Validation(Required=false)]
        public string DtmfOutOfRangeAction { get; set; }

        /// <summary>
        /// <para>The number of retry attempts. The value must be between 1 and 3. This parameter is effective only when <c>DtmfOutOfRangeAction</c> is set to <c>AUTO_RETRY</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DtmfRetryPlayTimes")]
        [Validation(Required=false)]
        public long? DtmfRetryPlayTimes { get; set; }

        /// <summary>
        /// <para>The custom text for the retry prompt. The text can contain a maximum of 50 characters. If this parameter is empty, the system uses the default prompt: &quot;Invalid input. Please try again.&quot;</para>
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
        /// <para>The scene name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试场景</para>
        /// </summary>
        [NameInMap("DyvmsSceneName")]
        [Validation(Required=false)]
        public string DyvmsSceneName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the collection of DTMF signals. The default value is <c>false</c>.</para>
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
        /// <para>Specifies whether to enable the Morse code configuration. The default value is <c>false</c>.</para>
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
            /// <para>The configuration to prevent consecutive barge-ins.</para>
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
                /// <para>The interruption protection duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16.417547</para>
                /// </summary>
                [NameInMap("InterruptProtectDuration")]
                [Validation(Required=false)]
                public double? InterruptProtectDuration { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to prevent consecutive barge-ins.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAvoidInterrupt")]
            [Validation(Required=false)]
            public bool? EnableAvoidInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the backchannel configuration for interruptions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableInterruptBackchannel")]
            [Validation(Required=false)]
            public bool? EnableInterruptBackchannel { get; set; }

            /// <summary>
            /// <para>Specifies whether to make the entire opening statement non-interruptible.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStartwordEntireNotInterrupt")]
            [Validation(Required=false)]
            public bool? EnableStartwordEntireNotInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether to make the opening statement non-interruptible.</para>
            /// </summary>
            [NameInMap("EnableStartwordNotInterrupt")]
            [Validation(Required=false)]
            public bool? EnableStartwordNotInterrupt { get; set; }

            /// <summary>
            /// <para>The protection duration for the opening statement, in seconds.</para>
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
        /// <para>The number of consecutive mute events that trigger an automatic hang-up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MuteHangupNum")]
        [Validation(Required=false)]
        public long? MuteHangupNum { get; set; }

        /// <summary>
        /// <para>静音事件推送模式</para>
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
        /// <para>The name of the qualification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试质检</para>
        /// </summary>
        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        /// <summary>
        /// <para>The URL of the recording file.</para>
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
        /// <para>The session timeout, which is the maximum duration of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public long? SessionTimeout { get; set; }

        /// <summary>
        /// <para>The value must be <c>USER</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The content of the speech.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试话术</para>
        /// </summary>
        [NameInMap("SpeechContent")]
        [Validation(Required=false)]
        public string SpeechContent { get; set; }

        /// <summary>
        /// <para>The speech ID.</para>
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
        /// <para>The type of the opening statement. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>0：文本
        /// 1：录音</para>
        /// </summary>
        [NameInMap("StartWordType")]
        [Validation(Required=false)]
        public long? StartWordType { get; set; }

        /// <summary>
        /// <para>The TTS configuration, such as voice, volume, and speech rate.</para>
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
            /// <para>The volume of the background sound. Valid values: <c>0</c> (low), <c>1</c> (medium), and <c>2</c> (high).</para>
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
            /// <para>The TTS playback speech rate. Valid values range from -200 to 200. The default value is 0.</para>
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
            /// <para>The TTS playback volume. Valid values range from 0 to 100. The default value is 0.</para>
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
            /// <pre><c>SYSTEM: System voice.
            /// COSYCLONE: Cloned voice.
            /// BL-CUSTOM: Premium custom-cloned voice.
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("VoiceType")]
            [Validation(Required=false)]
            public string VoiceType { get; set; }

        }

        /// <summary>
        /// <para>The purpose of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试用途</para>
        /// </summary>
        [NameInMap("UsageDesc")]
        [Validation(Required=false)]
        public string UsageDesc { get; set; }

    }

}
