// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndexDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data field returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIndexDocumentsResponseBodyData Data { get; set; }
        public class ListIndexDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of files in the knowledge base, sorted by file import time in descending order (consistent with the console).</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<ListIndexDocumentsResponseBodyDataDocuments> Documents { get; set; }
            public class ListIndexDocumentsResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>The error status code for the file import.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110002</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The file format type. Valid values: pdf, docx, doc, txt, md, pptx, ppt, png, jpg, jpeg, bmp, gif, and EXCEL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("DocumentType")]
                [Validation(Required=false)]
                public string DocumentType { get; set; }

                /// <summary>
                /// <para>The time when the file was imported to the knowledge base, in UNIX timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744856423000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc_c134aa2073204a5d936d870bf960f56axxxxxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The error message for the file import.</para>
                /// 
                /// <b>Example:</b>
                /// <para>check fileUrlKey[file_path] / fileNameKey[null] / fileExtensionKey[file_extension] is invalid</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product-overview</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The file size, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>996765</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <para>For document search or audio/video search knowledge bases, this parameter specifies the category ID, which is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also obtain the category ID by clicking the ID icon next to the category name on the Files tab of the <a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> page.</para>
                /// <para>For data query or image Q&amp;A knowledge bases, this parameter specifies the data table ID. You can obtain the data table ID by clicking the ID icon next to the data table name on the Tables tab of the <a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> page.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <para>For document search knowledge bases, this parameter specifies the category ID, which is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also obtain the category ID by clicking the ID icon next to the category name on the Files tab of the <a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> page.</para>
                /// <para>For data query or image Q&amp;A knowledge bases, this parameter specifies the data table ID. You can obtain the data table ID by clicking the ID icon next to the data table name on the Tables tab of the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page.</para>
                /// <para>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate_21a407a3372c4ba7aedc649709143f0cxxxxxxxx</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The file import status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INSERT_ERROR: The file failed to be imported.</description></item>
                /// <item><description>RUNNING: The file is being imported.</description></item>
                /// <item><description>DELETED: The file has been deleted.</description></item>
                /// <item><description>FINISH: The file was imported.</description></item>
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
            /// <para>The knowledge base ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pno97txxxx</para>
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
            /// <para>The returned number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned results.</para>
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
        /// <para>The status code returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The operation was successful.</description></item>
        /// <item><description>false: The operation failed.</description></item>
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
