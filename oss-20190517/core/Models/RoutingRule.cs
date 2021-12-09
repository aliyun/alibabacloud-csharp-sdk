// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RoutingRule : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public RoutingRuleCondition Condition { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public RoutingRuleRedirect Redirect { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("RuleNumber")]
        [Validation(Required=false)]
        public long? RuleNumber { get; set; }

    }

}
