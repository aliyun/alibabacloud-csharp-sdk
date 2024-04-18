// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SmartCallRequest : TeaModel {
        /// <summary>
        /// Specifies whether the playback of the recording file can be interrupted. Default value: **true**. The default value indicates that the playback of the recording file can be interrupted.
        /// 
        /// If you set the value of this parameter to false, the playback of the recording file cannot be interrupted even if the value of action_break is set to true.
        /// 
        /// > The value of action_code_break takes precedence over the value of action_break.
        /// </summary>
        [NameInMap("ActionCodeBreak")]
        [Validation(Required=false)]
        public bool? ActionCodeBreak { get; set; }

        /// <summary>
        /// The duration that the user keeps speaking. The playback of the recording file is interrupted when this duration is reached. Unit: milliseconds.
        /// 
        /// If the value of ActionCodeBreak is set to **true** for the recording file and the duration that the user keeps speaking reaches the specified duration, the playback of the recording file is interrupted. If you do not specify ActionCodeTimeBreak or set the value of ActionCodeTimeBreak to 0, the setting of ActionCodeBreak does not take effect.
        /// </summary>
        [NameInMap("ActionCodeTimeBreak")]
        [Validation(Required=false)]
        public int? ActionCodeTimeBreak { get; set; }

        /// <summary>
        /// The ASR base model. Valid values:
        /// 
        /// *   **customer_service\_8k** (default): Chinese Mandarin.
        /// *   **dialect_customer_service\_8k**: a heavy accent.
        /// 
        /// > You must specify the ASR model when you call the SmartCall operation. We recommend that you specify either of the AsrModelId and AsrBaseId parameters.
        /// 
        /// *   If you specify only the AsrModelId parameter, the specified ASR model is used.
        /// 
        /// *   If you specify only the AsrBaseId parameter, the ASR base model is used.
        /// 
        /// *   If you specify neither of the two parameters, the default ASR base model is used, that is, the default value customer_service\_8k is used for the AsrBaseId parameter.
        /// 
        /// *   If you specify both parameters, make sure that their values do not conflict with each other.
        /// </summary>
        [NameInMap("AsrBaseId")]
        [Validation(Required=false)]
        public string AsrBaseId { get; set; }

        /// <summary>
        /// The ID of the Automatic Speech Recognition (ASR) model.
        /// 
        /// You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home) and view the ID of the ASR model on the **ASR Model Management** page.
        /// 
        /// > You must specify the ASR model when you call the SmartCall operation. We recommend that you specify either of the AsrModelId and AsrBaseId parameters.
        /// 
        /// *   If you specify only the AsrModelId parameter, the specified ASR model is used.
        /// 
        /// *   If you specify only the AsrBaseId parameter, the specified ASR base model is used.
        /// 
        /// *   If you specify neither of the two parameters, the default value customer_service\_8k is used for the AsrBaseId parameter. This means that the default Mandarin ASR base model is used.
        /// 
        /// *   If you specify both parameters, make sure that their values do not conflict with each other.
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// The ID of the background voice file that is played back when the user talks with the robot.
        /// 
        /// You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice File Management**, click the **Intelligent Speech Interaction Recording File** tab, and then click **Details** in the Actions column to view the voice ID.
        /// </summary>
        [NameInMap("BackgroundFileCode")]
        [Validation(Required=false)]
        public string BackgroundFileCode { get; set; }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("BackgroundSpeed")]
        [Validation(Required=false)]
        public int? BackgroundSpeed { get; set; }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("BackgroundVolume")]
        [Validation(Required=false)]
        public int? BackgroundVolume { get; set; }

        /// <summary>
        /// The called number. Only phone numbers in the Chinese mainland are supported.
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// The number displayed to the called party. The value must be the number you purchased.
        /// 
        /// You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home) and choose **Voice Numbers** > **Real Number Management** to view the number you purchased.
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// The dynamic extension ID that is reserved for the caller of the operation. This ID is returned in the callback URL and is used as the development identifier of the customer.
        /// </summary>
        [NameInMap("DynamicId")]
        [Validation(Required=false)]
        public string DynamicId { get; set; }

        /// <summary>
        /// Specifies whether to enable speech recognition of early media. Valid values:
        /// 
        /// *   **false** (default): Speech recognition of early media is disabled.
        /// *   **true**: Speech recognition of early media is enabled.
        /// 
        /// > If you set the value of this parameter to **true**, the reason why the call is not answered is recorded.
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// Specifies whether to enable Inverse Text Normalization (ITN) during post-processing. Default value: **false**. If you set the value to false, ITN is not enabled during post-processing.
        /// 
        /// If you set the value to **true**, Chinese numerals are converted into Arabic numerals for output.
        /// </summary>
        [NameInMap("EnableITN")]
        [Validation(Required=false)]
        public bool? EnableITN { get; set; }

        /// <summary>
        /// The silence duration. The system determines the end of the conversation based on the silence duration of the user. Unit: milliseconds. Valid values: 1000 to 20000.****
        /// 
        /// > 
        /// 
        /// *   If you specify a value out of the valid range, the default value **10000** is used.
        /// 
        /// *   The parameter value can be adjusted during the conversation. The last setting prevails.
        /// </summary>
        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        [NameInMap("NoiseThreshold")]
        [Validation(Required=false)]
        public double? NoiseThreshold { get; set; }

        /// <summary>
        /// The ID that is reserved for the caller of the operation. This ID is returned to the caller in a receipt message.
        /// 
        /// The value is of the STRING type and must be 1 to 15 bytes in length.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The pause duration. The system determines the end of a sentence based on the pause duration of the user in the conversation. Unit: milliseconds. Valid values: 300 to 1200.****
        /// 
        /// > 
        /// 
        /// *   If you specify a value out of the valid range, the default value **800** is used.
        /// 
        /// *   You cannot change the parameter value after specifying it.
        /// </summary>
        [NameInMap("PauseTime")]
        [Validation(Required=false)]
        public int? PauseTime { get; set; }

        /// <summary>
        /// Specifies whether to record the conversation. Valid values:
        /// 
        /// *   **true**: The conversation is recorded.
        /// *   **false**: The conversation is not recorded.
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
        /// The maximum call duration. The call is automatically hung up when the maximum call duration is reached. Unit: seconds.
        /// 
        /// > The maximum call duration is 3,600 seconds.
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// Specifies whether to enable streaming ASR, which intelligently judges what the user wants to express based on the first few words spoken by the user. Valid values:
        /// 
        /// *   **0**: Streaming ASR is disabled.
        /// *   **1**: Streaming ASR is enabled.
        /// </summary>
        [NameInMap("StreamAsr")]
        [Validation(Required=false)]
        public int? StreamAsr { get; set; }

        /// <summary>
        /// Specifies whether to set TTS sound parameters. Valid values:
        /// 
        /// *   **true**: TTS sound parameters must be set. You must set the **TtsStyle**, **TtsColume**, and **TtsSpeed** parameters to specify a sound style.
        /// *   **false**: TTS sound parameters do not need to be set. The values of TTS sound parameters do not take effect even if you set them.
        /// </summary>
        [NameInMap("TtsConf")]
        [Validation(Required=false)]
        public bool? TtsConf { get; set; }

        /// <summary>
        /// The speed of TTS variable playback. Valid values: -200 to 200. Default value: 0.
        /// </summary>
        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        /// <summary>
        /// The sound style for TTS variable playback. Default value: **xiaoyun**. For more information about the sound styles, see the **Sound styles** table below.
        /// </summary>
        [NameInMap("TtsStyle")]
        [Validation(Required=false)]
        public string TtsStyle { get; set; }

        /// <summary>
        /// The volume of TTS variable playback. Valid values: 0 to 100. Default value: 0.
        /// </summary>
        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

        /// <summary>
        /// The recording file that is played back in the intelligent outbound call.
        /// 
        /// The file can be an online file, a voice file uploaded from the Voice Messaging Service console, or a text-to-speech (TTS) template that contains variables. You can specify multiple files and a TTS variable together. Separate them with commas (,). The values of the variables in the TTS template are specified by the **VoiceCodeParam** parameter.
        /// 
        /// *   If you use an online file as the recording file, set the value of **VoiceCode** to the URL of the file that can be accessed over the Internet.
        /// *   If you use a voice file uploaded from the Voice Messaging Service console as the recording file, set the value of **VoiceCode** to the voice ID of the file. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice File Management**, click the **Intelligent Speech Interaction Recording File** tab, and then click **Details** in the Actions column to view the voice ID.
        /// *   If you use a TTS template that contains variables as the recording file, set the value of **VoiceCode** to a variable name such as $name$, and also set a value for the variable in the **VoiceCodeParam** parameter.
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// The value of the TTS variable, in the JSON format. This value must match the TTS variable specified by the **VoiceCode** parameter.
        /// </summary>
        [NameInMap("VoiceCodeParam")]
        [Validation(Required=false)]
        public string VoiceCodeParam { get; set; }

        /// <summary>
        /// The volume at which the recording file is played. Valid values: -4 to 4. We recommend that you set the value of this parameter to **1**.
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
