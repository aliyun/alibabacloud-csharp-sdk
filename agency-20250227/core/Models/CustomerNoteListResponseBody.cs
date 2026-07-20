// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class CustomerNoteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error returned by the POP API when the caller does not have the required RAM permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CustomerNoteListResponseBodyData Data { get; set; }
        public class CustomerNoteListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the access denied error returned by the POP API when the caller does not have the required RAM permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("AccessDeniedDetail")]
            [Validation(Required=false)]
            public string AccessDeniedDetail { get; set; }

            /// <summary>
            /// <para>The result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<CustomerNoteListResponseBodyDataData> Data { get; set; }
            public class CustomerNoteListResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The name of the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The UID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1757916424103619</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public long? Creator { get; set; }

                /// <summary>
                /// <para>The logon name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The creation time in the format of yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-17 12:18:23</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The content of the note.</para>
                /// 
                /// <b>Example:</b>
                /// <para>讨论技术方案</para>
                /// </summary>
                [NameInMap("NoteContent")]
                [Validation(Required=false)]
                public string NoteContent { get; set; }

                /// <summary>
                /// <para>The ID of the note.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2932252</para>
                /// </summary>
                [NameInMap("NoteId")]
                [Validation(Required=false)]
                public long? NoteId { get; set; }

                /// <summary>
                /// <para>The type of the note (CUSTOMER).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOMER</para>
                /// </summary>
                [NameInMap("NoteType")]
                [Validation(Required=false)]
                public string NoteType { get; set; }

                /// <summary>
                /// <para>The label of the note type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户</para>
                /// </summary>
                [NameInMap("NoteTypeLabel")]
                [Validation(Required=false)]
                public string NoteTypeLabel { get; set; }

                /// <summary>
                /// <para>The touch date (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1784266662000</para>
                /// </summary>
                [NameInMap("TouchDate")]
                [Validation(Required=false)]
                public string TouchDate { get; set; }

            }

            /// <summary>
            /// <para>The HTTP status code returned by the POP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("HttpStatusCode")]
            [Validation(Required=false)]
            public int? HttpStatusCode { get; set; }

            /// <summary>
            /// <para>The prompt message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The prompt message, same as message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The pagination information compatible with the legacy interface (deprecated).</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public CustomerNoteListResponseBodyDataPageInfo PageInfo { get; set; }
            public class CustomerNoteListResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
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
                /// <para>20</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned by the POP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The prompt message, same as message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
