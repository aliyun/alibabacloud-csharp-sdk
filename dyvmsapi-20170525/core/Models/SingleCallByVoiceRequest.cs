// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SingleCallByVoiceRequest : TeaModel {
        /// <summary>
        /// The number for receiving voice notifications.
        /// 
        /// Number format:
        /// 
        /// *   In the Chinese mainland:
        /// 
        ///     *   Mobile phone number, for example, 159\*\*\*\*0000.
        ///     *   Landline number, for example, 0571\*\*\*\*5678.
        /// 
        /// *   Outside the Chinese mainland: country code + phone number, for example, 85200\*\*\*\*00.
        /// 
        /// > 
        /// 
        /// *   You can specify only one called number for a request. For more information, see [How to use voice notifications in the Chinese mainland](~~150016~~) or [How to use voice notifications in regions outside the Chinese mainland](~~268810~~).
        /// 
        /// *   Voice notifications are sent to a called number at the following frequency: one time per minute, five times per hour, and 20 times per 24 hours.
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// The number displayed to the called party.
        /// 
        /// *   You do not need to specify this parameter if you use a voice notification file that uses the common outbound call mode. For more information, see [FAQ about the common outbound call mode](~~172104~~).
        /// *   If you use a voice notification file that uses the dedicated outbound call mode, you must specify a number that you purchased. You can specify only one number. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home) and choose **Real Number Service** > **Real Number Management** to view the number that you purchased.
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// The ID reserved for the caller. This ID is returned to the caller in a receipt message.
        /// 
        /// The value must be of the STRING type and 1 to 15 bytes in length.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of times the voice notification file is played. Valid values: 1 to 3.
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
        /// The playback speed of the voice notification file. Valid values: -500 to 500.
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// The voice ID of the voice notification file.
        /// 
        /// You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > **Voice Notifications** or **Voice File Management**, and then click the **Voice Notification Files** tab to view the **voice ID**.
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// The playback volume of the voice notification file. Valid values: 0 to 100. Default value: 100.
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
