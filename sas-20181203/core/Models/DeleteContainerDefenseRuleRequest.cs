// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteContainerDefenseRuleRequest : TeaModel {
        /// <summary>
        /// The IDs of the rules that you want to delete.
        /// 
        /// >  You can call the [ListContainerDefenseRule](~~2590599~~) operation to query the rule IDs.
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<long?> RuleIds { get; set; }

    }

}
