// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantBookDirectoriesRequest : TeaModel {
        /// <summary>
        /// <para>The API authorization token. You can obtain this token from the authorization API for the AI English teacher feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The book ID. You can obtain this ID from the API for retrieving English textbooks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231698</para>
        /// </summary>
        [NameInMap("bookId")]
        [Validation(Required=false)]
        public string BookId { get; set; }

        /// <summary>
        /// <para>The exercise scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

    }

}
