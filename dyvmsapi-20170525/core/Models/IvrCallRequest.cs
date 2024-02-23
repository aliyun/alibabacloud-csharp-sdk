// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class IvrCallRequest : TeaModel {
        /// <summary>
        /// The end voice.
        /// 
        /// *   If you use a voice notification file, this parameter specifies the voice ID. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > **Voice Notifications**, and then click the **Voice Notification Files** tab to view the voice ID.
        /// *   If you use a TTS template, this parameter specifies the template ID. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > **Voice Notifications**, and then click the **TTS Template** tab to view the template ID.
        /// 
        /// > The value of the ByeCode parameter must be of the same type as the value of the StartCode parameter. This means that both parameters must specify voice IDs or TTS template IDs.
        /// </summary>
        [NameInMap("ByeCode")]
        [Validation(Required=false)]
        public string ByeCode { get; set; }

        /// <summary>
        /// The variables in the TTS template, in the JSON format.
        /// 
        /// > This parameter is required when the ByeCode parameter is set to the ID of a TTS template that contains variables.
        /// </summary>
        [NameInMap("ByeTtsParams")]
        [Validation(Required=false)]
        public string ByeTtsParams { get; set; }

        /// <summary>
        /// The called number.
        /// 
        /// Only phone numbers in the Chinese mainland are supported. Each request supports only one called number.
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// The calling number.
        /// 
        /// The value must be a number you purchased. Each request supports only one calling number. In most cases, a calling number is configured with the maximum number of concurrent requests. New requests fail if the maximum number of concurrent requests is reached. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home) and choose **Real Number Service > Real Number Management** to view the number you purchased.
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// The information about the key pressed by the subscriber.
        /// </summary>
        [NameInMap("MenuKeyMap")]
        [Validation(Required=false)]
        public List<IvrCallRequestMenuKeyMap> MenuKeyMap { get; set; }
        public class IvrCallRequestMenuKeyMap : TeaModel {
            /// <summary>
            /// The voice that corresponds to the key specified by the **MenuKeyMap.N.Key** parameter.
            /// 
            /// *   If you use a voice notification file, this parameter specifies the voice ID. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > **Voice Notifications**, and then click the **Voice Notification Files** tab to view the voice ID.
            /// *   If you use a TTS template, this parameter specifies the template ID. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > **Voice Notifications**, and then click the **TTS Template** tab to view the template ID.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The key that can be pressed by the subscriber.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The variables in the TTS template, in the JSON format.
            /// 
            /// > 
            /// 
            /// *   This parameter specifies the substitution relationship of the variables in the TTS template if the value of the **MenuKeyMap.N.Code** parameter is set to the ID of the TTS template.
            /// 
            /// *   This parameter is required if the value of the **MenuKeyMap.N.Code** parameter is set to the ID of a TTS template that contains variables.
            /// </summary>
            [NameInMap("TtsParams")]
            [Validation(Required=false)]
            public string TtsParams { get; set; }

        }

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
        /// The number of replay times. Valid values: 1 to 3.
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The voice that is played when the call begins.
        /// 
        /// *   If you use a voice notification file, this parameter specifies the voice ID. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > Voice Notifications, and then click the **Voice Notification Files** tab to view the voice ID.
        /// *   If you use a text-to-speech (TTS) template, this parameter specifies the template ID. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > **Voice Notifications**, and then click the **TTS Template** tab to view the template ID.
        /// </summary>
        [NameInMap("StartCode")]
        [Validation(Required=false)]
        public string StartCode { get; set; }

        /// <summary>
        /// The variables in the TTS template, in the JSON format.
        /// 
        /// > This parameter is required when the StartCode parameter is set to the ID of a TTS template that contains variables.
        /// </summary>
        [NameInMap("StartTtsParams")]
        [Validation(Required=false)]
        public string StartTtsParams { get; set; }

        /// <summary>
        /// The timeout period for the subscriber to press a key. Unit: milliseconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
