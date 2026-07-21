// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class GetAITeacherSyncDialogueSuggestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The object that contains the result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAITeacherSyncDialogueSuggestionResponseBodyData Data { get; set; }
        public class GetAITeacherSyncDialogueSuggestionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The assistant\&quot;s suggestion in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>谢谢莉莉.你喜欢吃肉吗，莉莉？</para>
            /// </summary>
            [NameInMap("chineseResult")]
            [Validation(Required=false)]
            public string ChineseResult { get; set; }

            /// <summary>
            /// <para>The assistant\&quot;s suggestion in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Thanks, Lily. Do you like meat, Lily?</para>
            /// </summary>
            [NameInMap("englishResult")]
            [Validation(Required=false)]
            public string EnglishResult { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
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
        /// <para>A unique identifier for the request.</para>
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
