// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class PreviewStackResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the stack that is previewed.
        /// </summary>
        [NameInMap("Stack")]
        [Validation(Required=false)]
        public PreviewStackResponseBodyStack Stack { get; set; }
        public class PreviewStackResponseBodyStack : TeaModel {
            /// <summary>
            /// The description of the stack.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether rollback is disabled for the resources when the stack fails to be created.
            /// </summary>
            [NameInMap("DisableRollback")]
            [Validation(Required=false)]
            public bool? DisableRollback { get; set; }

            /// <summary>
            /// The log that is generated when the stack is run.
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public PreviewStackResponseBodyStackLog Log { get; set; }
            public class PreviewStackResponseBodyStackLog : TeaModel {
                /// <summary>
                /// The log that is generated when a Terraform stack is run. This parameter is returned only if the stack is a Terraform stack.
                /// 
                /// >  You can use this parameter to preview the logs of a Terraform stack.
                /// </summary>
                [NameInMap("TerraformLogs")]
                [Validation(Required=false)]
                public List<PreviewStackResponseBodyStackLogTerraformLogs> TerraformLogs { get; set; }
                public class PreviewStackResponseBodyStackLogTerraformLogs : TeaModel {
                    /// <summary>
                    /// The name of the Terraform command. Valid values:
                    /// 
                    /// *   apply
                    /// *   plan
                    /// *   destroy
                    /// *   version
                    /// 
                    /// For more information about Terraform commands, see [Basic CLI Features](https://www.terraform.io/cli/commands).
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// The content of the output stream that is returned after the command is run.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The output stream. Valid values:
                    /// 
                    /// *   stdout: standard output stream
                    /// *   stderr: standard error stream
                    /// </summary>
                    [NameInMap("Stream")]
                    [Validation(Required=false)]
                    public string Stream { get; set; }

                }

            }

            /// <summary>
            /// The parameters of the stack.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<PreviewStackResponseBodyStackParameters> Parameters { get; set; }
            public class PreviewStackResponseBodyStackParameters : TeaModel {
                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// The region ID of the stack.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The resources in the stack.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<PreviewStackResponseBodyStackResources> Resources { get; set; }
            public class PreviewStackResponseBodyStackResources : TeaModel {
                /// <summary>
                /// The type of the resource that belongs to an Alibaba Cloud service.
                /// </summary>
                [NameInMap("AcsResourceType")]
                [Validation(Required=false)]
                public string AcsResourceType { get; set; }

                /// <summary>
                /// The action that is performed on resources. Valid values:
                /// 
                /// *   Add
                /// *   Modify
                /// *   Remove
                /// *   None
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The description of the resource.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The logical ID of the resource.
                /// </summary>
                [NameInMap("LogicalResourceId")]
                [Validation(Required=false)]
                public string LogicalResourceId { get; set; }

                /// <summary>
                /// The physical ID of the resource.
                /// 
                /// This parameter is returned only if the Action parameter is set to Modify or Remove.
                /// </summary>
                [NameInMap("PhysicalResourceId")]
                [Validation(Required=false)]
                public string PhysicalResourceId { get; set; }

                /// <summary>
                /// The properties of the resource.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, object> Properties { get; set; }

                /// <summary>
                /// Indicates whether a replacement update is performed on the template. Valid values:
                /// 
                /// *   True: A replacement update is performed on the template.
                /// *   False: A change is made on the template.
                /// *   Conditional: A replacement update may be performed on the template. You can check whether a replacement update is performed when the template is in use.
                /// 
                /// >  This parameter is returned only if the Action parameter is set to Modify.
                /// </summary>
                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

                /// <summary>
                /// The resources on which the stack depends.
                /// </summary>
                [NameInMap("RequiredBy")]
                [Validation(Required=false)]
                public List<string> RequiredBy { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The information about the nested stack. The data structure of the value is the same as the data structure of the entire response.
                /// </summary>
                [NameInMap("Stack")]
                [Validation(Required=false)]
                public Dictionary<string, object> Stack { get; set; }

            }

            /// <summary>
            /// The name of the stack.
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// The structure that contains the stack policy body.
            /// </summary>
            [NameInMap("StackPolicyBody")]
            [Validation(Required=false)]
            public Dictionary<string, object> StackPolicyBody { get; set; }

            /// <summary>
            /// The description of the template.
            /// </summary>
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// The timeout period that is allowed to create the stack.
            /// 
            /// Unit: minutes.
            /// </summary>
            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }

        }

    }

}
