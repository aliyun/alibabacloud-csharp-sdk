// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListIMBotsRequest : TeaModel {
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        [NameInMap("botBizType")]
        [Validation(Required=false)]
        public string BotBizType { get; set; }

        [NameInMap("botName")]
        [Validation(Required=false)]
        public string BotName { get; set; }

        /// <summary>
        /// <para>默认 1；传入时须 ≥ 1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>默认 20；传入时须 1–100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
