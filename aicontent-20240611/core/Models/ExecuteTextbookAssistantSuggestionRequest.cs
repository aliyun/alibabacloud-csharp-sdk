// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantSuggestionRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier for the AI teacher\&quot;s message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b4b54c5268c1b78638</para>
        /// </summary>
        [NameInMap("assistant")]
        [Validation(Required=false)]
        public string Assistant { get; set; }

        /// <summary>
        /// <para>The authorization token for the API call. To obtain this token, call the operation that generates authorization tokens for the AI teacher feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The unique identifier for the current chat.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b4b54c5268c1b78638</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The practice scenario. Valid values are <c>SYNC</c> for synchronous practice and <c>EXPAND</c> for extended practice.</para>
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
