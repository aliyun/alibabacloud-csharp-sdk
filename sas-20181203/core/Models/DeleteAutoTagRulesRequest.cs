// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteAutoTagRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the asset auto-tagging rule. Separate multiple IDs with commas (,).
        /// 
        /// >  You can call the [ListAutoTagRules](~~ListAutoTagRules~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleIdList")]
        [Validation(Required=false)]
        public string RuleIdList { get; set; }

    }

}
