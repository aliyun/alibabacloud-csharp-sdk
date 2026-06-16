// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListIMBotsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent runtime.</para>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// <para>The business type of the bot.</para>
        /// </summary>
        [NameInMap("botBizType")]
        [Validation(Required=false)]
        public string BotBizType { get; set; }

        /// <summary>
        /// <para>The name of the IM bot. The system performs a case-insensitive substring search.</para>
        /// </summary>
        [NameInMap("botName")]
        [Validation(Required=false)]
        public string BotName { get; set; }

        /// <summary>
        /// <para>The page number. Must be greater than or equal to 1. Default: 1.</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1–100. Default: 20.</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the bot.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
