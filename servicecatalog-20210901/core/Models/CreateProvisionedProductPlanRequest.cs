// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProvisionedProductPlanRequest : TeaModel {
        /// <summary>
        /// The description of the plan.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of the operation that you want the plan to perform. Valid values:
        /// 
        /// *   LaunchProduct: launches the product. This is the default value.
        /// *   UpdateProvisionedProduct: updates the information about the product instance.
        /// *   TerminateProvisionedProduct: terminates the product instance.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// An array that consists of the parameters in the template.
        /// 
        /// You can specify up to 200 parameters.
        /// 
        /// > If you specify Parameters, you must specify ParameterKey and ParameterValue.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateProvisionedProductPlanRequestParameters> Parameters { get; set; }
        public class CreateProvisionedProductPlanRequestParameters : TeaModel {
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
        /// The plan name.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// The plan type.
        /// 
        /// Set the value to Ros, which specifies Resource Orchestration Service (ROS).
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// The product portfolio ID.
        /// 
        /// > If PortfolioId is not required, you do not need to specify PortfolioId. If PortfolioId is required, you must specify PortfolioId. For more information about how to obtain the value of PortfolioId, see [ListLaunchOptions](~~ListLaunchOptions~~).
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// The product ID.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The product version ID.
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// The product instance name.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ProvisionedProductName")]
        [Validation(Required=false)]
        public string ProvisionedProductName { get; set; }

        /// <summary>
        /// The ID of the region to which the ROS stack belongs.
        /// 
        /// For more information about how to obtain the regions that are supported by ROS, see [DescribeRegions](~~131035~~).
        /// </summary>
        [NameInMap("StackRegionId")]
        [Validation(Required=false)]
        public string StackRegionId { get; set; }

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
        public List<CreateProvisionedProductPlanRequestTags> Tags { get; set; }
        public class CreateProvisionedProductPlanRequestTags : TeaModel {
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
