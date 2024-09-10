// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSoarStrategyTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the policy task that is in the waiting state.
        /// 
        /// >  You can call the [DescribeSoarStrategyTasks](~~DescribeSoarStrategyTasks~~) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyTaskId")]
        [Validation(Required=false)]
        public long? StrategyTaskId { get; set; }

    }

}
