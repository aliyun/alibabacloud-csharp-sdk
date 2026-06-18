// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddModelApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of concurrent requests per second (CPS).</para>
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
        /// <para>测试应用</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>Specifies whether to push an event notification when a call is connected. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CallConnectedTriggerModel")]
        [Validation(Required=false)]
        public bool? CallConnectedTriggerModel { get; set; }

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
        /// <para>The number of consecutive mute events that trigger an automatic hang-up.</para>
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
        /// <para>测试提示词。</para>
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
        /// <para>The name of the qualification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试资质</para>
        /// </summary>
        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        /// <summary>
        /// <para>The URL of the audio file for the opening line. This parameter is required if <c>StartWordType</c> is set to <c>1</c>.</para>
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
        /// <para>The source. The value must be <c>USER</c>.</para>
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
        /// <para>测试话术。</para>
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
        /// <para>The opening line.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好，这是一句开场白。</para>
        /// </summary>
        [NameInMap("StartWord")]
        [Validation(Required=false)]
        public string StartWord { get; set; }

        /// <summary>
        /// <para>The type of the opening line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0：文本
        /// 1：录音</para>
        /// </summary>
        [NameInMap("StartWordType")]
        [Validation(Required=false)]
        public long? StartWordType { get; set; }

        /// <summary>
        /// <para>The TTS configuration, including voice, volume, speech speed, and more.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public string TtsConfigShrink { get; set; }

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
