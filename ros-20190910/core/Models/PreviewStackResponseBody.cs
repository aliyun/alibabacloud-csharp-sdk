// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class PreviewStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the stack that is previewed.</para>
        /// </summary>
        [NameInMap("Stack")]
        [Validation(Required=false)]
        public PreviewStackResponseBodyStack Stack { get; set; }
        public class PreviewStackResponseBodyStack : TeaModel {
            /// <summary>
            /// <para>The description of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>One ECS instance.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether rollback is disabled for the resources when the stack fails to be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableRollback")]
            [Validation(Required=false)]
            public bool? DisableRollback { get; set; }

            /// <summary>
            /// <para>The log that is generated when the stack is run.</para>
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public PreviewStackResponseBodyStackLog Log { get; set; }
            public class PreviewStackResponseBodyStackLog : TeaModel {
                /// <summary>
                /// <para>The Terraform logs. This parameter is returned only if the stack is a Terraform stack.</para>
                /// <remarks>
                /// <para>This parameter contains the logs of previewing the stack.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("TerraformLogs")]
                [Validation(Required=false)]
                public List<PreviewStackResponseBodyStackLogTerraformLogs> TerraformLogs { get; set; }
                public class PreviewStackResponseBodyStackLogTerraformLogs : TeaModel {
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
            public List<PreviewStackResponseBodyStackParameters> Parameters { get; set; }
            public class PreviewStackResponseBodyStackParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::AccountId</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>151266687691****</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The region where the stack resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resources in the stack.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<PreviewStackResponseBodyStackResources> Resources { get; set; }
            public class PreviewStackResponseBodyStackResources : TeaModel {
                /// <summary>
                /// <para>The resource type of an Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("AcsResourceType")]
                [Validation(Required=false)]
                public string AcsResourceType { get; set; }

                /// <summary>
                /// <para>The action that is performed on the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Add</description></item>
                /// <item><description>Modify</description></item>
                /// <item><description>Remove</description></item>
                /// <item><description>None</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Add</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The description of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS instance.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The logical ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WebServer</para>
                /// </summary>
                [NameInMap("LogicalResourceId")]
                [Validation(Required=false)]
                public string LogicalResourceId { get; set; }

                /// <summary>
                /// <para>The physical ID of the resource.</para>
                /// <para>This parameter is returned only if Action is set to Modify or Remove.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-a1b2c3***</para>
                /// </summary>
                [NameInMap("PhysicalResourceId")]
                [Validation(Required=false)]
                public string PhysicalResourceId { get; set; }

                /// <summary>
                /// <para>The resource properties.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{   &quot;DiskMappings&quot;: [     {       &quot;Category&quot;: &quot;cloud_ssd&quot;,       &quot;Size&quot;: &quot;20&quot;     }   ],   &quot;SystemDisk_Category&quot;: &quot;cloud_ssd&quot;,   &quot;InstanceChargeType&quot;: &quot;PostPaid&quot;,   &quot;AutoRenew&quot;: &quot;False&quot;,   &quot;WillReplace&quot;: true,   &quot;ImageId&quot;: &quot;centos_7&quot;,   &quot;InstanceType&quot;: &quot;ecs.g6.large&quot;,   &quot;AllocatePublicIP&quot;: true,   &quot;AutoRenewPeriod&quot;: 1,   &quot;IoOptimized&quot;: &quot;optimized&quot;,   &quot;ZoneId&quot;: &quot;cn-beijing-g&quot;,   &quot;VSwitchId&quot;: &quot;&quot;,   &quot;SecurityGroupId&quot;: &quot;&quot;,   &quot;Period&quot;: 1,   &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,   &quot;SystemDiskCategory&quot;: &quot;cloud_efficiency&quot;,   &quot;InternetMaxBandwidthOut&quot;: 1,   &quot;VpcId&quot;: &quot;&quot;,   &quot;InternetMaxBandwidthIn&quot;: 200,   &quot;PeriodUnit&quot;: &quot;Month&quot; }</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, object> Properties { get; set; }

                /// <summary>
                /// <para>Indicates whether a replacement update is performed on the template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>True: A replacement update is performed on the template.</description></item>
                /// <item><description>False: A change is made on the template.</description></item>
                /// <item><description>Conditional: A replacement update may be performed on the template. You can check whether a replacement update is performed when the template is in use.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only if Action is set to Modify.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

                /// <summary>
                /// <para>The resources on which the stack depends.</para>
                /// </summary>
                [NameInMap("RequiredBy")]
                [Validation(Required=false)]
                public List<string> RequiredBy { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The information about the nested stack. The data structure of the value is the same as the data structure of the entire response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Stack")]
                [Validation(Required=false)]
                public Dictionary<string, object> Stack { get; set; }

            }

            /// <summary>
            /// <para>The stack name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStack</para>
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <para>The structure that contains the stack policy body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{   &quot;Statement&quot;: [     {       &quot;Action&quot;: &quot;Update:<em>&quot;,       &quot;Resource&quot;: &quot;</em>&quot;,       &quot;Effect&quot;: &quot;Allow&quot;,       &quot;Principal&quot;: &quot;<em>&quot;     },     {       &quot;Action&quot;: &quot;Update:</em>&quot;,       &quot;Resource&quot;: &quot;LogicalResourceId/apple1&quot;,       &quot;Effect&quot;: &quot;Deny&quot;,       &quot;Principal&quot;: &quot;*&quot;     }   ] }</para>
            /// </summary>
            [NameInMap("StackPolicyBody")]
            [Validation(Required=false)]
            public Dictionary<string, object> StackPolicyBody { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>One ECS instance.</para>
            /// </summary>
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// <para>The timeout period for creating the stack.</para>
            /// <para>Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }

        }

    }

}
