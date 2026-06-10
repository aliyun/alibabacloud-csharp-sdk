// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppConversationRequest : TeaModel {
        /// <summary>
        /// <para>Bot ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zero2</para>
        /// </summary>
        [NameInMap("BotId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>81bc5a34-1d8d-4ef7-a208-7401c51b054b</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

    }

}
