// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantBooksResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListTextbookAssistantBooksResponseBodyData Data { get; set; }
        public class ListTextbookAssistantBooksResponseBodyData : TeaModel {
            [NameInMap("bookList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantBooksResponseBodyDataBookList> BookList { get; set; }
            public class ListTextbookAssistantBooksResponseBodyDataBookList : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>231698</para>
                /// </summary>
                [NameInMap("bookId")]
                [Validation(Required=false)]
                public string BookId { get; set; }

                [NameInMap("bookName")]
                [Validation(Required=false)]
                public string BookName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("coverImage")]
                [Validation(Required=false)]
                public string CoverImage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-7（1）</para>
                /// </summary>
                [NameInMap("edition")]
                [Validation(Required=false)]
                public string Edition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("grade")]
                [Validation(Required=false)]
                public string Grade { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-7（1）</para>
                /// </summary>
                [NameInMap("impression")]
                [Validation(Required=false)]
                public string Impression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9787107382505</para>
                /// </summary>
                [NameInMap("isbn")]
                [Validation(Required=false)]
                public string Isbn { get; set; }

                [NameInMap("publisher")]
                [Validation(Required=false)]
                public string Publisher { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ENGLISH</para>
                /// </summary>
                [NameInMap("subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("volume")]
                [Validation(Required=false)]
                public string Volume { get; set; }

            }

            [NameInMap("paginationData")]
            [Validation(Required=false)]
            public ListTextbookAssistantBooksResponseBodyDataPaginationData PaginationData { get; set; }
            public class ListTextbookAssistantBooksResponseBodyDataPaginationData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("currentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("maxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B_USER_NOT_FOUND_EXCEPTION</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B695B377-7029-5805-9DE2-1AAE06C1BF6B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
