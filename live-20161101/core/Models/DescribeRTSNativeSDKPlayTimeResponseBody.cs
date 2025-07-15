// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKPlayTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The end of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The average playback duration and average stuttering duration at each interval. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("PlayTimeData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKPlayTimeResponseBodyPlayTimeData> PlayTimeData { get; set; }
        public class DescribeRTSNativeSDKPlayTimeResponseBodyPlayTimeData : TeaModel {
            /// <summary>
            /// <para>The average playback duration within the period of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("PlayTime")]
            [Validation(Required=false)]
            public string PlayTime { get; set; }

            /// <summary>
            /// <para>The average stuttering duration within the period of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StallTime")]
            [Validation(Required=false)]
            public string StallTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BF95F2A-3B24-4CDE-9346-7F6FA86697A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
