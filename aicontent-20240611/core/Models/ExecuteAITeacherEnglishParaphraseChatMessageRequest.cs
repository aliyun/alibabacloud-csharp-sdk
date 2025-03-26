// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherEnglishParaphraseChatMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6788e0b475a4631ffc626722</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>How much is this?</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("grade")]
        [Validation(Required=false)]
        public long? Grade { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxxxx</para>
        /// </summary>
        [NameInMap("questionId")]
        [Validation(Required=false)]
        public string QuestionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>How to inquire about the price</para>
        /// </summary>
        [NameInMap("questionInfo")]
        [Validation(Required=false)]
        public string QuestionInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sreaming</para>
        /// </summary>
        [NameInMap("responseMode")]
        [Validation(Required=false)]
        public string ResponseMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>How much is this?</para>
        /// </summary>
        [NameInMap("userAnswer")]
        [Validation(Required=false)]
        public string UserAnswer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
