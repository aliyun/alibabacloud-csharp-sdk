// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantStartConversationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantStartConversationResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantStartConversationResponseBodyData : TeaModel {
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
            public ExecuteTextbookAssistantStartConversationResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantStartConversationResponseBodyDataResult : TeaModel {
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
        /// <para>B_USER_NOT_FOUND_EXCEPTION</para>
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
        /// <para>6F73C114-A76E-51AD-99E3-BC7B941B69E0</para>
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
