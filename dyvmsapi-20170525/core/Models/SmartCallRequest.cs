// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SmartCallRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the playback of the recording file can be interrupted. Default value: <b>true</b>. The default value indicates that the playback of the recording file can be interrupted.</para>
        /// <para>If you set the value of this parameter to false, the playback of the recording file cannot be interrupted even if the value of action_break is set to true.</para>
        /// <remarks>
        /// <para>The value of action_code_break takes precedence over the value of action_break.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ActionCodeBreak")]
        [Validation(Required=false)]
        public bool? ActionCodeBreak { get; set; }

        /// <summary>
        /// <para>The duration that the user keeps speaking. The playback of the recording file is interrupted when this duration is reached. Unit: milliseconds.</para>
        /// <para>If the value of ActionCodeBreak is set to <b>true</b> for the recording file and the duration that the user keeps speaking reaches the specified duration, the playback of the recording file is interrupted. If you do not specify ActionCodeTimeBreak or set the value of ActionCodeTimeBreak to 0, the setting of ActionCodeBreak does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("ActionCodeTimeBreak")]
        [Validation(Required=false)]
        public int? ActionCodeTimeBreak { get; set; }

        /// <summary>
        /// <para>The ASR base model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>customer_service_8k</b> (default): Chinese Mandarin.</description></item>
        /// <item><description><b>dialect_customer_service_8k</b>: a heavy accent.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify the ASR model when you call the SmartCall operation. We recommend that you specify either of the AsrModelId and AsrBaseId parameters.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify only the AsrModelId parameter, the specified ASR model is used.</para>
        /// </description></item>
        /// <item><description><para>If you specify only the AsrBaseId parameter, the ASR base model is used.</para>
        /// </description></item>
        /// <item><description><para>If you specify neither of the two parameters, the default ASR base model is used, that is, the default value customer_service_8k is used for the AsrBaseId parameter.</para>
        /// </description></item>
        /// <item><description><para>If you specify both parameters, make sure that their values do not conflict with each other.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customer_service_8k</para>
        /// </summary>
        [NameInMap("AsrBaseId")]
        [Validation(Required=false)]
        public string AsrBaseId { get; set; }

        /// <summary>
        /// <para>The ID of the Automatic Speech Recognition (ASR) model.</para>
        /// <para>You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a> and view the ID of the ASR model on the <b>ASR Model Management</b> page.</para>
        /// <remarks>
        /// <para>You must specify the ASR model when you call the SmartCall operation. We recommend that you specify either of the AsrModelId and AsrBaseId parameters.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify only the AsrModelId parameter, the specified ASR model is used.</para>
        /// </description></item>
        /// <item><description><para>If you specify only the AsrBaseId parameter, the specified ASR base model is used.</para>
        /// </description></item>
        /// <item><description><para>If you specify neither of the two parameters, the default value customer_service_8k is used for the AsrBaseId parameter. This means that the default Mandarin ASR base model is used.</para>
        /// </description></item>
        /// <item><description><para>If you specify both parameters, make sure that their values do not conflict with each other.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2070aca1eff146f9a7bc826f1c3d****</para>
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <para>The ID of the background voice file that is played back when the user talks with the robot.</para>
        /// <para>You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice File Management</b>, click the <b>Intelligent Speech Interaction Recording File</b> tab, and then click <b>Details</b> in the Actions column to view the voice ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d4c-4e78-8d2a-afbb06cf****.wav</para>
        /// </summary>
        [NameInMap("BackgroundFileCode")]
        [Validation(Required=false)]
        public string BackgroundFileCode { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundSpeed")]
        [Validation(Required=false)]
        public int? BackgroundSpeed { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundVolume")]
        [Validation(Required=false)]
        public int? BackgroundVolume { get; set; }

        /// <summary>
        /// <para>The called number. Only phone numbers in the Chinese mainland are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1590****0000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The number displayed to the called party. The value must be the number you purchased.</para>
        /// <para>You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a> and choose <b>Voice Numbers</b> &gt; <b>Real Number Management</b> to view the number you purchased.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571****5678</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>The dynamic extension ID that is reserved for the caller of the operation. This ID is returned in the callback URL and is used as the development identifier of the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdefgh</para>
        /// </summary>
        [NameInMap("DynamicId")]
        [Validation(Required=false)]
        public string DynamicId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable speech recognition of early media. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Speech recognition of early media is disabled.</description></item>
        /// <item><description><b>true</b>: Speech recognition of early media is enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set the value of this parameter to <b>true</b>, the reason why the call is not answered is recorded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Inverse Text Normalization (ITN) during post-processing. Default value: <b>false</b>. If you set the value to false, ITN is not enabled during post-processing.</para>
        /// <para>If you set the value to <b>true</b>, Chinese numerals are converted into Arabic numerals for output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableITN")]
        [Validation(Required=false)]
        public bool? EnableITN { get; set; }

        /// <summary>
        /// <para>The silence duration. The system determines the end of the conversation based on the silence duration of the user. Unit: milliseconds. Valid values: 1000 to 20000.****</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify a value out of the valid range, the default value <b>10000</b> is used.</para>
        /// </description></item>
        /// <item><description><para>The parameter value can be adjusted during the conversation. The last setting prevails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        [NameInMap("NoiseThreshold")]
        [Validation(Required=false)]
        public double? NoiseThreshold { get; set; }

        /// <summary>
        /// <para>The ID that is reserved for the caller of the operation. This ID is returned to the caller in a receipt message.</para>
        /// <para>The value is of the STRING type and must be 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>342268*****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The pause duration. The system determines the end of a sentence based on the pause duration of the user in the conversation. Unit: milliseconds. Valid values: 300 to 1200.****</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify a value out of the valid range, the default value <b>800</b> is used.</para>
        /// </description></item>
        /// <item><description><para>You cannot change the parameter value after specifying it.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("PauseTime")]
        [Validation(Required=false)]
        public int? PauseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to record the conversation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The conversation is recorded.</description></item>
        /// <item><description><b>false</b>: The conversation is not recorded.</description></item>
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
        /// <para>The maximum call duration. The call is automatically hung up when the maximum call duration is reached. Unit: seconds.</para>
        /// <remarks>
        /// <para>The maximum call duration is 3,600 seconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable streaming ASR, which intelligently judges what the user wants to express based on the first few words spoken by the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Streaming ASR is disabled.</description></item>
        /// <item><description><b>1</b>: Streaming ASR is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StreamAsr")]
        [Validation(Required=false)]
        public int? StreamAsr { get; set; }

        /// <summary>
        /// <para>Specifies whether to set TTS sound parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: TTS sound parameters must be set. You must set the <b>TtsStyle</b>, <b>TtsColume</b>, and <b>TtsSpeed</b> parameters to specify a sound style.</description></item>
        /// <item><description><b>false</b>: TTS sound parameters do not need to be set. The values of TTS sound parameters do not take effect even if you set them.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TtsConf")]
        [Validation(Required=false)]
        public bool? TtsConf { get; set; }

        /// <summary>
        /// <para>The speed of TTS variable playback. Valid values: -200 to 200. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        /// <summary>
        /// <para>The sound style for TTS variable playback. Default value: <b>xiaoyun</b>. For more information about the sound styles, see the <b>Sound styles</b> table below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoyun</para>
        /// </summary>
        [NameInMap("TtsStyle")]
        [Validation(Required=false)]
        public string TtsStyle { get; set; }

        /// <summary>
        /// <para>The volume of TTS variable playback. Valid values: 0 to 100. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

        /// <summary>
        /// <para>The recording file that is played back in the intelligent outbound call.</para>
        /// <para>The file can be an online file, a voice file uploaded from the Voice Messaging Service console, or a text-to-speech (TTS) template that contains variables. You can specify multiple files and a TTS variable together. Separate them with commas (,). The values of the variables in the TTS template are specified by the <b>VoiceCodeParam</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If you use an online file as the recording file, set the value of <b>VoiceCode</b> to the URL of the file that can be accessed over the Internet.</description></item>
        /// <item><description>If you use a voice file uploaded from the Voice Messaging Service console as the recording file, set the value of <b>VoiceCode</b> to the voice ID of the file. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice File Management</b>, click the <b>Intelligent Speech Interaction Recording File</b> tab, and then click <b>Details</b> in the Actions column to view the voice ID.</description></item>
        /// <item><description>If you use a TTS template that contains variables as the recording file, set the value of <b>VoiceCode</b> to a variable name such as $name$, and also set a value for the variable in the <b>VoiceCodeParam</b> parameter.</description></item>
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
        /// <para>The value of the TTS variable, in the JSON format. This value must match the TTS variable specified by the <b>VoiceCode</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;hello&quot;}</para>
        /// </summary>
        [NameInMap("VoiceCodeParam")]
        [Validation(Required=false)]
        public string VoiceCodeParam { get; set; }

        /// <summary>
        /// <para>The volume at which the recording file is played. Valid values: -4 to 4. We recommend that you set the value of this parameter to <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
