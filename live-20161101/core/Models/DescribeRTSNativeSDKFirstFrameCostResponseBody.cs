// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKFirstFrameCostResponseBody : TeaModel {
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
        /// <para>The average latency of first frames at each interval. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("FirstFrameCostData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKFirstFrameCostResponseBodyFirstFrameCostData> FirstFrameCostData { get; set; }
        public class DescribeRTSNativeSDKFirstFrameCostResponseBodyFirstFrameCostData : TeaModel {
            /// <summary>
            /// <para>The time elapsed from initialization to connection establishment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Connected")]
            [Validation(Required=false)]
            public string Connected { get; set; }

            /// <summary>
            /// <para>The time elapsed from connection establishment to subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("FinishGetStreamInfo")]
            [Validation(Required=false)]
            public string FinishGetStreamInfo { get; set; }

            /// <summary>
            /// <para>The time elapsed from first packet processing to display of the first frame.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("FirstFrameComplete")]
            [Validation(Required=false)]
            public string FirstFrameComplete { get; set; }

            /// <summary>
            /// <para>The time elapsed from subscription to first packet processing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132</para>
            /// </summary>
            [NameInMap("FirstPacket")]
            [Validation(Required=false)]
            public string FirstPacket { get; set; }

            /// <summary>
            /// <para>The time consumed by initialization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100</para>
            /// </summary>
            [NameInMap("Initialized")]
            [Validation(Required=false)]
            public string Initialized { get; set; }

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
        /// <para>BC858082-736F-4A25-867B-E5B67C85ACF7</para>
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
