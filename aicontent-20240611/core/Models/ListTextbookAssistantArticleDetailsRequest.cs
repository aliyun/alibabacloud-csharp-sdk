// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantArticleDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The list of article IDs.</para>
        /// </summary>
        [NameInMap("articleIdList")]
        [Validation(Required=false)]
        public List<string> ArticleIdList { get; set; }

        /// <summary>
        /// <para>The authorization code for API calls. You can obtain this code by calling the operation that retrieves the authorization code for the English textbook-style AI teacher feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

    }

}
