// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRtcRecordUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraVideo Real-time Communication application that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7fd341b3-c6fa-43e1-96b8-7295a1dd****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The audio-only summary duration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("AudioSummaryDuration")]
        [Validation(Required=false)]
        public double? AudioSummaryDuration { get; set; }

        /// <summary>
        /// <para>The usage statistics information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeLiveRtcRecordUsageDataResponseBodyData> Data { get; set; }
        public class DescribeLiveRtcRecordUsageDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The audio-only duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AudioDuration")]
            [Validation(Required=false)]
            public double? AudioDuration { get; set; }

            /// <summary>
            /// <para>The timestamp of the data point. Format: yyyy-MM-ddTHH:mm:ssZ (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The total duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("TotalDuration")]
            [Validation(Required=false)]
            public double? TotalDuration { get; set; }

            /// <summary>
            /// <para>The duration of video above 720p. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("V1080Duration")]
            [Validation(Required=false)]
            public double? V1080Duration { get; set; }

            /// <summary>
            /// <para>The duration of video at 480p or lower. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("V480Duration")]
            [Validation(Required=false)]
            public double? V480Duration { get; set; }

            /// <summary>
            /// <para>The duration of video at 720p or lower. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("V720Duration")]
            [Validation(Required=false)]
            public double? V720Duration { get; set; }

        }

        /// <summary>
        /// <para>The recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: single-stream recording mode.</para>
        /// </description></item>
        /// <item><description><para>1: stream mixing recording mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RecordMode")]
        [Validation(Required=false)]
        public string RecordMode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F2*************B92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total summary duration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("TotalSummaryDuration")]
        [Validation(Required=false)]
        public double? TotalSummaryDuration { get; set; }

        /// <summary>
        /// <para>The summary duration of video above 720p (including 1080p). Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("V1080SummaryDuration")]
        [Validation(Required=false)]
        public double? V1080SummaryDuration { get; set; }

        /// <summary>
        /// <para>The summary duration of video at 480p or lower. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("V480SummaryDuration")]
        [Validation(Required=false)]
        public double? V480SummaryDuration { get; set; }

        /// <summary>
        /// <para>The summary duration of video at 720p or lower. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("V720SummaryDuration")]
        [Validation(Required=false)]
        public double? V720SummaryDuration { get; set; }

    }

}
