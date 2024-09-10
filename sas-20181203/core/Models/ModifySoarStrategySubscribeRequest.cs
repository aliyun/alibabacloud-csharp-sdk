// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySoarStrategySubscribeRequest : TeaModel {
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

        /// <summary>
        /// Specifies whether to create the policy template. Valid values:
        /// 
        /// *   true: creates the policy template
        /// *   false: deletes the policy template
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubscribeStatus")]
        [Validation(Required=false)]
        public bool? SubscribeStatus { get; set; }

    }

}
