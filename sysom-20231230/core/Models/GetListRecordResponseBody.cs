// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetListRecordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetListRecordResponseBodyData> Data { get; set; }
        public class GetListRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>16896fa8-37f6-4c70-bb32-67fa9817d426</para>
            /// </summary>
            [NameInMap("analysisId")]
            [Validation(Required=false)]
            public string AnalysisId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-24 12:02:05</para>
            /// </summary>
            [NameInMap("analysisTime")]
            [Validation(Required=false)]
            public string AnalysisTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>timeout=2000 ms</para>
            /// </summary>
            [NameInMap("arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            [NameInMap("failedLog")]
            [Validation(Required=false)]
            public string FailedLog { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
