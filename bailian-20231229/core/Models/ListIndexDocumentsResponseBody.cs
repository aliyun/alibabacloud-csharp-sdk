// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndexDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code</para>
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
        public ListIndexDocumentsResponseBodyData Data { get; set; }
        public class ListIndexDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of documents in the knowledge base.</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<ListIndexDocumentsResponseBodyDataDocuments> Documents { get; set; }
            public class ListIndexDocumentsResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>The error status code of document import.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110002</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The format of the document. Valid values: pdf, docx, doc, txt, md, pptx, ppt, and EXCEL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("DocumentType")]
                [Validation(Required=false)]
                public string DocumentType { get; set; }

                /// <summary>
                /// <para>The primary key ID of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc_c134aa2073204a5d936d870bf960f56a10024701</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The error message of document import.</para>
                /// 
                /// <b>Example:</b>
                /// <para>check fileUrlKey[file_path] / fileNameKey[null] / fileExtensionKey[file_extension] is invalid</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the document.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The size of the document. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>996764</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>For unstructured knowledge base, this parameter is the category ID, which is the <c>CategoryId</c> returned by the <a href="https://help.aliyun.com/zh/model-studio/developer-reference/api-bailian-2023-12-29-addcategory">AddCategory</a> interface. To view the category ID, you can click the ID icon next to the category name on the Unstructured Data tab of the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> page.</para>
                /// <para>For structured knowledge base, this parameter is the data table ID. To view the table ID, you can click the ID icon next to the table name on the Structured Data tab of the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate_21a407a3372c4ba7aedc649709143f0c10021401</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The import status of the document. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INSERT_ERROR</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>DELETED</description></item>
                /// <item><description>FINISH</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The primary key ID of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pno97tn8iu</para>
            /// </summary>
            [NameInMap("IndexId")]
            [Validation(Required=false)]
            public string IndexId { get; set; }

            /// <summary>
            /// <para>The specified page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The specified number of documents on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of documents returned.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35A267BF-xxxx-54DB-8394-AA3B0742D833</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indications whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
