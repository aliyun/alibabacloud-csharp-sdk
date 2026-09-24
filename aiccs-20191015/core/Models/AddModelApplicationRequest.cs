// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddModelApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The number of concurrent requests for the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("ApplicationCps")]
        [Validation(Required=false)]
        public long? ApplicationCps { get; set; }

        /// <summary>
        /// <para>The name of the model application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestApplication</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

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
        /// <para>The scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestScenario</para>
        /// </summary>
        [NameInMap("DyvmsSceneName")]
        [Validation(Required=false)]
        public string DyvmsSceneName { get; set; }

        /// <summary>
        /// <para>The model code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("MuteActive")]
        [Validation(Required=false)]
        public bool? MuteActive { get; set; }

        /// <summary>
        /// <para>The mute duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MuteDuration")]
        [Validation(Required=false)]
        public long? MuteDuration { get; set; }

        /// <summary>
        /// <para>The number of consecutive mute events before the system proactively hangs up the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MuteHangupNum")]
        [Validation(Required=false)]
        public long? MuteHangupNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test prompt</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The qualification ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para>The qualification name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestQualification</para>
        /// </summary>
        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        /// <summary>
        /// <para>The URL of the recorded audio file for the opening statement. This parameter is required when the opening statement type is set to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxx.wav">https://xxxxxxxx.wav</a></para>
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
        /// <para>Test speech script</para>
        /// </summary>
        [NameInMap("SpeechContent")]
        [Validation(Required=false)]
        public string SpeechContent { get; set; }

        /// <summary>
        /// <para>The speech script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88</para>
        /// </summary>
        [NameInMap("SpeechId")]
        [Validation(Required=false)]
        public long? SpeechId { get; set; }

        /// <summary>
        /// <para>The opening statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello, this is an opening statement</para>
        /// </summary>
        [NameInMap("StartWord")]
        [Validation(Required=false)]
        public string StartWord { get; set; }

        /// <summary>
        /// <para>The type of the opening statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartWordType")]
        [Validation(Required=false)]
        public long? StartWordType { get; set; }

        /// <summary>
        /// <para>The text-to-speech (TTS) configuration, including voice, volume, and speed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public AddModelApplicationRequestTtsConfig TtsConfig { get; set; }
        public class AddModelApplicationRequestTtsConfig : TeaModel {
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
            /// <para>The background sound volume.</para>
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
            /// <para>45</para>
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
            /// <para>example</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The speed for TTS variable playback. Valid values: -200 to 200. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TtsSpeed")]
            [Validation(Required=false)]
            public long? TtsSpeed { get; set; }

            /// <summary>
            /// <para>The voice style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>龙小夏</para>
            /// </summary>
            [NameInMap("TtsStyle")]
            [Validation(Required=false)]
            public string TtsStyle { get; set; }

            /// <summary>
            /// <para>The volume for TTS variable playback. Valid values: 0 to 100. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TtsVolume")]
            [Validation(Required=false)]
            public long? TtsVolume { get; set; }

            /// <summary>
            /// <para>The voice code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddddfd</para>
            /// </summary>
            [NameInMap("VoiceCode")]
            [Validation(Required=false)]
            public string VoiceCode { get; set; }

            /// <summary>
            /// <para>The voice type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: system voice.</description></item>
            /// <item><description>COSYCLONE: cloned voice.</description></item>
            /// <item><description>BL-CUSTOM: custom premium cloned voice.</description></item>
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
        /// <para>TestUsage</para>
        /// </summary>
        [NameInMap("UsageDesc")]
        [Validation(Required=false)]
        public string UsageDesc { get; set; }

    }

}
