// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The path of the WAF quota, for example:</para>
        /// <list type="bullet">
        /// <item><description>managed_rules_group: represents the quota for the WAF managed rules group</description></item>
        /// <item><description>list: represents the quota for custom lists</description></item>
        /// <item><description>page: represents the quota for custom response pages</description></item>
        /// <item><description>scene_policy: represents the quota for scenario protection</description></item>
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
