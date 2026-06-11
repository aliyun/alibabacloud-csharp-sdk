// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDocumentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the document.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDocumentResponseBodyData Data { get; set; }
        public class DescribeDocumentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of chunks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DocsCount")]
            [Validation(Required=false)]
            public long? DocsCount { get; set; }

            /// <summary>
            /// <para>The name of the document loader.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADBPGLoader</para>
            /// </summary>
            [NameInMap("DocumentLoaderName")]
            [Validation(Required=false)]
            public string DocumentLoaderName { get; set; }

            /// <summary>
            /// <para>The file extension of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>md</para>
            /// </summary>
            [NameInMap("FileExt")]
            [Validation(Required=false)]
            public string FileExt { get; set; }

            /// <summary>
            /// <para>The size of the document in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20307</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The creation time of the document, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-22 22:59:35</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the document, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-24 21:22:53</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-***</para>
            /// </summary>
            [NameInMap("KbUuid")]
            [Validation(Required=false)]
            public string KbUuid { get; set; }

            /// <summary>
            /// <para>The keywords of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;test&quot;,&quot;abc&quot;]</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// <para>The name of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.md</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The document state. Possible values are:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Parsing complete.</para>
            /// </description></item>
            /// <item><description><para><b>-1</b>: Not parsed.</para>
            /// </description></item>
            /// <item><description><para><b>-2</b>: Parsing in progress.</para>
            /// </description></item>
            /// <item><description><para><b>-3</b>: Parsing failed.</para>
            /// </description></item>
            /// <item><description><para><b>-4</b>: Parsing canceled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public long? State { get; set; }

            /// <summary>
            /// <para>The summary of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test document.</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The name of the text splitter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ChineseRecursiveTextSplitter</para>
            /// </summary>
            [NameInMap("TextSplitterName")]
            [Validation(Required=false)]
            public string TextSplitterName { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KnowledgeBaseNotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource not found kb-***</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The unique request ID. Provide this ID for troubleshooting if an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
