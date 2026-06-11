// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryAccelerationLogByCubeIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D********80FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the API request.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The execution succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: The execution failed.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryAccelerationLogByCubeIdResponseBodyResult Result { get; set; }
        public class QueryAccelerationLogByCubeIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>An array of acceleration task logs.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryAccelerationLogByCubeIdResponseBodyResultData> Data { get; set; }
            public class QueryAccelerationLogByCubeIdResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The task duration in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The task history ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REST_A***************6a8</para>
                /// </summary>
                [NameInMap("JobHistoryId")]
                [Validation(Required=false)]
                public string JobHistoryId { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REST_A***************6a8</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The status of the task.</para>
                /// <list type="bullet">
                /// <item><description><para>0: Pending</para>
                /// </description></item>
                /// <item><description><para>1: Running</para>
                /// </description></item>
                /// <item><description><para>2: Succeeded</para>
                /// </description></item>
                /// <item><description><para>3: Failed</para>
                /// </description></item>
                /// <item><description><para>4: Canceled</para>
                /// </description></item>
                /// <item><description><para>5: Warning</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                /// <summary>
                /// <para>The start time of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REST_A***************6a8</para>
                /// </summary>
                [NameInMap("JonStartDate")]
                [Validation(Required=false)]
                public string JonStartDate { get; set; }

                /// <summary>
                /// <para>The log content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdav************</para>
                /// </summary>
                [NameInMap("Log")]
                [Validation(Required=false)]
                public string Log { get; set; }

            }

            /// <summary>
            /// <para>The next page. A value of NULL or 0 indicates that no next page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public int? Next { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The previous page. A value of NULL or 0 indicates that no previous page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Pre")]
            [Validation(Required=false)]
            public int? Pre { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
