// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateParameterConstraintsResponseBody : TeaModel {
        /// <summary>
        /// The constraints of the parameters.
        /// </summary>
        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public List<GetTemplateParameterConstraintsResponseBodyParameterConstraints> ParameterConstraints { get; set; }
        public class GetTemplateParameterConstraintsResponseBodyParameterConstraints : TeaModel {
            /// <summary>
            /// The values of the parameter.
            /// </summary>
            [NameInMap("AllowedValues")]
            [Validation(Required=false)]
            public List<string> AllowedValues { get; set; }

            /// <summary>
            /// The names of the associated parameters.
            /// </summary>
            [NameInMap("AssociationParameterNames")]
            [Validation(Required=false)]
            public List<string> AssociationParameterNames { get; set; }

            /// <summary>
            /// The behavior of the parameter. Valid values:
            /// 
            /// *   NoLimit: No limit is imposed on the value of this parameter.
            /// *   NotSupport: The value of this parameter cannot be queried.
            /// *   QueryError: This parameter failed to be queried.
            /// 
            /// >  If the AllowedValues parameter is not returned, the Behavior and BehaviorReason parameters are returned.
            /// </summary>
            [NameInMap("Behavior")]
            [Validation(Required=false)]
            public string Behavior { get; set; }

            /// <summary>
            /// The reason why the behavior of the parameter is returned.
            /// </summary>
            [NameInMap("BehaviorReason")]
            [Validation(Required=false)]
            public string BehaviorReason { get; set; }

            /// <summary>
            /// The values that do not conform to the parameter constraints.
            /// 
            /// >  If the `AllowedValues` parameter is returned, the `IllegalValueByParameterConstraints` and `IllegalValueByRules` parameters are returned at the same time.
            /// </summary>
            [NameInMap("IllegalValueByParameterConstraints")]
            [Validation(Required=false)]
            public List<object> IllegalValueByParameterConstraints { get; set; }

            /// <summary>
            /// The values that do not match the rules in the template.
            /// 
            /// >  If the `AllowedValues` parameter is returned, the `IllegalValueByParameterConstraints` and `IllegalValueByRules` parameters are returned at the same time.
            /// </summary>
            [NameInMap("IllegalValueByRules")]
            [Validation(Required=false)]
            public List<object> IllegalValueByRules { get; set; }

            /// <summary>
            /// The unsupported resources in the template.
            /// </summary>
            [NameInMap("NotSupportResources")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsNotSupportResources> NotSupportResources { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsNotSupportResources : TeaModel {
                /// <summary>
                /// The name of the resource property.
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// The resource type.
                /// 
                /// You can call the [ListResourceTypes](~~133957~~) operation to query the resource type.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("OriginalConstraints")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints> OriginalConstraints { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints : TeaModel {
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<object> AllowedValues { get; set; }

                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The error details that are returned if the request fails.
            /// </summary>
            [NameInMap("QueryErrors")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors> QueryErrors { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors : TeaModel {
                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The name of the resource.
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// The type of the parameter.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
