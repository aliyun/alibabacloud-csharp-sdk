// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyTaskParamsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy task.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSoarStrategyTasks~~">DescribeSoarStrategyTasks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StrategyTaskId")]
        [Validation(Required=false)]
        public long? StrategyTaskId { get; set; }

    }

}
