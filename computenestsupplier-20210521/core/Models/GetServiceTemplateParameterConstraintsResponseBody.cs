// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceTemplateParameterConstraintsResponseBody : TeaModel {
        /// <summary>
        /// The constraint families.
        /// </summary>
        [NameInMap("FamilyConstraints")]
        [Validation(Required=false)]
        public List<string> FamilyConstraints { get; set; }

        /// <summary>
        /// The parameters in the template.
        /// </summary>
        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraints> ParameterConstraints { get; set; }
        public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraints : TeaModel {
            /// <summary>
            /// The valid values of the parameter.
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
            /// *   NoLimit: The value of this parameter is not limited.
            /// *   NotSupport: The value of this parameter cannot be queried.
            /// *   QueryError: The query failed.
            /// 
            /// >  If AllowedValues is not returned, Behavior and BehaviorReason are returned.
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
            /// The original constraint information.
            /// </summary>
            [NameInMap("OriginalConstraints")]
            [Validation(Required=false)]
            public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints> OriginalConstraints { get; set; }
            public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints : TeaModel {
                /// <summary>
                /// The valid values of the parameter.
                /// </summary>
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<string> AllowedValues { get; set; }

                /// <summary>
                /// The property name.
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// The resource name.
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
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The type of the parameter.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
