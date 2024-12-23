// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class BackendCallGroupRequest : TeaModel {
        /// <summary>
        /// <para>The called numbers. You can specify up to 50,000 phone numbers.</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public List<string> CalledNumber { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// <para>If you do not specify this parameter, the system uses a local random number as the display number. If you use a dedicated number for outbound calls, you must specify the purchased number. You can specify only one number. You can log on to the VMS console and choose Number Management to view the purchased phone numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>852****1111</para>
        /// </summary>
        [NameInMap("CallerIdNumber")]
        [Validation(Required=false)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// <para>The ISO2 country code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HK</para>
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// <para>The ID reserved for the caller. This ID is returned to the caller in a receipt message.</para>
        /// <para>The value must be of the STRING type and 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22596****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of times the audio file is played. Valid values: 1 to 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The delivery type. Valid values: 1 and 2.</para>
        /// <para>1: The audio file is delivered immediately.</para>
        /// <para>2: The audio file is delivered at a scheduled time. If you specify SendType as 2, you must specify TimingStart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SendType")]
        [Validation(Required=false)]
        public long? SendType { get; set; }

        /// <summary>
        /// <para>The playback speed. Valid values: -500 to 500.</para>
        /// <para>You must specify this parameter when the audio type is text-to-speech (TTS). You do not need to specify this parameter when you use recordings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public long? Speed { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The time when the audio file is scheduled to be delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-01T08:00:00+08:00</para>
        /// </summary>
        [NameInMap("TimingStart")]
        [Validation(Required=false)]
        public string TimingStart { get; set; }

        /// <summary>
        /// <para>The voice template ID of the audio file.</para>
        /// <para>You can log on to the VMS console and choose Voice Call Template &gt; Audio File to view the template ID.</para>
        /// <para>You must specify either TtsCode or VoiceCode. You can specify TtsCode to use the audio file as the call content. Alternatively, you can specify VoiceCode to use preset text as the call content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        /// <summary>
        /// <para>The TTS template ID.</para>
        /// <para>You can log on to the VMS console and choose Voice Call Template &gt; TTS Template to view the template ID.</para>
        /// <para>You must specify either TtsCode or VoiceCode. You can specify TtsCode to use the audio file as the call content. Alternatively, you can specify VoiceCode to use preset text as the call content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200001</para>
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// <para>The playback volume of the audio file. Valid values: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

    }

}
