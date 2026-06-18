// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AiccsSmartCallRequest : TeaModel {
        /// <summary>
        /// <para>Whether the initial audio playback file is interruptible. The default value is <b>true</b>, which means the initial audio playback file can be interrupted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ActionCodeBreak")]
        [Validation(Required=false)]
        public bool? ActionCodeBreak { get; set; }

        /// <summary>
        /// <para>Interrupts based on the user\&quot;s continuous speaking duration. Takes effect only when ActionCodeBreak is <b>true</b>. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("ActionCodeTimeBreak")]
        [Validation(Required=false)]
        public int? ActionCodeTimeBreak { get; set; }

        /// <summary>
        /// <para>Acoustic model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23387****</para>
        /// </summary>
        [NameInMap("AsrAlsAmId")]
        [Validation(Required=false)]
        public string AsrAlsAmId { get; set; }

        /// <summary>
        /// <para>ASR foundation model.</para>
        /// <list type="bullet">
        /// <item><description><b>customer_service_8k</b>: Mandarin.</description></item>
        /// <item><description><b>dialect_customer_service_8k</b>: Heavy accent.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When invoking the <b>SendCcoSmartCall</b> API, you must specify an ASR model. We recommend that you provide either the <b>asrModelId</b> or <b>AsrBaseId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If only <b>asrModelId</b> is set, the specified ASR model is used.</description></item>
        /// <item><description>If only <b>AsrBaseId</b> is set, the specified ASR foundation model is used.</description></item>
        /// <item><description>If neither parameter is set, the default ASR foundation model is used. By default, <b>AsrBaseId</b> is <b>customer_service_8k</b>, which corresponds to the Mandarin ASR foundation model.</description></item>
        /// <item><description>If both parameters are set, confirm that they correctly correspond to each other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customer_service_8k</para>
        /// </summary>
        [NameInMap("AsrBaseId")]
        [Validation(Required=false)]
        public string AsrBaseId { get; set; }

        /// <summary>
        /// <para>ASR model ID. You can view the ASR model ID on the <a href="https://aiccs.console.aliyun.com/sentence/model/private?spm=a2c4g.11186623.0.0.7f9b2964fYSGv4">ASR Model Management page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bf71664d30d2478fb8cb8c39c6b6****</para>
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <para>Hotword ID. You can view the ASR hotword ID on the <a href="https://aiccs.console.aliyun.com/sentence/vocab?spm=a2c4g.11186623.0.0.7f9bf965IKBpsi">ASR Hotword Management Page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6689****</para>
        /// </summary>
        [NameInMap("AsrVocabularyId")]
        [Validation(Required=false)]
        public string AsrVocabularyId { get; set; }

        /// <summary>
        /// <para>ID of the background audio file played during the conversation between the user and the robot.  </para>
        /// <para>You can log on to the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>, choose <b>Intelligent Interaction &gt; Audio File Management</b>, and click <b>View</b> to check the corresponding audio ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d4c-4e78-8d2a-afbb06cf****.wav</para>
        /// </summary>
        [NameInMap("BackgroundFileCode")]
        [Validation(Required=false)]
        public string BackgroundFileCode { get; set; }

        /// <summary>
        /// <para>This parameter is currently not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundSpeed")]
        [Validation(Required=false)]
        public int? BackgroundSpeed { get; set; }

        /// <summary>
        /// <para>The parameter is not supported yet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundVolume")]
        [Validation(Required=false)]
        public int? BackgroundVolume { get; set; }

        /// <summary>
        /// <para>Called number. Only numbers in the Chinese mainland are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1862222****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The caller ID displayed to the callee. This must be a number you have purchased.</para>
        /// <para>You can log on to the <a href="https://aiccs.console.aliyun.com/overview?spm=a2c4g.11186623.0.0.7f9bf9658X6jte">Contact Center console</a> to view your purchased numbers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571000****</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>A dynamic extension ID reserved for the caller, which is returned in the webhook address to serve as the customer\&quot;s developer identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2234****</para>
        /// </summary>
        [NameInMap("DynamicId")]
        [Validation(Required=false)]
        public string DynamicId { get; set; }

        /// <summary>
        /// <para>Early media speech recognition identity. When set to <b>true</b>, it records the reason why the call was not answered. Default value: <b>false</b>, meaning disabled.</para>
        /// <remarks>
        /// <para>To enable early media speech recognition, you must manually set this parameter to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fasle</para>
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// <para>Whether to execute ITN during post-processing.  </para>
        /// <remarks>
        /// <para>When set to <b>true</b>, Chinese numerals are converted to Arabic numerals in the output. The default value is <b>false</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableITN")]
        [Validation(Required=false)]
        public bool? EnableITN { get; set; }

        /// <summary>
        /// <para>Silence duration. This parameter defines how long the call waits for user speech before ending the call. The unit is milliseconds, and valid values range from <b>1000 to 20000</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the specified value is outside this range, <b>MuteTime</b> defaults to <b>10000</b>.</description></item>
        /// <item><description>This parameter can be dynamically updated during the call. The last set value takes effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        /// <summary>
        /// <para>An ID reserved for the caller. This ID will be returned to the caller in the receipt message.<br>It is a string with a length of 1 to 15 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222356****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Pause duration. Specifies how long the user must pause to indicate the end of a sentence. Unit: milliseconds. Valid range: <b>300–1200</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the specified value is outside this range, PauseTime defaults to <b>800</b>.</description></item>
        /// <item><description>Only the first setting takes effect; subsequent settings are ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("PauseTime")]
        [Validation(Required=false)]
        public int? PauseTime { get; set; }

        /// <summary>
        /// <para>The parameter is not supported yet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public int? PlayTimes { get; set; }

        /// <summary>
        /// <para>Product name. Default value: <b>aiccs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aiccs</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>Whether to record during the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecordFlag")]
        [Validation(Required=false)]
        public bool? RecordFlag { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Maximum call duration, in seconds. The call is automatically disconnected after timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>This parameter is not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// <para>Whether to configure TTS voice parameters.</para>
        /// <list type="bullet">
        /// <item><description>If set to <b>true</b>, you must use the TtsStyle, TtsVolume, and TtsSpeed parameters to define the voice style.</description></item>
        /// <item><description>If set to <b>false</b>, related parameters are not required and will have no effect even if configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TtsConf")]
        [Validation(Required=false)]
        public bool? TtsConf { get; set; }

        /// <summary>
        /// <para>Speech speed when playing TTS variables. Valid values range from <b>-200 to 200</b>. The default value is <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        /// <summary>
        /// <para>Voice style used during TTS variable playback. Default value: <b>xiaoyun</b>. For available styles, see the voice style list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoyun</para>
        /// </summary>
        [NameInMap("TtsStyle")]
        [Validation(Required=false)]
        public string TtsStyle { get; set; }

        /// <summary>
        /// <para>The volume for TTS variable playback. Valid values range from <b>0 to 100</b>. The default value is <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

        /// <summary>
        /// <para>The Intelligent Outbound Call playback audio file supports both network files and TTS. Multiple files and TTS parameters can be mixed for playback, separated by commas (,). The replacement values for TTS parameters are specified in <b>VoiceCodeParam</b>.</para>
        /// <list type="bullet">
        /// <item><description>When the playback file is a network file: Set the VoiceCode parameter to a publicly accessible URL of the audio file. We recommend using a WAV-formatted audio file with a sampling frequency of 8000 Hz or 16000 Hz.</description></item>
        /// <item><description>When the playback file uses TTS: Set the VoiceCode parameter to a variable name such as $name$, and define the corresponding content for this variable in VoiceCodeParam.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d4c-4e78-8d2a-afbb06cf****.wav,$name$</para>
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// <para>TTS parameter string in JSON format. It must correspond to the TTS parameters of VoiceCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“{\”name\”:\”喂，你好\”}”</para>
        /// </summary>
        [NameInMap("VoiceCodeParam")]
        [Validation(Required=false)]
        public string VoiceCodeParam { get; set; }

        /// <summary>
        /// <para>The volume for playing user audio. Valid values range from <b>-4 to 4</b>. We recommend setting it to <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
