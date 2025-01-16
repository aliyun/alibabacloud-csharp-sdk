// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantRetryConversationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantRetryConversationResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantRetryConversationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6788e0b4b54c5268c1b78638</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6788e0b475a4631ffc626722</para>
            /// </summary>
            [NameInMap("chatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantRetryConversationResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantRetryConversationResponseBodyDataResult : TeaModel {
                [NameInMap("chineseResult")]
                [Validation(Required=false)]
                public string ChineseResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Good evening! From the book, how does Mike Black introduce himself?</para>
                /// </summary>
                [NameInMap("englishResult")]
                [Validation(Required=false)]
                public string EnglishResult { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6788e0b45bdfc807f077a5a1</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
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
        /// <para>2F2ABF4B-A4F6-5EC7-B287-7EF5B156F1ED</para>
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
