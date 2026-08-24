// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetVirusScanScheduledStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scheduled virus scan policy. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusScanScheduledStrategies~~">ListVirusScanScheduledStrategies</a>: Lists scheduled virus scan policies.</description></item>
        /// <item><description><a href="~~CreateVirusScanScheduledStrategy~~">CreateVirusScanScheduledStrategy</a>: Creates a scheduled virus scan policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vc-strategy-8a3f6c2e91b7****</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
