// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the destination accounts where you want to create stacks using self-managed permissions. You can specify up to 50 account IDs.</para>
        /// <remarks>
        /// <para>You can specify only one of the <c>AccountIds</c> and <c>DeploymentTargets</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;151266687691****&quot;,&quot;141261387191****&quot;]</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. The client generates the token, which must be globally unique.<br>The token can be up to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).<br>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment options for deploying stacks in service-managed permission mode. You can specify up to one deployment option.</para>
        /// </summary>
        [NameInMap("DeploymentOptions")]
        [Validation(Required=false)]
        public List<string> DeploymentOptions { get; set; }

        /// <summary>
        /// <para>The deployment targets for deploying stacks in service-managed permission mode.</para>
        /// <remarks>
        /// <para>You can specify only one of the <c>AccountIds</c> and <c>DeploymentTargets</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RdFolderId&quot;: &quot;fd-4PvlVLOL8v&quot;}</para>
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public string DeploymentTargetsShrink { get; set; }

        /// <summary>
        /// <para>Indicates whether to disable rollback when a stack fails to be created.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Disables rollback.</para>
        /// </description></item>
        /// <item><description><para>false (default): Enables rollback.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The description of the operation to create the stacks.</para>
        /// <para>The description must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create stack instances in hangzhou and beijing</para>
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// <para>The preferences for the operation.</para>
        /// <para>The following parameters are available:</para>
        /// <list type="bullet">
        /// <item><description><para>{&quot;FailureToleranceCount&quot;: N}</para>
        /// <para>The number of accounts per region in which the operation can fail. If the number of failed operations in a region exceeds this value, Resource Orchestration Service (ROS) stops the operation in that region. If the operation is stopped in a region, the operation is not performed in other regions.</para>
        /// <para>The value of N can be an integer from 0 to 20.</para>
        /// <para>If you do not specify this parameter, the default value is 0.</para>
        /// </description></item>
        /// <item><description><para>{&quot;FailureTolerancePercentage&quot;: N}</para>
        /// <para>The percentage of accounts per region in which the operation can fail, relative to the total number of accounts. If the percentage of failed operations in a region exceeds this value, ROS stops the operation in that region.</para>
        /// <para>The value of N can be an integer from 0 to 100. If the percentage is not an integer, ROS rounds down the value.</para>
        /// <para>If you do not specify this parameter, the default value is 0.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentCount&quot;: N}</para>
        /// <para>The maximum number of accounts in each region where stacks can be deployed at the same time.</para>
        /// <para>The value of N can be an integer from 1 to 20.</para>
        /// <para>If you do not specify this parameter, the default value is 1.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentPercentage&quot;: N}</para>
        /// <para>The percentage of accounts in each region where stacks can be deployed at the same time, relative to the total number of accounts.</para>
        /// <para>The value of N can be an integer from 1 to 100. If the percentage is not an integer, ROS rounds down the value.</para>
        /// <para>If you do not specify this parameter, the default value is 1.</para>
        /// </description></item>
        /// <item><description><para>{&quot;RegionConcurrencyType&quot;: N}<br>The concurrency type of deployment regions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SEQUENTIAL (default): Deploys stacks in the specified regions one by one. Stacks are deployed in only one region at a time.</para>
        /// </description></item>
        /// <item><description><para>PARALLEL: Deploys stacks in all specified regions at the same time.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Separate multiple parameters with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You cannot specify MaxConcurrentCount and MaxConcurrentPercentage at the same time.</para>
        /// </description></item>
        /// <item><description><para>You cannot specify FailureToleranceCount and FailureTolerancePercentage at the same time.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FailureToleranceCount&quot;: 1, &quot;MaxConcurrentCount&quot;: 2}</para>
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        /// <summary>
        /// <para>A list of parameters that overwrite the template parameters.</para>
        /// </summary>
        [NameInMap("ParameterOverrides")]
        [Validation(Required=false)]
        public List<CreateStackInstancesShrinkRequestParameterOverrides> ParameterOverrides { get; set; }
        public class CreateStackInstancesShrinkRequestParameterOverrides : TeaModel {
            /// <summary>
            /// <para>The name of the parameter to overwrite. If you do not specify this parameter, ROS uses the parameter name that was specified when the stack group was created.</para>
            /// <para>You can specify up to 200 parameters.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>ParameterOverrides is optional.</para>
            /// </description></item>
            /// <item><description><para>If you specify ParameterOverrides, you must specify both ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue.</para>
            /// </description></item>
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
            /// <para>The value of the parameter to overwrite. If you do not specify this parameter, ROS uses the parameter value that was specified when the stack group was created.</para>
            /// <para>You can specify up to 200 parameters.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>ParameterOverrides is optional.</para>
            /// </description></item>
            /// <item><description><para>If you specify ParameterOverrides, you must specify both ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue.</para>
            /// </description></item>
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
        /// <para>The region ID of the stack group.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the destination regions. You can specify up to 20 region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;, &quot;cn-beijing&quot;]</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region.<br>The name can be up to 255 characters in length. It must start with a letter or a digit and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The timeout period for creating the stacks.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 60.</para>
        /// </description></item>
        /// <item><description><para>Unit: minutes.</para>
        /// </description></item>
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
