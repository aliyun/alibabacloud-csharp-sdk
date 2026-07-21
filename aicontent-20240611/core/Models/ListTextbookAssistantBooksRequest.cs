// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantBooksRequest : TeaModel {
        /// <summary>
        /// <para>The authorization token for the API call. You can obtain this token by calling the authorization API for the AI textbook assistant feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_197bf5bb81889cc79eb51ae9b8c0cea3</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

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
        /// <para>The grade level. The value is a string from &quot;1&quot; to &quot;9&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("grade")]
        [Validation(Required=false)]
        public string Grade { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page. The value cannot exceed 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public string Page { get; set; }

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
        /// <para>The volume. Valid values: 0 (all-in-one volume), 1 (first volume), and 2 (second volume).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("volume")]
        [Validation(Required=false)]
        public string Volume { get; set; }

    }

}
