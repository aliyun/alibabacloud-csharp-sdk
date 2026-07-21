// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantSseDialogueRequest : TeaModel {
        /// <summary>
        /// <para>The authorization token for the API call. Obtain this token from the authorization API for the AI teacher feature.</para>
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
        /// <para>67e374acb54c526c95c4fbd4</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The scenario. Set the value to SYNC for Synchronous Practice or EXPAND for Expansion Practice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXPAND</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The content of the user\&quot;s message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("userMessage")]
        [Validation(Required=false)]
        public string UserMessage { get; set; }

    }

}
