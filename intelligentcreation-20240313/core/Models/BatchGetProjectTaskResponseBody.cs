// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchGetProjectTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<BatchGetProjectTaskResponseBodyResultList> ResultList { get; set; }
        public class BatchGetProjectTaskResponseBodyResultList : TeaModel {
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("videoDownloadUrl")]
            [Validation(Required=false)]
            public string VideoDownloadUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("videoDuration")]
            [Validation(Required=false)]
            public int? VideoDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("videoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

    }

}
