// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateSwitchStatusRequest : TeaModel {
        /// <summary>
        /// The rule ID.
        /// 
        /// >  You can call the [ListContainerDefenseRule](~~2590599~~) operation to query the rule ID.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The rule status for container tamper-proofing. Valid values:
        /// - **on**
        /// - **off**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
