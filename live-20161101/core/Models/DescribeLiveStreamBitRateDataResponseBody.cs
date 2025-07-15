// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamBitRateDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The frame rates and bitrates of the live stream.</para>
        /// </summary>
        [NameInMap("FrameRateAndBitRateInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfos FrameRateAndBitRateInfos { get; set; }
        public class DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfos : TeaModel {
            [NameInMap("FrameRateAndBitRateInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfosFrameRateAndBitRateInfo> FrameRateAndBitRateInfo { get; set; }
            public class DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfosFrameRateAndBitRateInfo : TeaModel {
                /// <summary>
                /// <para>The audio frame rate of the live stream. Unit: FPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AudioFrameRate")]
                [Validation(Required=false)]
                public float? AudioFrameRate { get; set; }

                /// <summary>
                /// <para>The bitrate of the live stream. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("BitRate")]
                [Validation(Required=false)]
                public float? BitRate { get; set; }

                /// <summary>
                /// <para>The URL of the live stream.</para>
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
                /// <para>The video frame rate of the live stream. Unit: frames per second (FPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("VideoFrameRate")]
                [Validation(Required=false)]
                public float? VideoFrameRate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
