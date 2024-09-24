// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetChangeSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the change set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c11658d-bd47-4dd0-ba64-727edc62****</para>
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// <para>The name of the change set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChangeSet_template</para>
        /// </summary>
        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// <para>The type of the change set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPDATE</para>
        /// </summary>
        [NameInMap("ChangeSetType")]
        [Validation(Required=false)]
        public string ChangeSetType { get; set; }

        /// <summary>
        /// <para>The changes of the change set.</para>
        /// </summary>
        [NameInMap("Changes")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Changes { get; set; }

        /// <summary>
        /// <para>The time when the change set was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-01T02:20:56</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the change set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>It is a demo.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether rollback was performed when the stack failed to be created or updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The execution status of the change set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public string ExecutionStatus { get; set; }

        /// <summary>
        /// <para>The output logs of the change set.</para>
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetChangeSetResponseBodyLog Log { get; set; }
        public class GetChangeSetResponseBodyLog : TeaModel {
            /// <summary>
            /// <para>The Terraform logs. This parameter is returned only for change sets of Terraform stacks.</para>
            /// <remarks>
            /// <para>This parameter is not returned for change sets that are in the Creating state. This parameter indicates the logs of the change set creation operation for Terraform stacks.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TerraformLogs")]
            [Validation(Required=false)]
            public List<GetChangeSetResponseBodyLogTerraformLogs> TerraformLogs { get; set; }
            public class GetChangeSetResponseBodyLogTerraformLogs : TeaModel {
                /// <summary>
                /// <para>The name of the Terraform command that is run. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>apply</description></item>
                /// <item><description>plan</description></item>
                /// <item><description>destroy</description></item>
                /// <item><description>version</description></item>
                /// </list>
                /// <para>For more information about Terraform commands, see <a href="https://www.terraform.io/cli/commands">Command</a>.</para>
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
                /// <item><description>stdout: standard output stream</description></item>
                /// <item><description>stderr: standard error stream</description></item>
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
        /// <para>The parameters of the stack.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetChangeSetResponseBodyParameters> Parameters { get; set; }
        public class GetChangeSetResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>The key of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::Region</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the change set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3766EE04-76DD-50F9-9C23-3AF136CD5708</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the stack with which the change set is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a486fc19-ebb7-4ce9-a70b-554a7c3d****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The name of the stack with which the change set is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack_2021-10-13</para>
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// <para>The status of the change set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_COMPLETE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason why the change set is in its current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>too many changes.</para>
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The template body of the change set.</para>
        /// <remarks>
        /// <para>This parameter takes effect only if you set ShowTemplate to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The timeout period that is specified for the stack creation or update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

    }

}
