// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the execution accounts within which you want to deploy stacks in self-managed mode. You can specify up to 20 execution account IDs.</para>
        /// <remarks>
        /// <para>You must specify one of the following parameters: <c>AccountIds</c> and <c>DeploymentTargets</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;151266687691****&quot;,&quot;141261387191****&quot;]</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can contain letters, digits, hyphens (-), and underscores (_), and cannot exceed 64 characters in length.\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The folders in which ROS deploy stacks in service-managed permission model.</para>
        /// <remarks>
        /// <para>You must specify one of the following parameters: <c>AccountIds</c> and <c>DeploymentTargets</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RdFolderId&quot;: &quot;fd-4PvlVLOL8v&quot;}</para>
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public CreateStackInstancesRequestDeploymentTargets DeploymentTargets { get; set; }
        public class CreateStackInstancesRequestDeploymentTargets : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<string> AccountIds { get; set; }

            /// <summary>
            /// <para>The folder IDs of the resource directory. You can add up to five folder IDs.</para>
            /// <para>You can create stacks within all the member accounts in the specified folders. If you create stacks in the Root folder, the stacks are created within all member accounts in the resource directory.</para>
            /// <remarks>
            /// <para>To view the folder IDs, go to the <b>Overview</b> page in the <b>Resource Management</b> console. For more information, see <a href="https://help.aliyun.com/document_detail/111223.html">View the basic information about a folder</a>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to disable rollback when the stack fails to be created.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The description of the stack creation operation.</para>
        /// <para>The description must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create stack instances in hangzhou and beijing</para>
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// <para>The preference settings of the stack creation operation.</para>
        /// <para>The following parameters are available:</para>
        /// <list type="bullet">
        /// <item><description><para>{&quot;FailureToleranceCount&quot;: N}</para>
        /// <para> The number of accounts within which stack operation failures are allowed in each region. If the value of this parameter is exceeded in a region, Resource Orchestration Service (ROS) stops the operation in the region. If ROS stops the operation in one region, ROS stops the operation in other regions.</para>
        /// <para> Valid values of N: 0 to 20.</para>
        /// <para> If you do not specify FailureToleranceCount, 0 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;FailureTolerancePercentage&quot;: N}</para>
        /// <para> The percentage of the number of accounts within which stack operation failures are allowed to the total number of accounts in each region. If the value of this parameter is exceeded, ROS stops the operation in the region.</para>
        /// <para> Valid values of N: 0 to 100. If the numeric value in the percentage is not an integer, ROS rounds the value down to the nearest integer.</para>
        /// <para> If you do not specify FailureTolerancePercentage, 0 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentCount&quot;: N}</para>
        /// <para>The maximum number of accounts within which multiple stacks are deployed at the same time in each region.</para>
        /// <para>Valid values of N: 1 to 20.</para>
        /// <para>If you do not specify MaxConcurrentCount, 1 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentPercentage&quot;: N}</para>
        /// <para> The percentage of the maximum number of accounts within which multiple stacks are deployed at the same time to the total number of accounts in each region.</para>
        /// <para> Valid values: 1 to 100. If the numeric value in the percentage is not an integer, ROS rounds the number down to the nearest integer.</para>
        /// <para> If you do not specify MaxConcurrentPercentage, 1 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;RegionConcurrencyType&quot;: N}\
        ///  The mode that you want to use to deploy stacks across regions. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SEQUENTIAL (default): deploys stacks in each specified region based on the specified sequence of regions. ROS deploys stacks in one region at a time. </description></item>
        /// <item><description>PARALLEL: deploys stacks in parallel across all specified regions.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Separate multiple parameters with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify only one of the following parameters: MaxConcurrentCount and MaxConcurrentPercentage.</description></item>
        /// <item><description>You can specify only one of the following parameters: FailureToleranceCount and FailureTolerancePercentage.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FailureToleranceCount&quot;: 1, &quot;MaxConcurrentCount&quot;: 2}</para>
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationPreferences { get; set; }

        /// <summary>
        /// <para>The parameters that are used to override specific parameters.</para>
        /// </summary>
        [NameInMap("ParameterOverrides")]
        [Validation(Required=false)]
        public List<CreateStackInstancesRequestParameterOverrides> ParameterOverrides { get; set; }
        public class CreateStackInstancesRequestParameterOverrides : TeaModel {
            /// <summary>
            /// <para>The key of parameter N that you want to use to override a specific parameter. If you do not specify this parameter, ROS uses the name that you specified when you created the stack group.</para>
            /// <para>Maximum value of N: 200.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>ParameterOverrides is optional.</description></item>
            /// <item><description>If you specify ParameterOverrides, you must specify ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Amount</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of parameter N that you want to use to override a specific parameter. If you do not specify this parameter, ROS uses the value that you specify when you create the stack group.</para>
            /// <para>Maximum value of N: 200.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>ParameterOverrides is optional.</description></item>
            /// <item><description>If you specify ParameterOverrides, you must specify ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the stack group. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the regions where you want to create the stacks. You can specify up to 20 region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;, &quot;cn-beijing&quot;]</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The timeout period within which you can create the stack.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 60.</description></item>
        /// <item><description>Unit: minutes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

    }

}
