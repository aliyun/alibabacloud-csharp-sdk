// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeUserMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeUserMetricsResponseBodyResult> Result { get; set; }
        public class DescribeUserMetricsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The returned metrics.</para>
            /// </summary>
            [NameInMap("dataPoints")]
            [Validation(Required=false)]
            public List<DescribeUserMetricsResponseBodyResultDataPoints> DataPoints { get; set; }
            public class DescribeUserMetricsResponseBodyResultDataPoints : TeaModel {
                /// <summary>
                /// <para>The end time. The value is a timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1567152000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The start time. The value is a timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1567152000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The value of the corresponding metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>84.6</para>
                /// </summary>
                [NameInMap("val")]
                [Validation(Required=false)]
                public float? Val { get; set; }

            }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

    }

}
