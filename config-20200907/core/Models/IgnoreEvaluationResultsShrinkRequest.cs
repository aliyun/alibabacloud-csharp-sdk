// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class IgnoreEvaluationResultsShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the rule.
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListConfigRules](https://help.aliyun.com/document_detail/169607.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The date from which the system automatically re-evaluates the ignored incompliant resources.
        /// 
        /// >  If you leave this parameter empty, the system does not automatically re-evaluate the ignored incompliant resources. You must manually re-evaluate the ignored incompliant resources.
        /// </summary>
        [NameInMap("IgnoreDate")]
        [Validation(Required=false)]
        public string IgnoreDate { get; set; }

        /// <summary>
        /// The reason why you want to ignore the resource.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The resources to be ignored.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string ResourcesShrink { get; set; }

    }

}
