// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartRemediationRequest : TeaModel {
        /// <summary>
        /// The ID of the rule.
        /// 
        /// You can call the [ListConfigRules](~~169607~~) operation to obtain the rule ID.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

    }

}
