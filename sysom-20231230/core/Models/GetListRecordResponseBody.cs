// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetListRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetListRecordResponseBodyData> Data { get; set; }
        public class GetListRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>AI analysis ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>16896fa8-37f6-4c70-bb32-67fa9817d426</para>
            /// </summary>
            [NameInMap("analysisId")]
            [Validation(Required=false)]
            public string AnalysisId { get; set; }

            /// <summary>
            /// <para>Analysis time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-24 12:02:05</para>
            /// </summary>
            [NameInMap("analysisTime")]
            [Validation(Required=false)]
            public string AnalysisTime { get; set; }

            /// <summary>
            /// <para>Analysis parameters for the AI job</para>
            /// 
            /// <b>Example:</b>
            /// <para>timeout=2000 ms</para>
            /// </summary>
            [NameInMap("arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            /// <summary>
            /// <para>Analysis failure log</para>
            /// 
            /// <b>Example:</b>
            /// <para>机器i-wz9dej066kii4goqpnze分析失败, 失败原因: Not get GPU trace data for \&quot;e59ce870-dbd4-4c44-a814-174ac6ab5bcf\&quot; \&quot;[\&quot;118534\&quot;]\&quot;!</para>
            /// </summary>
            [NameInMap("failedLog")]
            [Validation(Required=false)]
            public string FailedLog { get; set; }

            /// <summary>
            /// <para>Analysis status</para>
            /// 
            /// <b>Example:</b>
            /// <para>已完成/分析失败</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
