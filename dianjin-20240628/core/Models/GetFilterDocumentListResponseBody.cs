// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetFilterDocumentListResponseBody : TeaModel {
        /// <summary>
        /// <para>Time spent on the request, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetFilterDocumentListResponseBodyData Data { get; set; }
        public class GetFilterDocumentListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Records.</para>
            /// </summary>
            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetFilterDocumentListResponseBodyDataRecords> Records { get; set; }
            public class GetFilterDocumentListResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>Document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29368126816</para>
                /// </summary>
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>Document metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;: &quot;1&quot;}</para>
                /// </summary>
                [NameInMap("documentMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> DocumentMeta { get; set; }

                /// <summary>
                /// <para>File type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Document library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sdfgsjdfg</para>
                /// </summary>
                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                /// <summary>
                /// <para>Document status. Valid values: WaitRefresh (waiting for refresh), InQueue (pending), FetchingData (retrieving data), Embedding (processing document), Error (failed), Completed (active), Null (unknown).</para>
                /// 
                /// <b>Example:</b>
                /// <para>WaitRefresh</para>
                /// </summary>
                [NameInMap("statusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>Document title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公司文档</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Document URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <para>Data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ADF010C-FD89-569D-A079-2D4D5247E943</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
