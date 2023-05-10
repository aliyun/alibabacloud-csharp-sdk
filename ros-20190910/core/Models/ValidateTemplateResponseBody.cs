// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateResponseBody : TeaModel {
        /// <summary>
        /// The DataSource resource types.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The path of the regular resource. In most cases, the path of a regular resource is the same as the resource name.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyOutputs> Outputs { get; set; }
        public class ValidateTemplateResponseBodyOutputs : TeaModel {
            /// <summary>
            /// The update information about the stack.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The parameters that can be modified. If you change only values of the parameters in a stack template and use the template to update the stack, no validation errors are caused.
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// The pattern in which the logical IDs of regular resources are formed.
            /// 
            /// If resources are defined in an ROS template, the following rules apply:
            /// 
            /// *   Resource whose definition does not contain the `Count` parameter: If the resource name defined in the template is `server`, the value of the LogicalResourceIdPattern and `ResourcePath` parameters is `server`.
            /// *   Resource whose definition contains the `Count` parameter: If the resource name defined in the template is `server`, the value of the LogicalResourceIdPattern parameter is `server[*]`, and the value of the `ResourcePath` parameter is `server`.
            /// 
            /// If resources and [modules](https://www.terraform.io/language/modules) are defined in a Terraform template, the following rules apply:
            /// 
            /// *   Resource and module whose definitions do not contain the [count](https://www.terraform.io/language/meta-arguments/count) or [for_each](https://www.terraform.io/language/meta-arguments/for_each) parameter: If the resource name defined in the template is `server`, the value of the LogicalResourceIdPattern and `ResourcePath` parameters is `server`.
            /// *   Resource and module whose definitions contain the [count](https://www.terraform.io/language/meta-arguments/count) or [for_each](https://www.terraform.io/language/meta-arguments/for_each) parameter: If the resource name defined in the template is `server`, the value of the LogicalResourceIdPattern parameter is `server[*]`, and the value of the `ResourcePath` parameter is `server`.
            /// 
            /// Examples of the LogicalResourceIdPattern parameter for resources in a Terraform template:
            /// 
            /// *   Valid values of the LogicalResourceIdPattern parameter if a resource belongs to the root module:
            /// 
            ///     *   `server`: In this case, the `count` or `for_each` parameter is not contained in the resource. The value of the `ResourcePath` parameter is `server`.
            ///     *   `server[*]`: In this case, the `count` or `for_each` parameter is contained in the resource. The value of the `ResourcePath` parameter is `server`.
            /// 
            /// *   Valid values of the LogicalResourceIdPattern parameter if a resource belongs to a child module:
            /// 
            ///     *   `app.server`: In this case, the `count` or `for_each` parameter is not contained in the `app` module and the `server` resource. The value of the `ResourcePath` parameter is `app.server`.
            ///     *   `app.server[*]`: In this case, the `count` or `for_each` parameter is contained in the `server` resource, but not in the `app` module. The value of the `ResourcePath` parameter is `app.server`.
            ///     *   `app[*].server`: In this case, the `count` or `for_each` parameter is contained in the `app` module, but not in the `server` resource. The value of the `ResourcePath` parameter is `app.server`.
            ///     *   `app[*].server[*]`: In this case, the `count` or `for_each` parameter is contained in the `app` module and the `server` resource. The value of the `ResourcePath` parameter is `app.server`.
            ///     *   `app.app_group[*].server`: In this case, the `count` or `for_each` parameter is contained in the `app_group` module, but not in the `app` module and the `server` resource. The value of the `ResourcePath` parameter is `app.app_group.server`. The `app_group` module is a child module of the `app` module.
            /// </summary>
            [NameInMap("OutputKey")]
            [Validation(Required=false)]
            public string OutputKey { get; set; }

        }

        /// <summary>
        /// The regular resources that are defined in the template.
        /// 
        /// > 
        /// *   For a Resource Orchestration Service (ROS) template, the resource whose definition contains the `Count` parameter is not displayed as a list.
        /// *   For a Terraform template, the resource whose definition contains the `count` or `for_each` parameter is not displayed as a list.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        /// <summary>
        /// The regular resource type.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The parameters that can be modified. If you change only values of the parameters in a stack template and use the template to update the stack, no validation errors are caused.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyResourceTypes ResourceTypes { get; set; }
        public class ValidateTemplateResponseBodyResourceTypes : TeaModel {
            /// <summary>
            /// The parameters that can be modified under specific conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the new values of the parameters determine whether validation errors are caused.
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions. If you change only values of the parameters in a stack template and use the template to update the stack, service interruptions are caused.
            /// 
            /// > 
            /// *   This parameter is supported only for a small number of resource types.
            /// *   This parameter is valid only for changes that are made on ROS stacks.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

        /// <summary>
        /// The parameters whose changes cause service interruptions under specific conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the new values and the update type determine whether service interruptions are caused.
        /// 
        /// > 
        /// *   This parameter is supported only for a small number of resource types.
        /// *   This parameter is valid only for changes that are made on ROS stacks.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyResources> Resources { get; set; }
        public class ValidateTemplateResponseBodyResources : TeaModel {
            /// <summary>
            /// The parameters that cannot be modified. If you change only values of the parameters in a stack template and use the template to update the stack, validation errors are caused.
            /// </summary>
            [NameInMap("LogicalResourceIdPattern")]
            [Validation(Required=false)]
            public string LogicalResourceIdPattern { get; set; }

            /// <summary>
            /// The parameters that cannot be modified. If you change only values of the parameters in a stack template and use the template to update the stack, validation errors are caused.
            /// </summary>
            [NameInMap("ResourcePath")]
            [Validation(Required=false)]
            public string ResourcePath { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions under specific conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the new values and the update type determine whether service interruptions are caused.
            /// 
            /// > 
            /// *   This parameter is supported only for a small number of resource types.
            /// *   This parameter is valid only for changes that are made on ROS stacks.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The parameters that can be modified under uncertain conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the actual running environment determines whether validation errors are caused.
        /// </summary>
        [NameInMap("UpdateInfo")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyUpdateInfo UpdateInfo { get; set; }
        public class ValidateTemplateResponseBodyUpdateInfo : TeaModel {
            /// <summary>
            /// The parameters that can be modified under uncertain conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the actual running environment determines whether validation errors are caused.
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions under uncertain conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the actual running environment determines whether service interruptions are caused.
            /// 
            /// > 
            /// *   This parameter is supported only for a small number of resource types.
            /// *   This parameter is valid only for changes that are made on ROS stacks.
            /// </summary>
            [NameInMap("ParametersCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseInterruptionIfModified { get; set; }

            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            [NameInMap("ParametersConditionallyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseInterruptionIfModified { get; set; }

            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

            [NameInMap("ParametersUncertainlyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyAllowedToBeModified { get; set; }

            [NameInMap("ParametersUncertainlyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseInterruptionIfModified { get; set; }

        }

    }

}
