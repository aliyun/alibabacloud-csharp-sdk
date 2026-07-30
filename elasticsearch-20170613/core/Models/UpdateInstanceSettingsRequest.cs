// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateInstanceSettingsRequest : TeaModel {
        /// <summary>
        /// <para>The YML file configuration of the instance.</para>
        /// </summary>
        [NameInMap("esConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> EsConfig { get; set; }

        /// <summary>
        /// <para>A unique token used to ensure the idempotence of the request. The client generates this value. The value must be unique among different requests and cannot exceed 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly apply the change.</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The change strategy for Elasticsearch (for example, the change method used during index updates, cluster upgrades, or service deployments). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>blue_green: blue-green change. Achieves seamless switchover by running two identical environments (blue and green) in parallel.</description></item>
        /// <item><description>normal: in-place change. Performs changes directly in the current environment (for example, upgrades or scaling) without requiring additional resources.</description></item>
        /// <item><description>intelligent: intelligent change. The system automatically analyzes the change type and environment state, and dynamically selects the optimal change method (blue-green change or in-place change).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("updateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

    }

}
