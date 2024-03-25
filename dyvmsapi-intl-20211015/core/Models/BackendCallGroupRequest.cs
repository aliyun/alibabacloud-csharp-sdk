/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class BackendCallGroupRequest : TeaModel {
        /// <summary>
        /// The called numbers. You can specify up to 50,000 phone numbers.
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public List<string> CalledNumber { get; set; }

        /// <summary>
        /// The calling number.
        /// 
        /// If you do not specify this parameter, the system uses a local random number as the display number. If you use a dedicated number for outbound calls, you must specify the purchased number. You can specify only one number. You can log on to the VMS console and choose Number Management to view the purchased phone numbers.
        /// </summary>
        [NameInMap("CallerIdNumber")]
        [Validation(Required=false)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// The ISO2 country code.
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

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
        /// The number of times the audio file is played. Valid values: 1 to 3.
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
        /// The delivery type. Valid values: 1 and 2.
        /// 
        /// 1: The audio file is delivered immediately.
        /// 
        /// 2: The audio file is delivered at a scheduled time. If you specify SendType as 2, you must specify TimingStart.
        /// </summary>
        [NameInMap("SendType")]
        [Validation(Required=false)]
        public long? SendType { get; set; }

        /// <summary>
        /// The playback speed. Valid values: -500 to 500.
        /// 
        /// You must specify this parameter when the audio type is text-to-speech (TTS). You do not need to specify this parameter when you use recordings.
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public long? Speed { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The time when the audio file is scheduled to be delivered.
        /// </summary>
        [NameInMap("TimingStart")]
        [Validation(Required=false)]
        public string TimingStart { get; set; }

        /// <summary>
        /// The voice template ID of the audio file.
        /// 
        /// You can log on to the VMS console and choose Voice Call Template > Audio File to view the template ID.
        /// 
        /// You must specify either TtsCode or VoiceCode. You can specify TtsCode to use the audio file as the call content. Alternatively, you can specify VoiceCode to use preset text as the call content.
        /// </summary>
        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        /// <summary>
        /// The TTS template ID.
        /// 
        /// You can log on to the VMS console and choose Voice Call Template > TTS Template to view the template ID.
        /// 
        /// You must specify either TtsCode or VoiceCode. You can specify TtsCode to use the audio file as the call content. Alternatively, you can specify VoiceCode to use preset text as the call content.
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// The playback volume of the audio file. Valid values: 0 to 100. Default value: 100.
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

    }

}
