// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetContainerDefenseRuleDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the rule.
        /// 
        /// >  You can call the [ListContainerDefenseRule](~~xx~~) operation to obtain the IDs of rules.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
