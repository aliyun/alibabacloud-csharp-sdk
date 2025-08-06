// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodPlayerMetricDataDemoResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVodPlayerMetricDataDemoResponseBodyDataList> DataList { get; set; }
        public class DescribeVodPlayerMetricDataDemoResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AvgPerCompletionVv")]
            [Validation(Required=false)]
            public double? AvgPerCompletionVv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("AvgPerPlayDuration")]
            [Validation(Required=false)]
            public double? AvgPerPlayDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AvgPerVv")]
            [Validation(Required=false)]
            public double? AvgPerVv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AvgPlayBitrate")]
            [Validation(Required=false)]
            public double? AvgPlayBitrate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("AvgPlayDuration")]
            [Validation(Required=false)]
            public double? AvgPlayDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AvgStartBitrate")]
            [Validation(Required=false)]
            public double? AvgStartBitrate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("AvgVideoDuration")]
            [Validation(Required=false)]
            public double? AvgVideoDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public double? Bps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("CompletionDegree")]
            [Validation(Required=false)]
            public double? CompletionDegree { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("CompletionRate")]
            [Validation(Required=false)]
            public double? CompletionRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("CompletionVv")]
            [Validation(Required=false)]
            public double? CompletionVv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Cuv")]
            [Validation(Required=false)]
            public double? Cuv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>H265_MP4_WIFI</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public string Dimension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ErrorCount100s")]
            [Validation(Required=false)]
            public double? ErrorCount100s { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FirstFrame")]
            [Validation(Required=false)]
            public double? FirstFrame { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("JumpRate5s")]
            [Validation(Required=false)]
            public double? JumpRate5s { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("PlayFailRate")]
            [Validation(Required=false)]
            public double? PlayFailRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RealVv")]
            [Validation(Required=false)]
            public double? RealVv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("ReplayRate")]
            [Validation(Required=false)]
            public double? ReplayRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("SecondPlayRate")]
            [Validation(Required=false)]
            public double? SecondPlayRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("SeedFailRate")]
            [Validation(Required=false)]
            public double? SeedFailRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SeekDuration")]
            [Validation(Required=false)]
            public double? SeekDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("SlowPlayRate")]
            [Validation(Required=false)]
            public double? SlowPlayRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StuckCount100s")]
            [Validation(Required=false)]
            public string StuckCount100s { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("StuckCountRate")]
            [Validation(Required=false)]
            public double? StuckCountRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StuckDuration100s")]
            [Validation(Required=false)]
            public double? StuckDuration100s { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-24T00:55:06Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TotalPlayDuration")]
            [Validation(Required=false)]
            public double? TotalPlayDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Traf")]
            [Validation(Required=false)]
            public double? Traf { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("Uv")]
            [Validation(Required=false)]
            public double? Uv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("VideoBitrate")]
            [Validation(Required=false)]
            public double? VideoBitrate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("Vv")]
            [Validation(Required=false)]
            public double? Vv { get; set; }

        }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public DescribeVodPlayerMetricDataDemoResponseBodyExtend Extend { get; set; }
        public class DescribeVodPlayerMetricDataDemoResponseBodyExtend : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-05T15:59:59Z</para>
            /// </summary>
            [NameInMap("ActualEndTime")]
            [Validation(Required=false)]
            public string ActualEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-24T00:55:06Z</para>
            /// </summary>
            [NameInMap("ActualStartTime")]
            [Validation(Required=false)]
            public string ActualStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("IntervalSeconds")]
            [Validation(Required=false)]
            public long? IntervalSeconds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
