// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ReconnectAppChatRequest : TeaModel {
        /// <summary>
        /// <para>The chat record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20833ba4-d189-4c50-9a44-a6bcbda2c93b</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b7105a2-2999-430b-ba23-ba09149d5434</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The ID of the last event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LastEventId")]
        [Validation(Required=false)]
        public int? LastEventId { get; set; }

        /// <summary>
        /// <para>The creation time of the latest message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-28 10:25:41</para>
        /// </summary>
        [NameInMap("LatestMessageCreateTime")]
        [Validation(Required=false)]
        public string LatestMessageCreateTime { get; set; }

    }

}
