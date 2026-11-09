// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class SetAgentCreditQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The list of Agent IDs.</para>
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

        /// <summary>
        /// <para>The operator scenarios type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified or is set to NaturalMonthlyOwn: calendar month exclusive.</description></item>
        /// <item><description>JzYearlyShare: Jiaozi yearly shared.</description></item>
        /// <item><description>JzYearlyOwn: Jiaozi yearly exclusive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NaturalMonthlyOwn</para>
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

    }

}
