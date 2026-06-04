// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class FetchParseDocumentLayoutTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FetchParseDocumentLayoutTaskResponseBodyData Data { get; set; }
        public class FetchParseDocumentLayoutTaskResponseBodyData : TeaModel {
            [NameInMap("LayoutResult")]
            [Validation(Required=false)]
            public FetchParseDocumentLayoutTaskResponseBodyDataLayoutResult LayoutResult { get; set; }
            public class FetchParseDocumentLayoutTaskResponseBodyDataLayoutResult : TeaModel {
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<FetchParseDocumentLayoutTaskResponseBodyDataLayoutResultElements> Elements { get; set; }
                public class FetchParseDocumentLayoutTaskResponseBodyDataLayoutResultElements : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("FormatContent")]
                    [Validation(Required=false)]
                    public string FormatContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public float? Index { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("TaskStats")]
            [Validation(Required=false)]
            public string TaskStats { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
