// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesRequest : TeaModel {
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
        public List<EvaluatePreConfigRulesRequestResourceEvaluateItems> ResourceEvaluateItems { get; set; }
        public class EvaluatePreConfigRulesRequestResourceEvaluateItems : TeaModel {
            /// <summary>
            /// The logical ID of the resource.
            /// </summary>
            [NameInMap("ResourceLogicalId")]
            [Validation(Required=false)]
            public string ResourceLogicalId { get; set; }

            /// <summary>
            /// The properties of the resource.
            /// </summary>
            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public string ResourceProperties { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The evaluation rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<EvaluatePreConfigRulesRequestResourceEvaluateItemsRules> Rules { get; set; }
            public class EvaluatePreConfigRulesRequestResourceEvaluateItemsRules : TeaModel {
                /// <summary>
                /// The identifier of the evaluation rule.
                /// 
                /// For more information about how to obtain the identifier of an evaluation rule, see [ListManagedRules](~~467810~~).
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// The input parameters of the evaluation rule.
                /// </summary>
                [NameInMap("InputParameters")]
                [Validation(Required=false)]
                public string InputParameters { get; set; }

            }

        }

    }

}
