// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateResponseBody : TeaModel {
        /// <summary>
        /// The description of the template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The outputs of the template.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyOutputs> Outputs { get; set; }
        public class ValidateTemplateResponseBodyOutputs : TeaModel {
            /// <summary>
            /// The description of the template output.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The alias of the template output.
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// The name of the template output.
            /// </summary>
            [NameInMap("OutputKey")]
            [Validation(Required=false)]
            public string OutputKey { get; set; }

        }

        /// <summary>
        /// The parameters that are defined in the Parameters section of the template.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource types that are used in the template.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyResourceTypes ResourceTypes { get; set; }
        public class ValidateTemplateResponseBodyResourceTypes : TeaModel {
            /// <summary>
            /// The DataSource resource types that are used in the template. The value is deduplicated.
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            /// <summary>
            /// The regular resource types that are used in the template. The value is deduplicated.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

        /// <summary>
        /// The regular resources that are defined in the template.
        /// 
        /// > - For a Resource Orchestration Service (ROS) template, the resource whose definition contains `Count` is not displayed as a list.
        /// > -  For a Terraform template, the resource whose definition contains `count` or `for_each` is not displayed as a list.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyResources> Resources { get; set; }
        public class ValidateTemplateResponseBodyResources : TeaModel {
            /// <summary>
            /// The pattern in which the logical IDs of regular resources are formed.
            /// 
            /// If resources are defined in a ROS template, the following rules apply:
            /// 
            /// *   Resource whose definition does not contain `Count`: If the resource name defined in the template is `server`, the values of LogicalResourceIdPattern and `ResourcePath` are both `server`.``
            /// *   Resource whose definition contains `Count`: If the resource name defined in the template is `server`, the value of LogicalResourceIdPattern is `server[*]`, and the value of `ResourcePath` is `server`.
            /// 
            /// If resources and [modules](https://www.terraform.io/language/modules) are defined in a Terraform template, the following rules apply:
            /// 
            /// *   Resource and module whose definitions do not contain [`count`](https://www.terraform.io/language/meta-arguments/count) or [`for_each`](https://www.terraform.io/language/meta-arguments/for_each): If the resource name defined in the template is `server`, the values of LogicalResourceIdPattern and `ResourcePath` are both `server`.``
            /// *   Resource and module whose definitions contain [`count`](https://www.terraform.io/language/meta-arguments/count) or [`for_each`](https://www.terraform.io/language/meta-arguments/for_each): If the resource name defined in the template is `server`, the value of LogicalResourceIdPattern is `server[*]`, and the value of `ResourcePath` is `server`.
            /// 
            /// Examples of LogicalResourceIdPattern for resources in a Terraform template:
            /// 
            /// *   Valid values of LogicalResourceIdPattern if a resource belongs to the root module:
            /// 
            ///     *   `server`: In this case, `count` and `for_each` are not contained in the resource. The value of `ResourcePath` is `server`.
            ///     *   `server[*]`: In this case, `count` or `for_each` is contained in the resource. The value of `ResourcePath` is `server`.
            /// 
            /// *   Valid values of LogicalResourceIdPattern if a resource belongs to a child module:
            /// 
            ///     *   `app.server`: In this case, `count` and `for_each` are not contained in the `app` module and the `server` resource. The value of `ResourcePath` is `app.server`.````
            ///     *   `app.server[*]`: In this case, `count` or `for_each` is contained in the `server` resource, but `count` and `for_each` are not contained in the `app` module. The value of `ResourcePath` is `app.server`.
            ///     *   `app[*].server`: In this case, `count` or `for_each` is contained in the `app` module, but `count` and `for_each` are not contained in the `server` resource. The value of `ResourcePath` is `app.server`.
            ///     *   `app[*].server[*]`: In this case, `count` or `for_each` is contained in the `app` module and the `server` resource. The value of `ResourcePath` is `app.server`.````
            ///     *   `app.app_group[*].server`: In this case, `count` or `for_each` is contained in the `app_group` module, but `count` and `for_each` are not contained in the `app` module and the `server` resource. The value of `ResourcePath` is `app.app_group.server`. The `app_group` module is a child module of the `app` module.````
            /// </summary>
            [NameInMap("LogicalResourceIdPattern")]
            [Validation(Required=false)]
            public string LogicalResourceIdPattern { get; set; }

            /// <summary>
            /// The path of the regular resource. In most cases, the path of a regular resource is the same as the resource name.
            /// </summary>
            [NameInMap("ResourcePath")]
            [Validation(Required=false)]
            public string ResourcePath { get; set; }

            /// <summary>
            /// The regular resource type.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The information about the stack update. This parameter cannot be returned if the value of UpdateInfoOptions contains Disabled.
        /// </summary>
        [NameInMap("UpdateInfo")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyUpdateInfo UpdateInfo { get; set; }
        public class ValidateTemplateResponseBodyUpdateInfo : TeaModel {
            /// <summary>
            /// The parameters that can be modified.
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions.
            /// 
            /// > - This parameter is supported only for a small number of resource types.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// The parameters whose changes trigger replacement updates for resources.
            /// 
            /// > -  This parameter can be returned only if the value of UpdateInfoOptions contains EnableReplacement.
            /// > -  This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseReplacementIfModified { get; set; }

            /// <summary>
            /// The parameters that can be modified under specific conditions.
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions under specific conditions.
            /// 
            /// > - This parameter is supported only for a small number of resource types.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersConditionallyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// The parameters whose changes trigger replacement updates for resources under specific conditions.
            /// 
            /// > - This parameter can be returned only if the value of UpdateInfoOptions contains EnableReplacement.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersConditionallyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseReplacementIfModified { get; set; }

            /// <summary>
            /// The parameters that cannot be modified.
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters that can be modified under uncertain conditions.
            /// </summary>
            [NameInMap("ParametersUncertainlyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions under uncertain conditions.
            /// 
            /// > - This parameter is supported only for a small number of resource types.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// The parameters whose changes trigger replacement updates for resources under uncertain conditions.
            /// 
            /// > -  This parameter can be returned only if the value of UpdateInfoOptions contains EnableReplacement.
            /// > -  This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseReplacementIfModified { get; set; }

        }

    }

}
