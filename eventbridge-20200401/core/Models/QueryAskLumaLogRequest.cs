// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryAskLumaLogRequest : TeaModel {
        /// <summary>
        /// <para>The cursor. Set this parameter to the messageId of the last entry on the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ0cyI6MTcxN...</para>
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public string After { get; set; }

        /// <summary>
        /// <para>The agent name. If this parameter is not specified, logs of all agents are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-luma-agent</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The number of entries to return. Default value: 20. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

    }

}
