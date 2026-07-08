// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPptInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPptInfoResponseBodyData Data { get; set; }
        public class GetPptInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Download links for the exported files.</para>
            /// </summary>
            [NameInMap("ExportFileLink")]
            [Validation(Required=false)]
            public List<string> ExportFileLink { get; set; }

            /// <summary>
            /// <para>The ID of the export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx-xxx-xx</para>
            /// </summary>
            [NameInMap("ExportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            /// <summary>
            /// <para>The URL of the cover image for the PPT artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://a.com/xxx.jpeg">http://a.com/xxx.jpeg</a></para>
            /// </summary>
            [NameInMap("PptArtifactCover")]
            [Validation(Required=false)]
            public string PptArtifactCover { get; set; }

            /// <summary>
            /// <para>The ID of the PPT artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5423431</para>
            /// </summary>
            [NameInMap("PptArtifactId")]
            [Validation(Required=false)]
            public string PptArtifactId { get; set; }

            /// <summary>
            /// <para>The ID of the PPT process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11231232</para>
            /// </summary>
            [NameInMap("PptProcessId")]
            [Validation(Required=false)]
            public string PptProcessId { get; set; }

            /// <summary>
            /// <para>The query for the PPT task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>关于班会主题的PPT</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx-xxx-xx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
