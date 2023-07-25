// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ActiveConfigRulesRequest : TeaModel {
        /// <summary>
        /// The rule IDs. Separate multiple rule IDs with commas (,). You can specify a maximum of 20 rule IDs at a time.
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
