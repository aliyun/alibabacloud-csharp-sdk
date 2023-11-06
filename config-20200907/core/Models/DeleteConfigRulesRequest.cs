// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteConfigRulesRequest : TeaModel {
        /// <summary>
        /// The rule IDs. Separate multiple rule IDs with commas (,).
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListConfigRules](~~609222~~).
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
