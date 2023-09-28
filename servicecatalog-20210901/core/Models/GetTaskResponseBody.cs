// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the task.
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTaskDetail TaskDetail { get; set; }
        public class GetTaskResponseBodyTaskDetail : TeaModel {
            /// <summary>
            /// The time when the task was created.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The logs of the product instance.
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskDetailLog Log { get; set; }
            public class GetTaskResponseBodyTaskDetailLog : TeaModel {
                /// <summary>
                /// The Terraform logs.
                /// </summary>
                [NameInMap("TerraformLogs")]
                [Validation(Required=false)]
                public List<GetTaskResponseBodyTaskDetailLogTerraformLogs> TerraformLogs { get; set; }
                public class GetTaskResponseBodyTaskDetailLogTerraformLogs : TeaModel {
                    /// <summary>
                    /// The name of the Terraform command that is run. Valid values:
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
                    /// *   stdout: a standard output stream
                    /// *   stderr: a standard error stream
                    /// </summary>
                    [NameInMap("Stream")]
                    [Validation(Required=false)]
                    public string Stream { get; set; }

                }

            }

            /// <summary>
            /// The output parameters of the template.
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskDetailOutputs> Outputs { get; set; }
            public class GetTaskResponseBodyTaskDetailOutputs : TeaModel {
                /// <summary>
                /// The description of the output parameter for the template.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the output parameter for the template.
                /// </summary>
                [NameInMap("OutputKey")]
                [Validation(Required=false)]
                public string OutputKey { get; set; }

                /// <summary>
                /// The value of the output parameter for the template.
                /// </summary>
                [NameInMap("OutputValue")]
                [Validation(Required=false)]
                public string OutputValue { get; set; }

            }

            /// <summary>
            /// The input parameters of the template.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskDetailParameters> Parameters { get; set; }
            public class GetTaskResponseBodyTaskDetailParameters : TeaModel {
                /// <summary>
                /// The name of the input parameter for the template.
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// The value of the input parameter for the template.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// The ID of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// The ID of the product.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The name of the product.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The ID of the product version.
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// The name of the product version.
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// The ID of the product instance.
            /// </summary>
            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            /// <summary>
            /// The name of the product instance.
            /// </summary>
            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            /// <summary>
            /// The state of the task. Valid values:
            /// 
            /// *   Succeeded: The task was successful.
            /// *   InProgress: The task was in progress.
            /// *   Failed: The task failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The message that is returned for the status of the task.
            /// 
            /// > This parameter is returned only when Failed is returned for the Status parameter.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskTags")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskDetailTaskTags> TaskTags { get; set; }
            public class GetTaskResponseBodyTaskDetailTaskTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   LaunchProduct: a task that launches the product.
            /// *   UpdateProvisionedProduct: a task that updates the information about the product instance.
            /// *   TerminateProvisionedProduct: a task that terminates the product instance.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The time when the task was last modified.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
