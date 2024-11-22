// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The type of WAF resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>managed_rules_group: the managed rule group.</description></item>
        /// <item><description>list: the custom list.</description></item>
        /// <item><description>page: the custom error page.</description></item>
        /// <item><description>scene_policy: the scenario-specific policy.</description></item>
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
