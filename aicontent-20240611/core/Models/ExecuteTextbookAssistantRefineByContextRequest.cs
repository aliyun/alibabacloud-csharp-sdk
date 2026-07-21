// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantRefineByContextRequest : TeaModel {
        /// <summary>
        /// <para>The authorization token for the API call. You can obtain this token by calling the authorization API for the &quot;English Textbook AI Teacher&quot; feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The conversation ID for the current turn.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788e0b475a4631ffc626722</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>Specifies the scenario. Valid values are <c>SYNC</c> for synchronous practice and <c>EXPAND</c> for expansion practice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The ID of the user\&quot;s message.</para>
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
