// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateRateLimitRuleInput : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the rate limit rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>A list of time window configurations. Providing this parameter replaces the entire existing list.</para>
        /// </summary>
        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<WindowLimit> Windows { get; set; }

    }

}
