// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantSseDialogueResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>67e4c9d95bdfc83cd742ae7c</para>
        /// </summary>
        [NameInMap("assistant")]
        [Validation(Required=false)]
        public string Assistant { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67e374acb54c526c95c4fbd4</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantSseDialogueResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantSseDialogueResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Thanks, Lily. Do you like meat, Lily?</para>
            /// </summary>
            [NameInMap("englishResult")]
            [Validation(Required=false)]
            public string EnglishResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BIZ_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>67e4c9d6b54c526c95c53925</para>
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
