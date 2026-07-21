// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantSuggestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantSuggestionResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantSuggestionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The result data.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantSuggestionResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantSuggestionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The response from the AI teacher in Chinese.</para>
                /// 
                /// <b>Example:</b>
                /// <para>根据文章，迈克·布莱克是如何介绍自己的？</para>
                /// </summary>
                [NameInMap("chineseResult")]
                [Validation(Required=false)]
                public string ChineseResult { get; set; }

                /// <summary>
                /// <para>The response from the AI teacher in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Good evening! From the book, how does Mike Black introduce himself?</para>
                /// </summary>
                [NameInMap("englishResult")]
                [Validation(Required=false)]
                public string EnglishResult { get; set; }

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
        /// <para>null</para>
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
        [NameInMap("httpstatusCode")]
        [Validation(Required=false)]
        public int? HttpstatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D7D382F-9475-572E-BE83-DDFBF5C5EB24</para>
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
