// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantDialogueResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantDialogueResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantDialogueResponseBodyData : TeaModel {
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            [NameInMap("chatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantDialogueResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantDialogueResponseBodyDataResult : TeaModel {
                [NameInMap("chineseResult")]
                [Validation(Required=false)]
                public string ChineseResult { get; set; }

                [NameInMap("englishResult")]
                [Validation(Required=false)]
                public string EnglishResult { get; set; }

                [NameInMap("isFinish")]
                [Validation(Required=false)]
                public bool? IsFinish { get; set; }

                [NameInMap("isTaskCompleted")]
                [Validation(Required=false)]
                public bool? IsTaskCompleted { get; set; }

            }

            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
