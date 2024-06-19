// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceTemplateParameterConstraintsResponseBody : TeaModel {
        [NameInMap("FamilyConstraints")]
        [Validation(Required=false)]
        public List<string> FamilyConstraints { get; set; }

        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraints> ParameterConstraints { get; set; }
        public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraints : TeaModel {
            [NameInMap("AllowedValues")]
            [Validation(Required=false)]
            public List<string> AllowedValues { get; set; }

            [NameInMap("AssociationParameterNames")]
            [Validation(Required=false)]
            public List<string> AssociationParameterNames { get; set; }

            [NameInMap("Behavior")]
            [Validation(Required=false)]
            public string Behavior { get; set; }

            [NameInMap("BehaviorReason")]
            [Validation(Required=false)]
            public string BehaviorReason { get; set; }

            [NameInMap("OriginalConstraints")]
            [Validation(Required=false)]
            public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints> OriginalConstraints { get; set; }
            public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints : TeaModel {
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<string> AllowedValues { get; set; }

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

            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("QueryErrors")]
            [Validation(Required=false)]
            public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors> QueryErrors { get; set; }
            public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors : TeaModel {
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
