// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class FetchParseDocumentLayoutTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FetchParseDocumentLayoutTaskResponseBodyData Data { get; set; }
        public class FetchParseDocumentLayoutTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Structured content after formatting</para>
            /// </summary>
            [NameInMap("LayoutResult")]
            [Validation(Required=false)]
            public FetchParseDocumentLayoutTaskResponseBodyDataLayoutResult LayoutResult { get; set; }
            public class FetchParseDocumentLayoutTaskResponseBodyDataLayoutResult : TeaModel {
                /// <summary>
                /// <para>Returned element data</para>
                /// </summary>
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<FetchParseDocumentLayoutTaskResponseBodyDataLayoutResultElements> Elements { get; set; }
                public class FetchParseDocumentLayoutTaskResponseBodyDataLayoutResultElements : TeaModel {
                    /// <summary>
                    /// <para>Content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>一、本月主要工作进展\n</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>For headings, content with heading numbers removed</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>本月主要工作进展</para>
                    /// </summary>
                    [NameInMap("FormatContent")]
                    [Validation(Required=false)]
                    public string FormatContent { get; set; }

                    /// <summary>
                    /// <para>Index order of each element</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public float? Index { get; set; }

                    /// <summary>
                    /// <para>Type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>支持的类型如下
                    ///     HEADING(&quot;标题&quot;),
                    ///     H1(&quot;一级标题&quot;),
                    ///     H2(&quot;二级标题&quot;),
                    ///     H3(&quot;三级标题&quot;),
                    ///     H4(&quot;四级标题&quot;),
                    ///     H5(&quot;五级标题&quot;),
                    ///     H6(&quot;六级标题&quot;),
                    ///     PARAGRAPH(&quot;段落&quot;),
                    ///     SIGNATURE(&quot;落款&quot;),
                    ///     FOOTNOTE(&quot;脚注&quot;),
                    ///     TABLE(&quot;表格&quot;),
                    ///     CODE_BLOCK(&quot;代码块&quot;),
                    ///     ATTACHMENT(&quot;附件&quot;),
                    ///     BLOCKQUOTE(&quot;引用&quot;);</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>Task status</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING-待执行、RUNNING-执行中、SUCCESSED-成功、SUSPENDED-暂停、FAILED-失败、CANCELLED-取消</para>
            /// </summary>
            [NameInMap("TaskStats")]
            [Validation(Required=false)]
            public string TaskStats { get; set; }

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
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
