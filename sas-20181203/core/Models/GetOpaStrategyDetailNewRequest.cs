// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaStrategyDetailNewRequest : TeaModel {
        /// <summary>
        /// The rule ID.
        /// 
        /// >  You can call the [ListOpaClusterStrategyNew](~~2623574~~) operation to obtain the rule ID.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
