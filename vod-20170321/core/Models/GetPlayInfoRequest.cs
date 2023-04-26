// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the media transcoding job. This ID uniquely identifies a media stream.
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// The frame rate of the media stream. Unit: frames per second.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// The type of Narrowband HD transcoding. Valid values:
        /// 
        /// *   **0**: regular
        /// *   **1.0**: Narrowband HD 1.0
        /// *   **2.0**: Narrowband HD 2.0
        /// 
        /// This parameter is returned only when a quality that is available in the built-in Narrowband HD 1.0 transcoding template is specified. For more information, see the [Definition parameter in the TranscodeTemplate](~~52839~~) table.
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The update time. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public string Formats { get; set; }

        /// <summary>
        /// The URL of the masked live comment data. Set the value to **danmu**.
        /// 
        /// > This parameter takes effect only when the outputType parameter is set to **cdn**.
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// The quality of the video stream. Valid values:
        /// 
        /// *   **FD**: low definition
        /// *   **LD**: standard definition
        /// *   **SD**: high definition
        /// *   **HD**: ultra-high definition
        /// *   **OD**: original definition
        /// *   **2K**: 2K
        /// *   **4K**: 4K
        /// *   **SQ**: standard sound quality
        /// *   **HQ**: high sound quality
        /// *   **AUTO**: adaptive bitrate
        /// </summary>
        [NameInMap("PlayConfig")]
        [Validation(Required=false)]
        public string PlayConfig { get; set; }

        /// <summary>
        /// The playback URL of the video stream.
        /// </summary>
        [NameInMap("ReAuthInfo")]
        [Validation(Required=false)]
        public string ReAuthInfo { get; set; }

        /// <summary>
        /// The time when the audio or video file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// Details of the audio or video file.
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// The basic information about the audio or video file.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
