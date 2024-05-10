// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// The rule ID.
        /// 
        /// >  You can call the ListContainerWebDefenseRule operation to query the rule ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
