// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetVulScanScheduledStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The vulnerability scheduled scan policy ID. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVulScanScheduledStrategies~~">ListVulScanScheduledStrategies</a>: Lists vulnerability scheduled scan policies.</description></item>
        /// <item><description><a href="~~CreateVulScanScheduledStrategy~~">CreateVulScanScheduledStrategy</a>: Creates a vulnerability scheduled scan policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul-scan-scheduled-strategy-8a3f6c2e91b7****</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
