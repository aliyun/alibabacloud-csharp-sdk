// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListDashboardMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para><b>null</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The specific value of the metric.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDashboardMetricsResponseBodyResult> Result { get; set; }
        public class ListDashboardMetricsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The end time. The value is a timestamp in seconds.</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<ListDashboardMetricsResponseBodyResultDetail> Detail { get; set; }
            public class ListDashboardMetricsResponseBodyResultDetail : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1586673466</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1586673466</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("val")]
                [Validation(Required=false)]
                public string Val { get; set; }

            }

            /// <summary>
            /// <para>The start time. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public Dictionary<string, object> Total { get; set; }

        }

    }

}
