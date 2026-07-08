// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListGeneratedContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>Document list</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGeneratedContentsResponseBodyData> Data { get; set; }
        public class ListGeneratedContentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Content: rich text</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州亚运会</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Content domain (content category)</para>
            /// <list type="bullet">
            /// <item><description><para>media: Media writing</para>
            /// </description></item>
            /// <item><description><para>government: Government document writing</para>
            /// </description></item>
            /// <item><description><para>office: Office writing</para>
            /// </description></item>
            /// <item><description><para>market: Marketing writing</para>
            /// </description></item>
            /// <item><description><para>custom: Custom writing</para>
            /// </description></item>
            /// <item><description><para>commentGenerate: Opinion generation</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>media</para>
            /// </summary>
            [NameInMap("ContentDomain")]
            [Validation(Required=false)]
            public string ContentDomain { get; set; }

            /// <summary>
            /// <para>Content: plain text</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州亚运会</para>
            /// </summary>
            [NameInMap("ContentText")]
            [Validation(Required=false)]
            public string ContentText { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-04 11:46:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;123&quot;</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Device ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>File attributes</para>
            /// </summary>
            [NameInMap("FileAttr")]
            [Validation(Required=false)]
            public ListGeneratedContentsResponseBodyDataFileAttr FileAttr { get; set; }
            public class ListGeneratedContentsResponseBodyDataFileAttr : TeaModel {
                /// <summary>
                /// <para>File name</para>
                /// 
                /// <b>Example:</b>
                /// <para>homedepothp.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>Video height</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>Temporary URL for video file access. Expires in one hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/xxx.mp4">http://www.example.com/xxx.mp4</a></para>
                /// </summary>
                [NameInMap("TmpUrl")]
                [Validation(Required=false)]
                public string TmpUrl { get; set; }

                /// <summary>
                /// <para>Video width</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>File ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://default/oss-bucket-name/aimiaobi/2021/07/01/1625126400000/1.docx</para>
            /// </summary>
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            /// <summary>
            /// <para>Document ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Keywords</para>
            /// </summary>
            [NameInMap("KeywordList")]
            [Validation(Required=false)]
            public List<string> KeywordList { get; set; }

            /// <summary>
            /// <para>Keywords (string)</para>
            /// 
            /// <b>Example:</b>
            /// <para>观点</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// <para>Last prompt used to generate this document</para>
            /// 
            /// <b>Example:</b>
            /// <para>创作xxx文章</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>Conversation task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Title</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州亚运会</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-04 11:46:07</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Updater</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1111&quot;</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

            /// <summary>
            /// <para>UUID traceability ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Number of items per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Operation status: true means success. false means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of items</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
