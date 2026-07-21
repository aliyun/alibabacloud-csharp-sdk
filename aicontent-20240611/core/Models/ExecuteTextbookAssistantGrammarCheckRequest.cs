// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantGrammarCheckRequest : TeaModel {
        /// <summary>
        /// <para>The authorization token for the API call. Obtain this token by calling the &quot;Authorization token for the Textbook-style AI English Teacher&quot; API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The ID of the current conversation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b475a4631ffc626722</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The use case. Valid values: <c>SYNC</c> for synchronous practice and <c>EXPAND</c> for expansion practice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The message ID of the user\&quot;s reply.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b45bdfc807f077a5a1</para>
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
