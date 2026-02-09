// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPptArtifactResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPptArtifactResponseBodyData Data { get; set; }
        public class GetPptArtifactResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-25 11:40:50</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FileAttr")]
            [Validation(Required=false)]
            public GetPptArtifactResponseBodyDataFileAttr FileAttr { get; set; }
            public class GetPptArtifactResponseBodyDataFileAttr : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.pptx</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/xxx.pptx">http://www.example.com/xxx.pptx</a></para>
                /// </summary>
                [NameInMap("TmpUrl")]
                [Validation(Required=false)]
                public string TmpUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://default/oss-bucket-name/aimiaobi/2021/07/01/1625126400000/1.docx</para>
            /// </summary>
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-25 11:40:50</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
