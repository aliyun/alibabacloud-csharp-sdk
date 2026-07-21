// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantDialogueResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantDialogueResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantDialogueResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Textbook Assistant\&quot;s message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6788f4935bdfc807f077a984</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The chat ID for this turn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6788e0b475a4631ffc626722</para>
            /// </summary>
            [NameInMap("chatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantDialogueResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantDialogueResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The Textbook Assistant\&quot;s reply in Chinese.</para>
                /// 
                /// <b>Example:</b>
                /// <para>让我们再看一遍课文。迈克说: “我是迈克·布莱克。”你能试着像迈克那样说吗？</para>
                /// </summary>
                [NameInMap("chineseResult")]
                [Validation(Required=false)]
                public string ChineseResult { get; set; }

                /// <summary>
                /// <para>The Textbook Assistant\&quot;s reply in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Let\&quot;s look at the text again. Mike says, \&quot;I\&quot;m Mike Black.\&quot; Can you try saying it like Mike?</para>
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
                /// <para>Indicates whether the task is completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isTaskCompleted")]
                [Validation(Required=false)]
                public bool? IsTaskCompleted { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user\&quot;s reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6788f4905bdfc807f077a982</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
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
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBFA232A-1176-50E6-95AE-50F7A62A28AD</para>
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
        public string Success { get; set; }

    }

}
