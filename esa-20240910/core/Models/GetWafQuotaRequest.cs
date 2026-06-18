// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The path of the WAF quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>managed_rules_group: The quota for managed rule groups.</para>
        /// </description></item>
        /// <item><description><para>list: The quota for custom lists.</para>
        /// </description></item>
        /// <item><description><para>page: The quota for custom response pages.</para>
        /// </description></item>
        /// <item><description><para>scene_policy: The quota for scene-based protection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>page</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public string Paths { get; set; }

    }

}
