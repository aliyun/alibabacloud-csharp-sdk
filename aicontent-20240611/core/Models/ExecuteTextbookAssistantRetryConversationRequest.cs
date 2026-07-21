// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantRetryConversationRequest : TeaModel {
        /// <summary>
        /// <para>The AI assistant\&quot;s message ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b4b54c5268c1b78638</para>
        /// </summary>
        [NameInMap("assistant")]
        [Validation(Required=false)]
        public string Assistant { get; set; }

        /// <summary>
        /// <para>The authorization token. You can obtain this token from the API that provides authorization for the textbook AI assistant feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The conversation ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b475a4631ffc626722</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>Specifies the scenario. Valid values: <c>SYNC</c> for synchronized practice and <c>EXPAND</c> for expansion practice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

    }

}
