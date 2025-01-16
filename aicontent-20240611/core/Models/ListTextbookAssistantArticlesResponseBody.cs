// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantArticlesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantArticlesResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantArticlesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0c05700d4d9411efbe6e0c42a106bb02</para>
            /// </summary>
            [NameInMap("articleId")]
            [Validation(Required=false)]
            public string ArticleId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>70412360-4272-571A-827D-84C2C07C450F</para>
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
