// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantBooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object in the response.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListTextbookAssistantBooksResponseBodyData Data { get; set; }
        public class ListTextbookAssistantBooksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of book objects.</para>
            /// </summary>
            [NameInMap("bookList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantBooksResponseBodyDataBookList> BookList { get; set; }
            public class ListTextbookAssistantBooksResponseBodyDataBookList : TeaModel {
                /// <summary>
                /// <para>The author.</para>
                /// 
                /// <b>Example:</b>
                /// <para>吴欣</para>
                /// </summary>
                [NameInMap("author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <para>The book ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>231698</para>
                /// </summary>
                [NameInMap("bookId")]
                [Validation(Required=false)]
                public string BookId { get; set; }

                /// <summary>
                /// <para>The book name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>K12英语-人教版PEP三起-三年级上册</para>
                /// </summary>
                [NameInMap("bookName")]
                [Validation(Required=false)]
                public string BookName { get; set; }

                /// <summary>
                /// <para>The cover image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("coverImage")]
                [Validation(Required=false)]
                public string CoverImage { get; set; }

                /// <summary>
                /// <para>The edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-7（1）</para>
                /// </summary>
                [NameInMap("edition")]
                [Validation(Required=false)]
                public string Edition { get; set; }

                /// <summary>
                /// <para>The grade. Valid values are strings from <c>&quot;1&quot;</c> to <c>&quot;9&quot;</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("grade")]
                [Validation(Required=false)]
                public string Grade { get; set; }

                /// <summary>
                /// <para>The impression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-7（1）</para>
                /// </summary>
                [NameInMap("impression")]
                [Validation(Required=false)]
                public string Impression { get; set; }

                /// <summary>
                /// <para>The International Standard Book Number (ISBN).</para>
                /// 
                /// <b>Example:</b>
                /// <para>9787107382505</para>
                /// </summary>
                [NameInMap("isbn")]
                [Validation(Required=false)]
                public string Isbn { get; set; }

                /// <summary>
                /// <para>The publisher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>人民教育出版社</para>
                /// </summary>
                [NameInMap("publisher")]
                [Validation(Required=false)]
                public string Publisher { get; set; }

                /// <summary>
                /// <para>The subject.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENGLISH</para>
                /// </summary>
                [NameInMap("subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                /// <summary>
                /// <para>The textbook version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>人教版</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The volume. Valid values: <c>&quot;0&quot;</c> (all-in-one), <c>&quot;1&quot;</c> (first semester), and <c>&quot;2&quot;</c> (second semester).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("volume")]
                [Validation(Required=false)]
                public string Volume { get; set; }

            }

            /// <summary>
            /// <para>The pagination data.</para>
            /// </summary>
            [NameInMap("paginationData")]
            [Validation(Required=false)]
            public ListTextbookAssistantBooksResponseBodyDataPaginationData PaginationData { get; set; }
            public class ListTextbookAssistantBooksResponseBodyDataPaginationData : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("currentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The maximum number of items per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("maxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <para>The total number of items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B_USER_NOT_FOUND_EXCEPTION</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户不存在</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B695B377-7029-5805-9DE2-1AAE06C1BF6B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
