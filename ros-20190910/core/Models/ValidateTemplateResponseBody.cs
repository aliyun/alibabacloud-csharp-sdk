// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyOutputs> Outputs { get; set; }
        public class ValidateTemplateResponseBodyOutputs : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("OutputKey")]
            [Validation(Required=false)]
            public string OutputKey { get; set; }

        }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyResourceTypes ResourceTypes { get; set; }
        public class ValidateTemplateResponseBodyResourceTypes : TeaModel {
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyResources> Resources { get; set; }
        public class ValidateTemplateResponseBodyResources : TeaModel {
            [NameInMap("LogicalResourceIdPattern")]
            [Validation(Required=false)]
            public string LogicalResourceIdPattern { get; set; }

            [NameInMap("ResourcePath")]
            [Validation(Required=false)]
            public string ResourcePath { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("UpdateInfo")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyUpdateInfo UpdateInfo { get; set; }
        public class ValidateTemplateResponseBodyUpdateInfo : TeaModel {
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

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
