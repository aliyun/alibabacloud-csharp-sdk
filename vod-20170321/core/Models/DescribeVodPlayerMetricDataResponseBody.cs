// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodPlayerMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVodPlayerMetricDataResponseBodyDataList> DataList { get; set; }
        public class DescribeVodPlayerMetricDataResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The average completion plays per user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AvgPerCompletionVv")]
            [Validation(Required=false)]
            public double? AvgPerCompletionVv { get; set; }

            /// <summary>
            /// <para>The average play duration per user, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("AvgPerPlayDuration")]
            [Validation(Required=false)]
            public double? AvgPerPlayDuration { get; set; }

            /// <summary>
            /// <para>The average plays per user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AvgPerVv")]
            [Validation(Required=false)]
            public double? AvgPerVv { get; set; }

            /// <summary>
            /// <para>The average playback bitrate, in bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AvgPlayBitrate")]
            [Validation(Required=false)]
            public double? AvgPlayBitrate { get; set; }

            /// <summary>
            /// <para>The average play duration, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("AvgPlayDuration")]
            [Validation(Required=false)]
            public double? AvgPlayDuration { get; set; }

            /// <summary>
            /// <para>The average start bitrate, in bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AvgStartBitrate")]
            [Validation(Required=false)]
            public double? AvgStartBitrate { get; set; }

            /// <summary>
            /// <para>The average video duration, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("AvgVideoDuration")]
            [Validation(Required=false)]
            public double? AvgVideoDuration { get; set; }

            /// <summary>
            /// <para>The completion rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("CompletionRate")]
            [Validation(Required=false)]
            public double? CompletionRate { get; set; }

            /// <summary>
            /// <para>The completion count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("CompletionVv")]
            [Validation(Required=false)]
            public double? CompletionVv { get; set; }

            /// <summary>
            /// <para>The dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>H265_MP4_WIFI</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public string Dimension { get; set; }

            /// <summary>
            /// <para>The error count per 100 seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ErrorCount100s")]
            [Validation(Required=false)]
            public double? ErrorCount100s { get; set; }

            /// <summary>
            /// <para>The first frame time, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FirstFrame")]
            [Validation(Required=false)]
            public double? FirstFrame { get; set; }

            /// <summary>
            /// <para>The 5-second bounce rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("JumpRate5s")]
            [Validation(Required=false)]
            public double? JumpRate5s { get; set; }

            /// <summary>
            /// <para>The play failure rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("PlayFailRate")]
            [Validation(Required=false)]
            public double? PlayFailRate { get; set; }

            /// <summary>
            /// <para>The actual play count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RealVv")]
            [Validation(Required=false)]
            public double? RealVv { get; set; }

            /// <summary>
            /// <para>The instant play rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("SecondPlayRate")]
            [Validation(Required=false)]
            public double? SecondPlayRate { get; set; }

            /// <summary>
            /// <para>The non-play rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("SeedFailRate")]
            [Validation(Required=false)]
            public double? SeedFailRate { get; set; }

            /// <summary>
            /// <para>The seek duration, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SeekDuration")]
            [Validation(Required=false)]
            public double? SeekDuration { get; set; }

            /// <summary>
            /// <para>The slow play rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("SlowPlayRate")]
            [Validation(Required=false)]
            public double? SlowPlayRate { get; set; }

            /// <summary>
            /// <para>The stuttering count per 100 seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StuckCount100s")]
            [Validation(Required=false)]
            public string StuckCount100s { get; set; }

            /// <summary>
            /// <para>The stuttering rate by count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("StuckCountRate")]
            [Validation(Required=false)]
            public double? StuckCountRate { get; set; }

            /// <summary>
            /// <para>The stuttering duration per 100 seconds, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StuckDuration100s")]
            [Validation(Required=false)]
            public double? StuckDuration100s { get; set; }

            /// <summary>
            /// <para>The timestamp of the data. Format: yyyy-mm-ddthh:mm:ssz (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-24T00:55:06Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <para>The total play duration, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TotalPlayDuration")]
            [Validation(Required=false)]
            public double? TotalPlayDuration { get; set; }

            /// <summary>
            /// <para>The number of playback users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("Uv")]
            [Validation(Required=false)]
            public double? Uv { get; set; }

            /// <summary>
            /// <para>The play count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("Vv")]
            [Validation(Required=false)]
            public double? Vv { get; set; }

        }

        /// <summary>
        /// <para>The extended information.</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public DescribeVodPlayerMetricDataResponseBodyExtend Extend { get; set; }
        public class DescribeVodPlayerMetricDataResponseBodyExtend : TeaModel {
            /// <summary>
            /// <para>The latest time with data points within the specified time range. Format: yyyy-mm-ddthh:mm:ssz (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-05T15:59:59Z</para>
            /// </summary>
            [NameInMap("ActualEndTime")]
            [Validation(Required=false)]
            public string ActualEndTime { get; set; }

            /// <summary>
            /// <para>The earliest time with data points within the specified time range. Format: yyyy-mm-ddthh:mm:ssz (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-24T00:55:06Z</para>
            /// </summary>
            [NameInMap("ActualStartTime")]
            [Validation(Required=false)]
            public string ActualStartTime { get; set; }

            /// <summary>
            /// <para>The time granularity of the queried data, in seconds (s).</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("IntervalSeconds")]
            [Validation(Required=false)]
            public long? IntervalSeconds { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
