// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ReconnectAppChatRequest : TeaModel {
        /// <summary>
        /// <para>Chat record ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>20833ba4-d189-4c50-9a44-a6bcbda2c93b</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b7105a2-2999-430b-ba23-ba09149d5434</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>Last management event ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>event-71ece53b7d474e01b755a9b5fa5305e6</para>
        /// </summary>
        [NameInMap("LastEventId")]
        [Validation(Required=false)]
        public int? LastEventId { get; set; }

    }

}
