// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherExpansionDialogueResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteAITeacherExpansionDialogueResponseBodyData Data { get; set; }
        public class ExecuteAITeacherExpansionDialogueResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AI teacher\&quot;s response in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("chineseResult")]
            [Validation(Required=false)]
            public string ChineseResult { get; set; }

            /// <summary>
            /// <para>The AI teacher\&quot;s response in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("englishResult")]
            [Validation(Required=false)]
            public string EnglishResult { get; set; }

            /// <summary>
            /// <para>Indicates whether the dialogue is finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>Indicates whether the response is off-topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOffTopicControl")]
            [Validation(Required=false)]
            public bool? IsOffTopicControl { get; set; }

            /// <summary>
            /// <para>Indicates whether the response is on-topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOnTopic")]
            [Validation(Required=false)]
            public bool? IsOnTopic { get; set; }

            /// <summary>
            /// <para>The index of the current question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("questionIndex")]
            [Validation(Required=false)]
            public int? QuestionIndex { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
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
