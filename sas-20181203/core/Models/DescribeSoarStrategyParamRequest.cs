// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyParamRequest : TeaModel {
        /// <summary>
        /// The ID of the policy.
        /// 
        /// >  You can call the [DescribeSoarStrategies](~~DescribeSoarStrategies~~) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
