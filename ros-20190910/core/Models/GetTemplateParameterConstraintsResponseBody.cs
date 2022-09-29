// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateParameterConstraintsResponseBody : TeaModel {
        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public List<GetTemplateParameterConstraintsResponseBodyParameterConstraints> ParameterConstraints { get; set; }
        public class GetTemplateParameterConstraintsResponseBodyParameterConstraints : TeaModel {
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

            [NameInMap("IllegalValueByParameterConstraints")]
            [Validation(Required=false)]
            public List<object> IllegalValueByParameterConstraints { get; set; }

            [NameInMap("IllegalValueByRules")]
            [Validation(Required=false)]
            public List<object> IllegalValueByRules { get; set; }

            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
