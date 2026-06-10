// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAIStaffChatEventsRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Chat ID (optional; if not provided, the latest chatId is used)</para>
        /// 
        /// <b>Example:</b>
        /// <para>20833ba4-d189-4c50-9a44-a6bcbda2c93b</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>593fe1a2-d0b4-4fde-a2b0-78ad6a438d41</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>Last event ID, used for incremental retrieval</para>
        /// 
        /// <b>Example:</b>
        /// <para>event-71ece53b7d474e01b755a9b5fa5305e6</para>
        /// </summary>
        [NameInMap("LastEventId")]
        [Validation(Required=false)]
        public int? LastEventId { get; set; }

    }

}
