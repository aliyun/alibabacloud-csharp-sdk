// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainFrameRateAndBitRateDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The frame rates and bitrates of the live streams that were queried.</para>
        /// </summary>
        [NameInMap("FrameRateAndBitRateInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainFrameRateAndBitRateDataResponseBodyFrameRateAndBitRateInfos FrameRateAndBitRateInfos { get; set; }
        public class DescribeLiveDomainFrameRateAndBitRateDataResponseBodyFrameRateAndBitRateInfos : TeaModel {
            [NameInMap("FrameRateAndBitRateInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainFrameRateAndBitRateDataResponseBodyFrameRateAndBitRateInfosFrameRateAndBitRateInfo> FrameRateAndBitRateInfo { get; set; }
            public class DescribeLiveDomainFrameRateAndBitRateDataResponseBodyFrameRateAndBitRateInfosFrameRateAndBitRateInfo : TeaModel {
                /// <summary>
                /// <para>The audio frame rate of the live stream. Unit: FPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42.9</para>
                /// </summary>
                [NameInMap("AudioFrameRate")]
                [Validation(Required=false)]
                public float? AudioFrameRate { get; set; }

                /// <summary>
                /// <para>The bitrate of the live stream. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30693.96</para>
                /// </summary>
                [NameInMap("BitRate")]
                [Validation(Required=false)]
                public float? BitRate { get; set; }

                /// <summary>
                /// <para>The URL of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://demo.aliyundoc.com/test/liveStream****_3_4</para>
                /// </summary>
                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

                /// <summary>
                /// <para>The video frame rate of the live stream. Unit: frames per second (FPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>24.9</para>
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
        /// <para>C3F2C2C4-59BB-4B62-81FF-345BE557E3E3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
