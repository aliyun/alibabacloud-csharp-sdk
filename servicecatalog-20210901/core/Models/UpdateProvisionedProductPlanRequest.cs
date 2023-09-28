// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateProvisionedProductPlanRequest : TeaModel {
        /// <summary>
        /// The description of the plan.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// An array that consists of the parameters in the template.
        /// 
        /// Maximum value of N: 200.
        /// 
        /// > If you specify Parameters, you must specify ParameterKey and ParameterValue.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateProvisionedProductPlanRequestParameters> Parameters { get; set; }
        public class UpdateProvisionedProductPlanRequestParameters : TeaModel {
            /// <summary>
            /// The name of the parameter in the template.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of the parameter in the template.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The ID of the plan.
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// The ID of the product portfolio.
        /// 
        /// > If the default launch option exists, you do not need to specify PortfolioId. If the default launch option does not exist, you must specify PortfolioId. For more information about how to obtain the value of PortfolioId, see [ListLaunchOptions](~~ListLaunchOptions~~).
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// The ID of the product.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The ID of the product version.
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// An array that consists of custom tags.
        /// 
        /// Maximum value of N: 20.
        /// 
        /// > 
        /// *   If you specify Tags, you must specify Tags.N.Key and Tags.N.Value.
        /// *   The tag of a stack is propagated to each resource that supports the tag feature in the stack.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateProvisionedProductPlanRequestTags> Tags { get; set; }
        public class UpdateProvisionedProductPlanRequestTags : TeaModel {
            /// <summary>
            /// The key of the custom tag.
            /// 
            /// The key can be up to 128 characters in length, and cannot start with `acs:` or `aliyun`. The tag key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the custom tag.
            /// 
            /// The value can be up to 128 characters in length, and cannot start with `acs:`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
