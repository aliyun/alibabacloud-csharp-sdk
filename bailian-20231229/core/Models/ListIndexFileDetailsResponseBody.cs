// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndexFileDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIndexFileDetailsResponseBodyData Data { get; set; }
        public class ListIndexFileDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of documents in the knowledge base. The documents are sorted by import time in descending order. This order is the same as the order in the console.</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<ListIndexFileDetailsResponseBodyDataDocuments> Documents { get; set; }
            public class ListIndexFileDetailsResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>The custom chunking method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DashSplitter</para>
                /// </summary>
                [NameInMap("ChunkMode")]
                [Validation(Required=false)]
                public string ChunkMode { get; set; }

                /// <summary>
                /// <para>The length of a chunk, in characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public string ChunkSize { get; set; }

                /// <summary>
                /// <para>The error code that is returned if the document fails to be imported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110002</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The format of the document. Valid values: pdf, docx, doc, txt, md, pptx, ppt, png, jpg, jpeg, bmp, gif, and EXCEL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("DocumentType")]
                [Validation(Required=false)]
                public string DocumentType { get; set; }

                /// <summary>
                /// <para>Indicates whether the table headers of Excel files in an unstructured knowledge base are concatenated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableHeaders")]
                [Validation(Required=false)]
                public string EnableHeaders { get; set; }

                /// <summary>
                /// <para>The time when the document was imported. This value is a Unix timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744856423000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc_c134aa2073204a5d936d870bf960f56axxxxxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The error message that is returned if the document fails to be imported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>check fileUrlKey[file_path] / fileNameKey[null] / fileExtensionKey[file_extension] is invalid</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>翻译平台运维文档</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The overlap length of chunks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OverlapSize")]
                [Validation(Required=false)]
                public string OverlapSize { get; set; }

                /// <summary>
                /// <para>The size of the document, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>996764</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate_21a407a3372c4ba7aedc649709143f0cxxxxxxxx</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The import status of the document. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>INSERT_ERROR: The document failed to be imported.</para>
                /// </description></item>
                /// <item><description><para>RUNNING: The document is being imported.</para>
                /// </description></item>
                /// <item><description><para>DELETED: The document has been deleted.</para>
                /// </description></item>
                /// <item><description><para>FINISH: The document was imported successfully.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The sentence separator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot; &quot;</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

            }

            /// <summary>
            /// <para>The knowledge base ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79c0alxxxx</para>
            /// </summary>
            [NameInMap("IndexId")]
            [Validation(Required=false)]
            public string IndexId { get; set; }

            /// <summary>
            /// <para>The returned page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2437</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Required parameter(%s) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35A267BF-xxxx-54DB-8394-AA3B0742D833</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
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
