// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class GetAITeacherExpansionDialogueSuggestionResponseBody : TeaModel {
        /// <summary>
        /// <para>A container for the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAITeacherExpansionDialogueSuggestionResponseBodyData Data { get; set; }
        public class GetAITeacherExpansionDialogueSuggestionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Chinese translation of the suggested response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>谢谢莉莉.你喜欢吃肉吗，莉莉？</para>
            /// </summary>
            [NameInMap("chineseResult")]
            [Validation(Required=false)]
            public string ChineseResult { get; set; }

            /// <summary>
            /// <para>The suggested response in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Thanks, Lily. Do you like meat, Lily?</para>
            /// </summary>
            [NameInMap("englishResult")]
            [Validation(Required=false)]
            public string EnglishResult { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
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
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
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
