// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTaskDetail TaskDetail { get; set; }
        public class GetTaskResponseBodyTaskDetail : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-23T09:46:27Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The logs of the instance.</para>
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskDetailLog Log { get; set; }
            public class GetTaskResponseBodyTaskDetailLog : TeaModel {
                /// <summary>
                /// <para>The Terraform logs.</para>
                /// </summary>
                [NameInMap("TerraformLogs")]
                [Validation(Required=false)]
                public List<GetTaskResponseBodyTaskDetailLogTerraformLogs> TerraformLogs { get; set; }
                public class GetTaskResponseBodyTaskDetailLogTerraformLogs : TeaModel {
                    /// <summary>
                    /// <para>The name of the Terraform command that is run. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>apply</description></item>
                    /// <item><description>plan</description></item>
                    /// <item><description>destroy</description></item>
                    /// <item><description>version</description></item>
                    /// </list>
                    /// <para>For more information about Terraform commands, see <a href="https://www.terraform.io/cli/commands">Basic CLI Features</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>apply</para>
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// <para>The content of the output stream that is returned after the command is run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Apply complete! Resources: 42 added, 0 changed, 0 destroyed.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The output stream. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>stdout: a standard output stream</description></item>
                    /// <item><description>stderr: a standard error stream</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>stdout</para>
                    /// </summary>
                    [NameInMap("Stream")]
                    [Validation(Required=false)]
                    public string Stream { get; set; }

                }

            }

            /// <summary>
            /// <para>The output parameters of the template.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskDetailOutputs> Outputs { get; set; }
            public class GetTaskResponseBodyTaskDetailOutputs : TeaModel {
                /// <summary>
                /// <para>The description of the output parameter for the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The ECS instance ID.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the output parameter for the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_id</para>
                /// </summary>
                [NameInMap("OutputKey")]
                [Validation(Required=false)]
                public string OutputKey { get; set; }

                /// <summary>
                /// <para>The value of the output parameter for the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("OutputValue")]
                [Validation(Required=false)]
                public string OutputValue { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are specified in the template.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskDetailParameters> Parameters { get; set; }
            public class GetTaskResponseBodyTaskDetailParameters : TeaModel {
                /// <summary>
                /// <para>The name of the input parameter for the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_type</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <para>The value of the input parameter for the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.s6-c1m1.small</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <para>The ID of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-Create an ECS instance</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The ID of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv-bp15e79d26****</para>
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// <para>The name of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// <para>The ID of the product instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pp-bp1ddg1n2a****</para>
            /// </summary>
            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            /// <summary>
            /// <para>The name of the product instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-ECS instance</para>
            /// </summary>
            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            /// <summary>
            /// <para>The state of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Succeeded: The task was successful.</description></item>
            /// <item><description>InProgress: The task was in progress.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The message that is returned for the status of the task.</para>
            /// <remarks>
            /// <para>This parameter is returned only when Failed is returned for the Status parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Resource CREATE failed: terraform stack sc-146611588617****-pp-bp1ddg1n2a**** failure...</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-bp1dmg242c****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The custom tags.</para>
            /// </summary>
            [NameInMap("TaskTags")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskDetailTaskTags> TaskTags { get; set; }
            public class GetTaskResponseBodyTaskDetailTaskTags : TeaModel {
                /// <summary>
                /// <para>The custom tag key.</para>
                /// <para>The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The custom tag value.</para>
                /// <para>The value must be 1 to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LaunchProduct: a task that launches the product.</description></item>
            /// <item><description>UpdateProvisionedProduct: a task that updates the information about the product instance.</description></item>
            /// <item><description>TerminateProvisionedProduct: a task that terminates the product instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LaunchProduct</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The time when the task was last modified.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-23T09:47:29Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
