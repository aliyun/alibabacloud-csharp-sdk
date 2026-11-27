// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class SendCcoSmartCallRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the opening audio file can be interrupted. Default value: <b>true</b>, which indicates that the opening audio file can be interrupted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ActionCodeBreak")]
        [Validation(Required=false)]
        public bool? ActionCodeBreak { get; set; }

        /// <summary>
        /// <para>The interruption based on the continuous speaking duration of the user. This parameter takes effect only when ActionCodeBreak is set to <b>true</b>. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("ActionCodeTimeBreak")]
        [Validation(Required=false)]
        public int? ActionCodeTimeBreak { get; set; }

        /// <summary>
        /// <para>The acoustic model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AsrAlsAmId")]
        [Validation(Required=false)]
        public string AsrAlsAmId { get; set; }

        /// <summary>
        /// <para>The ASR foundation model.</para>
        /// <list type="bullet">
        /// <item><description><b>customer_service_8k</b>: Mandarin.</description></item>
        /// <item><description><b>dialect_customer_service_8k</b>: Heavy accent.</description></item>
        /// <item><description>If only <b>asrModelId</b> is set, the specified ASR model is used.</description></item>
        /// <item><description>If only <b>AsrBaseId</b> is set, the specified ASR foundation model is used.</description></item>
        /// <item><description>If neither is set, the default ASR foundation model is used. The default value of <b>AsrBaseId</b> is <b>customer_service_8k</b>, which indicates the ASR Mandarin foundation model.</description></item>
        /// <item><description>If both are set, make sure that they correctly correspond to each other.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you call the <b>SendCcoSmartCall</b> operation, you must specify the ASR model to use. Specify either <b>asrModelId</b> or <b>AsrBaseId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>customer_service_8k</para>
        /// </summary>
        [NameInMap("AsrBaseId")]
        [Validation(Required=false)]
        public string AsrBaseId { get; set; }

        /// <summary>
        /// <para>The ASR model ID. You can view the ASR model ID on the <a href="https://aiccs.console.aliyun.com/sentence/model/private?spm=a2c4g.11186623.0.0.7f9b2964fYSGv4">ASR Model Management page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bf71664d30d2478fb8cb8c39c6b6****</para>
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <para>The hot word ID. You can view the ASR hot word ID on the <a href="https://aiccs.console.aliyun.com/sentence/vocab?spm=a2c4g.11186623.0.0.7f9bf965IKBpsi">ASR Hot Word Management page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AsrVocabularyId")]
        [Validation(Required=false)]
        public string AsrVocabularyId { get; set; }

        /// <summary>
        /// <para>The ID of the background audio file played when the user talks to the robot. You can log on to the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>, choose <b>Intelligent Interaction &gt; Audio File Management</b>, and click <b>Details</b> to view the corresponding audio ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d4c-4e78-8d2a-afbb06cf****.wav</para>
        /// </summary>
        [NameInMap("BackgroundFileCode")]
        [Validation(Required=false)]
        public string BackgroundFileCode { get; set; }

        /// <summary>
        /// <para>This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundSpeed")]
        [Validation(Required=false)]
        public int? BackgroundSpeed { get; set; }

        /// <summary>
        /// <para>This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundVolume")]
        [Validation(Required=false)]
        public int? BackgroundVolume { get; set; }

        /// <summary>
        /// <para>The called number. Only numbers in the Chinese mainland are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****0000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The called display number. It must be a purchased number.</para>
        /// <para>You can log on to the <a href="https://aiccs.console.aliyun.com/overview?spm=a2c4g.11186623.0.0.7f9bf9658X6jte">Cloud Call Center console</a> to view the purchased numbers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571****0000</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>The dynamic extension ID reserved for the caller. This ID is returned in the callback URL and used as a development identifier for the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DynamicId")]
        [Validation(Required=false)]
        public string DynamicId { get; set; }

        /// <summary>
        /// <para>The early media speech recognition identifier. If this parameter is set to true, the reason why the call is not answered is recorded. Default value: <b>false</b>, which indicates that this feature is disabled.</para>
        /// <remarks>
        /// <para>To enable the early media speech recognition identifier, manually set this parameter to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform ITN in post-processing.</para>
        /// <remarks>
        /// <para>If this parameter is set to <b>true</b>, Chinese numerals are converted to Arabic numerals in the output. Default value: <b>false</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableITN")]
        [Validation(Required=false)]
        public bool? EnableITN { get; set; }

        /// <summary>
        /// <para>The mute duration. This parameter specifies how long a user remains silent before the call ends. Unit: milliseconds. Valid values: <b>1000</b> to <b>20000</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the specified value is out of the range, the default value <b>10000</b> is used.</description></item>
        /// <item><description>This parameter can be dynamically set during the call. The last setting takes effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        /// <summary>
        /// <para>The ID reserved for the caller. This ID is returned to the caller in the receipt message.
        /// The value must be a string and 1 to 15 bytes in length.</para>
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
        /// <para>The pause duration. This parameter specifies how long a user pauses to indicate the end of a sentence. Unit: milliseconds. Valid values: <b>300</b> to <b>1200</b>. If the specified value is out of the range, the default value <b>800</b> is used.</para>
        /// <remarks>
        /// <para>Only the first setting takes effect. Subsequent settings are invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("PauseTime")]
        [Validation(Required=false)]
        public int? PauseTime { get; set; }

        /// <summary>
        /// <para>This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public int? PlayTimes { get; set; }

        /// <summary>
        /// <para>The product name. Default value: <b>aiccs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aiccs</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to record the call.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
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
        /// <para>The maximum call duration. Unit: seconds. The call is automatically hung up after the timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// <para>Specifies whether to set TTS voice parameters.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: You must set the voice style by using the TtsStyle, TtsVolume, and TtsSpeed parameters.</description></item>
        /// <item><description><b>false</b>: You do not need to set the related parameters. Even if they are set, they do not take effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TtsConf")]
        [Validation(Required=false)]
        public bool? TtsConf { get; set; }

        /// <summary>
        /// <para>The voice speed for playing TTS variables. Valid values: -200 to 200. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        /// <summary>
        /// <para>The voice style for playing TTS variables. Default value: <b>xiaoyun</b>. For more information about specific styles, see the voice style list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoyun</para>
        /// </summary>
        [NameInMap("TtsStyle")]
        [Validation(Required=false)]
        public string TtsStyle { get; set; }

        /// <summary>
        /// <para>The volume for playing TTS variables. Valid values: <b>0</b> to <b>100</b>. Default value: <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

        /// <summary>
        /// <para>The audio file for the intelligent outbound call. Network files and TTS are supported. You can mix multiple files and TTS parameters, separated by commas (,). The replacement values for TTS parameters are specified in <b>VoiceCodeParam</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the audio file is a network file: Set the VoiceCode parameter to the URL of an audio file that supports public network access. We recommend that you use an audio file in WAV format with a sampling frequency of 8,000 Hz or 16,000 Hz.</description></item>
        /// <item><description>If the audio file is TTS: Set the VoiceCode parameter to a variable name such as $name$, and set the content corresponding to the variable in the VoiceCodeParam Settings.</description></item>
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
        /// <para>The TTS parameter string in JSON format. It must correspond to the TTS parameters in VoiceCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Hello&quot;}</para>
        /// </summary>
        [NameInMap("VoiceCodeParam")]
        [Validation(Required=false)]
        public string VoiceCodeParam { get; set; }

        /// <summary>
        /// <para>The volume for playing user audio. Valid values: -4 to 4. Recommended value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
