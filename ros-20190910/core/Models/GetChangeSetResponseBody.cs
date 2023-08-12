// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetChangeSetResponseBody : TeaModel {
        /// <summary>
        /// The ID of the change set.
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// The name of the change set.
        /// </summary>
        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// The type of the change set.
        /// </summary>
        [NameInMap("ChangeSetType")]
        [Validation(Required=false)]
        public string ChangeSetType { get; set; }

        /// <summary>
        /// The changes of the change set.
        /// </summary>
        [NameInMap("Changes")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Changes { get; set; }

        /// <summary>
        /// The time when the change set was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The description of the change set.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether rollback was performed when the stack failed to be created or updated.
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// The execution status of the change set.
        /// </summary>
        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public string ExecutionStatus { get; set; }

        /// <summary>
        /// The output logs of the change set.
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetChangeSetResponseBodyLog Log { get; set; }
        public class GetChangeSetResponseBodyLog : TeaModel {
            /// <summary>
            /// The Terraform logs. This parameter is returned only for change sets of Terraform stacks.
            /// 
            /// > This parameter is not returned for change sets that are in the Creating state. This parameter indicates the logs of the change set creation operation for Terraform stacks.
            /// </summary>
            [NameInMap("TerraformLogs")]
            [Validation(Required=false)]
            public List<GetChangeSetResponseBodyLogTerraformLogs> TerraformLogs { get; set; }
            public class GetChangeSetResponseBodyLogTerraformLogs : TeaModel {
                /// <summary>
                /// The name of the Terraform command that is run. Valid values:
                /// 
                /// *   apply
                /// *   plan
                /// *   destroy
                /// *   version
                /// 
                /// For more information about Terraform commands, see [Command](https://www.terraform.io/cli/commands).
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
        public List<GetChangeSetResponseBodyParameters> Parameters { get; set; }
        public class GetChangeSetResponseBodyParameters : TeaModel {
            /// <summary>
            /// The key of the parameter.
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
        /// The region ID of the change set.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the stack with which the change set is associated.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The name of the stack with which the change set is associated.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// The status of the change set.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The reason why the change set is in its current state.
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// The template body of the change set.
        /// 
        /// > This parameter takes effect only if you set ShowTemplate to true.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The timeout period that is specified for the stack creation or update operation.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

    }

}
