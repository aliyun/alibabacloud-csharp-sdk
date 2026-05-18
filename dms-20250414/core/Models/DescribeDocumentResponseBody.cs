// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDocumentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDocumentResponseBodyData Data { get; set; }
        public class DescribeDocumentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DocsCount")]
            [Validation(Required=false)]
            public long? DocsCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ADBPGLoader</para>
            /// </summary>
            [NameInMap("DocumentLoaderName")]
            [Validation(Required=false)]
            public string DocumentLoaderName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>md</para>
            /// </summary>
            [NameInMap("FileExt")]
            [Validation(Required=false)]
            public string FileExt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20307</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-22 22:59:35</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-24 21:22:53</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kb-***</para>
            /// </summary>
            [NameInMap("KbUuid")]
            [Validation(Required=false)]
            public string KbUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;test&quot;,&quot;abc&quot;]</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.md</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public long? State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is a test document.</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ChineseRecursiveTextSplitter</para>
            /// </summary>
            [NameInMap("TextSplitterName")]
            [Validation(Required=false)]
            public string TextSplitterName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KnowledgeBaseNotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Resource not found kb-***</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
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
