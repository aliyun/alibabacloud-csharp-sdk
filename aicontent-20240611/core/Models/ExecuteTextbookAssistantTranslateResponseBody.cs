// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantTranslateResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned by the API.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantTranslateResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantTranslateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The result object.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantTranslateResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantTranslateResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The translated text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>根据文章，迈克·布莱克是如何介绍自己的？</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
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
        /// <para>9EB79C1E-36C2-5777-BED6-C23A98DF0637</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
