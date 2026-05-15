// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateRateLimitRuleInput : TeaModel {
        /// <summary>
        /// <para>是否启用该限流规则</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>限流时间窗口配置列表，提供时将整组覆盖</para>
        /// </summary>
        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<WindowLimit> Windows { get; set; }

    }

}
