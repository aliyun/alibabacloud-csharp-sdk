// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class SetAgentCreditQuotaRequest : TeaModel {
        /// <summary>
        /// <para>A list of Agent IDs.</para>
        /// </summary>
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public List<string> AgentIds { get; set; }

        /// <summary>
        /// <para>The Agent type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JVSClaw</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUSINESS</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The credit quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("CreditQuota")]
        [Validation(Required=false)]
        public int? CreditQuota { get; set; }

    }

}
