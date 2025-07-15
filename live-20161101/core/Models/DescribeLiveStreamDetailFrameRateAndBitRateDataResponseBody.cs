// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamDetailFrameRateAndBitRateDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The audio and video frame rates and bitrates at each time granularity.</para>
        /// </summary>
        [NameInMap("FrameRateAndBitRateInfos")]
        [Validation(Required=false)]
        public List<DescribeLiveStreamDetailFrameRateAndBitRateDataResponseBodyFrameRateAndBitRateInfos> FrameRateAndBitRateInfos { get; set; }
        public class DescribeLiveStreamDetailFrameRateAndBitRateDataResponseBodyFrameRateAndBitRateInfos : TeaModel {
            /// <summary>
            /// <para>The audio bitrate of the live stream. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("AudioBitRate")]
            [Validation(Required=false)]
            public float? AudioBitRate { get; set; }

            /// <summary>
            /// <para>The audio frame rate of the live stream. Unit: FPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AudioFrameRate")]
            [Validation(Required=false)]
            public float? AudioFrameRate { get; set; }

            /// <summary>
            /// <para>The bitrate of the live stream. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1420</para>
            /// </summary>
            [NameInMap("BitRate")]
            [Validation(Required=false)]
            public float? BitRate { get; set; }

            /// <summary>
            /// <para>The URL of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://example.com/AppName/exampleStreamName</para>
            /// </summary>
            [NameInMap("StreamUrl")]
            [Validation(Required=false)]
            public string StreamUrl { get; set; }

            /// <summary>
            /// <para>The time when the data was collected. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-09-13T16:04:00Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The video bitrate of the live stream. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("VideoBitRate")]
            [Validation(Required=false)]
            public float? VideoBitRate { get; set; }

            /// <summary>
            /// <para>The video frame rate of the live stream. Unit: frames per second (FPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("VideoFrameRate")]
            [Validation(Required=false)]
            public float? VideoFrameRate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC858082-736F-4A25-867B-E5B67C85ACF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
