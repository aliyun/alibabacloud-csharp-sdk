// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SingleCallByTtsRequest : TeaModel {
        /// <summary>
        /// The mobile phone number that receives voice notifications.
        /// 
        /// *   Number format in the Chinese mainland:
        /// 
        ///     *   Mobile phone number, for example, 159\*\*\*\*0000.
        ///     *   Landline number, for example, 0571\*\*\*\*5678.
        /// 
        /// *   Number format outside the Chinese mainland: country code + phone number, for example, 85200\*\*\*\*00.
        /// 
        /// > 
        /// 
        /// *   Each request supports only one called number. For more information, see [How to use voice notifications in the Chinese mainland](~~150016~~) or [How to use voice verification codes in regions outside the Chinese mainland](~~270044~~).
        /// 
        /// *   Voice verification codes are sent to a called number at the following frequency: one time per minute, five times per hour, and 20 times per 24 hours.
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// The number displayed to the called party.
        /// 
        /// *   You do not need to specify this parameter if you use the text-to-speech (TTS) notification template or voice verification code template for outbound calls in the common mode. For more information, see [FAQ about the common outbound call mode](~~172104~~).
        /// *   If you use the TTS notification template or voice verification code template for outbound calls in the dedicated mode, you must specify a number you purchased and only one number can be specified. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home) and choose **Voice Numbers** > **Real Number Management** to view the number you purchased.
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// The custom ID that is reserved for the caller of the operation when the request is initiated. This ID is returned to the caller in a receipt message.
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
        /// The number of times a voice notification is played back in a call. Valid values: 1 to 3. Default value: 3.
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public int? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The playback speed. Valid value: -500 to 500.
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// The ID of the approved TTS notification template or voice verification code template.
        /// 
        /// You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), and choose **Voice Messages** > **Voice Verification Codes** or choose **Voice Messages** > **Voice Notifications** to view the **template ID**.
        /// 
        /// > The account to which the TTS template belongs must be the same as the account that is used to call the SingleCallByTts operation.
        /// </summary>
        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        /// <summary>
        /// The variables in the template, in the JSON format.
        /// 
        /// > The variables in the template must be less than 250 characters in length. The length of each single variable is not limited. These variables do not support URLs. The variables in the verification code template support only digits and letters.
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// The playback volume of the voice notification. Valid values: 0 to 100. Default value: 100.
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
