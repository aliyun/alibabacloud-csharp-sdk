// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class SetAgentCreditQuotaRequest : TeaModel {
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public List<string> AgentIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JVSClaw</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CreditQuota")]
        [Validation(Required=false)]
        public int? CreditQuota { get; set; }

    }

}
