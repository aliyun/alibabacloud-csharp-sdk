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
        /// <para>The end time. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The average first frame latency composition for each time interval. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("FirstFrameCostData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKFirstFrameCostResponseBodyFirstFrameCostData> FirstFrameCostData { get; set; }
        public class DescribeRTSNativeSDKFirstFrameCostResponseBodyFirstFrameCostData : TeaModel {
            /// <summary>
            /// <para>The time elapsed from successful initialization to successful connection establishment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Connected")]
            [Validation(Required=false)]
            public string Connected { get; set; }

            /// <summary>
            /// <para>The time elapsed from successful connection establishment to successful subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("FinishGetStreamInfo")]
            [Validation(Required=false)]
            public string FinishGetStreamInfo { get; set; }

            /// <summary>
            /// <para>The time elapsed from receiving the first packet to rendering the first frame.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("FirstFrameComplete")]
            [Validation(Required=false)]
            public string FirstFrameComplete { get; set; }

            /// <summary>
            /// <para>The time elapsed from successful subscription to receiving the first packet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132</para>
            /// </summary>
            [NameInMap("FirstPacket")]
            [Validation(Required=false)]
            public string FirstPacket { get; set; }

            /// <summary>
            /// <para>The initialization duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100</para>
            /// </summary>
            [NameInMap("Initialized")]
            [Validation(Required=false)]
            public string Initialized { get; set; }

            /// <summary>
            /// <para>The start time of the time interval. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC858082-736F-4A25-867B-E5B67C85ACF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
