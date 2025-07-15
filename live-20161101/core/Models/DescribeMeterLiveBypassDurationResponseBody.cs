// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeMeterLiveBypassDurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The total audio-only duration. Audio-only is a basic specification. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("AudioSummaryDuration")]
        [Validation(Required=false)]
        public long? AudioSummaryDuration { get; set; }

        /// <summary>
        /// <para>The usage statistics for each time granularity.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterLiveBypassDurationResponseBodyData> Data { get; set; }
        public class DescribeMeterLiveBypassDurationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The audio-only duration. Audio-only is a basic specification. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AudioDuration")]
            [Validation(Required=false)]
            public long? AudioDuration { get; set; }

            /// <summary>
            /// <para>The single-stream relay duration for audio. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Single_Audio")]
            [Validation(Required=false)]
            public long? SingleAudio { get; set; }

            /// <summary>
            /// <para>The single-stream relay duration for video. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Single_Video")]
            [Validation(Required=false)]
            public long? SingleVideo { get; set; }

            /// <summary>
            /// <para>The timestamp of the data returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The duration. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("TotalDuration")]
            [Validation(Required=false)]
            public long? TotalDuration { get; set; }

            /// <summary>
            /// <para>The Full HD duration. The video resolution is 1920 × 1080 or lower. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("V1080Duration")]
            [Validation(Required=false)]
            public long? V1080Duration { get; set; }

            /// <summary>
            /// <para>The SD duration. The video resolution is 640 × 480 or lower. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("V480Duration")]
            [Validation(Required=false)]
            public long? V480Duration { get; set; }

            /// <summary>
            /// <para>The HD duration. The video resolution is 1280 × 720 or lower. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("V720Duration")]
            [Validation(Required=false)]
            public long? V720Duration { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B460F8B-993C-4F48-B98A-910811DEBFEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total single-stream relay duration for audio. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SingleAudioSummaryDuration")]
        [Validation(Required=false)]
        public long? SingleAudioSummaryDuration { get; set; }

        /// <summary>
        /// <para>The total single-stream relay duration for video. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SingleVideoSummaryDuration")]
        [Validation(Required=false)]
        public long? SingleVideoSummaryDuration { get; set; }

        /// <summary>
        /// <para>The total duration. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("TotalSummaryDuration")]
        [Validation(Required=false)]
        public long? TotalSummaryDuration { get; set; }

        /// <summary>
        /// <para>The total Full HD duration. The video resolution is 1920 × 1080 or lower. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("V1080SummaryDuration")]
        [Validation(Required=false)]
        public long? V1080SummaryDuration { get; set; }

        /// <summary>
        /// <para>The total standard definition (SD) duration. The video resolution is 640 × 480 or lower. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("V480SummaryDuration")]
        [Validation(Required=false)]
        public long? V480SummaryDuration { get; set; }

        /// <summary>
        /// <para>The total high definition (HD) duration. The video resolution is 1280 × 720 or lower. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("V720SummaryDuration")]
        [Validation(Required=false)]
        public long? V720SummaryDuration { get; set; }

    }

}
