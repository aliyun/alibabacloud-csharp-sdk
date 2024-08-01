// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ActiveConfigRulesRequest : TeaModel {
        /// <summary>
        /// The rule ID. Separate multiple rule IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
