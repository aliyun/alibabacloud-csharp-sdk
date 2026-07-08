// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPptArtifactResponseBody : TeaModel {
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
        /// <para>The task response object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPptArtifactResponseBodyData Data { get; set; }
        public class GetPptArtifactResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the resource was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-25 11:40:50</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The file properties.</para>
            /// </summary>
            [NameInMap("FileAttr")]
            [Validation(Required=false)]
            public GetPptArtifactResponseBodyDataFileAttr FileAttr { get; set; }
            public class GetPptArtifactResponseBodyDataFileAttr : TeaModel {
                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.pptx</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The height.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>The temporary access URL for the file. The URL expires in one hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/xxx.pptx">http://www.example.com/xxx.pptx</a></para>
                /// </summary>
                [NameInMap("TmpUrl")]
                [Validation(Required=false)]
                public string TmpUrl { get; set; }

                /// <summary>
                /// <para>The width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>The storage path of the file in the backend.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://default/oss-bucket-name/aimiaobi/2021/07/01/1625126400000/1.docx</para>
            /// </summary>
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            /// <summary>
            /// <para>The unique ID of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>内容标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The time when the artifact was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-25 11:40:50</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
