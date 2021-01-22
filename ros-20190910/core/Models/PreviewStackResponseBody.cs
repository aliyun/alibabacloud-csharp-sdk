// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class PreviewStackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Stack")]
        [Validation(Required=false)]
        public PreviewStackResponseBodyStack Stack { get; set; }
        public class PreviewStackResponseBodyStack : TeaModel {
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<PreviewStackResponseBodyStackParameters> Parameters { get; set; }
            public class PreviewStackResponseBodyStackParameters : TeaModel {
                public string ParameterKey { get; set; }
                public string ParameterValue { get; set; }
            }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DisableRollback")]
            [Validation(Required=false)]
            public bool? DisableRollback { get; set; }
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }
            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }
            [NameInMap("StackPolicyBody")]
            [Validation(Required=false)]
            public Dictionary<string, string> StackPolicyBody { get; set; }
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<PreviewStackResponseBodyStackResources> Resources { get; set; }
            public class PreviewStackResponseBodyStackResources : TeaModel {
                public string LogicalResourceId { get; set; }
                public string ResourceType { get; set; }
                public string Description { get; set; }
                public Dictionary<string, string> Stack { get; set; }
                public List<string> RequiredBy { get; set; }
                public Dictionary<string, string> Properties { get; set; }
            }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

    }

}
