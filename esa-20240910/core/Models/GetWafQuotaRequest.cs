// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The paths of WAF quotas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>managed_rules_group: the quota for WAF managed rule groups.</description></item>
        /// <item><description>list: the quota for custom lists.</description></item>
        /// <item><description>page: the quota for custom response pages.</description></item>
        /// <item><description>scene_policy: the quota for scenario-specific protection rules.</description></item>
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
