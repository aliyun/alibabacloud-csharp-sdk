// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the managed rule. Valid values:
        /// 
        /// *   true: enables the managed rule.
        /// *   false: does not enable the managed rule. This is the default value.
        /// 
        /// >  After you create an evaluation rule, a managed rule that has the same settings as the evaluation rule is created. After you create a resource, the managed rule can be used to continuously check the compliance of the resource.
        /// </summary>
        [NameInMap("EnableManagedRules")]
        [Validation(Required=false)]
        public bool? EnableManagedRules { get; set; }

        /// <summary>
        /// The resources that you want to evaluate.
        /// </summary>
        [NameInMap("ResourceEvaluateItems")]
        [Validation(Required=false)]
        public string ResourceEvaluateItemsShrink { get; set; }

    }

}
