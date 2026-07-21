// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantDialogueRequest : TeaModel {
        /// <summary>
        /// <para>The authorization token required to call the API. To get this token, use the Textbook Assistant authorization API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b475a4631ffc626722</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The chat ID for this turn.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b475a4631ffc626722</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The scenario. Valid values: SYNC for synchronous practice and EXPAND for extended practice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The user\&quot;s message content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("userMessage")]
        [Validation(Required=false)]
        public string UserMessage { get; set; }

    }

}
