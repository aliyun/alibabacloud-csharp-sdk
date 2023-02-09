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
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisableRollback")]
            [Validation(Required=false)]
            public bool? DisableRollback { get; set; }

            [NameInMap("Log")]
            [Validation(Required=false)]
            public PreviewStackResponseBodyStackLog Log { get; set; }
            public class PreviewStackResponseBodyStackLog : TeaModel {
                [NameInMap("TerraformLogs")]
                [Validation(Required=false)]
                public List<PreviewStackResponseBodyStackLogTerraformLogs> TerraformLogs { get; set; }
                public class PreviewStackResponseBodyStackLogTerraformLogs : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Stream")]
                    [Validation(Required=false)]
                    public string Stream { get; set; }

                }

            }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<PreviewStackResponseBodyStackParameters> Parameters { get; set; }
            public class PreviewStackResponseBodyStackParameters : TeaModel {
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<PreviewStackResponseBodyStackResources> Resources { get; set; }
            public class PreviewStackResponseBodyStackResources : TeaModel {
                [NameInMap("AcsResourceType")]
                [Validation(Required=false)]
                public string AcsResourceType { get; set; }

                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("LogicalResourceId")]
                [Validation(Required=false)]
                public string LogicalResourceId { get; set; }

                [NameInMap("PhysicalResourceId")]
                [Validation(Required=false)]
                public string PhysicalResourceId { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, object> Properties { get; set; }

                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

                [NameInMap("RequiredBy")]
                [Validation(Required=false)]
                public List<string> RequiredBy { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("Stack")]
                [Validation(Required=false)]
                public Dictionary<string, object> Stack { get; set; }

            }

            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            [NameInMap("StackPolicyBody")]
            [Validation(Required=false)]
            public Dictionary<string, object> StackPolicyBody { get; set; }

            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }

        }

    }

}
