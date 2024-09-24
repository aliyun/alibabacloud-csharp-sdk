// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the execution accounts within which you want to deploy stacks in self-managed mode. You can specify up to 20 execution account IDs.</para>
        /// <remarks>
        /// <para>If you want to update stacks in self-managed permission mode, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;151266687691****&quot;,&quot;141261387191****&quot;]</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

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
        /// <para>The folders in which you want to deploy stacks in service-managed mode.</para>
        /// <remarks>
        /// <para>If you want to update stacks in service-managed permission mode, you must specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public string DeploymentTargetsShrink { get; set; }

        /// <summary>
        /// <para>The description of the update operation.</para>
        /// <para>The description must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Update stack instances in hangzhou and beijing</para>
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// <para>The preference settings of the update operation.</para>
        /// <para>The following parameters are available:</para>
        /// <list type="bullet">
        /// <item><description><para>{&quot;FailureToleranceCount&quot;: N}</para>
        /// <para> The number of accounts within which stack operation failures are allowed in each region. If the value of this parameter is exceeded in a region, ROS stops the operation in the region. If ROS stops the operation in one region, ROS stops the operation in other regions.</para>
        /// <para> Valid values of N: 0 to 20.</para>
        /// <para> If you do not specify FailureToleranceCount, 0 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;FailureTolerancePercentage&quot;: N}</para>
        /// <para> The percentage of the number of accounts within which stack operation failures are allowed to the total number of accounts in each region. If the value of this parameter is exceeded, ROS stops the operation in the region.</para>
        /// <para> Valid values of N: 0 to 100. If the numeric value in the percentage is not an integer, ROS rounds the value down to the nearest integer.</para>
        /// <para> If you do not specify FailureTolerancePercentage, 0 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentCount&quot;: N}</para>
        /// <para> The maximum number of accounts within which multiple stacks are deployed at the same time in each region.</para>
        /// <para> Valid values of N: 1 to 20.</para>
        /// <para> If you do not specify MaxConcurrentCount, 1 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentPercentage&quot;: N}</para>
        /// <para>  The percentage of the maximum number of accounts within which stacks are deployed at the same time to the total number of accounts in each region.</para>
        /// <para>  Valid values: 1 to 100. If the numeric value in the percentage is not an integer, ROS rounds the value down to the nearest integer.</para>
        /// <para>  If you do not specify MaxConcurrentPercentage, 1 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>{&quot;RegionConcurrencyType&quot;: N}</para>
        /// <para>The mode that you want to use to deploy stacks across regions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SEQUENTIAL (default): deploys stacks in the specified regions one by one in sequence. This way, ROS deploys stacks in only one region at a time. </para>
        /// </description></item>
        /// <item><description><para>PARALLEL: deploys stacks in all the specified regions in parallel.</para>
        /// </description></item>
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
        /// <para>{&quot;FailureToleranceCount&quot;: 1,&quot;MaxConcurrentCount&quot;: 2}</para>
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        /// <summary>
        /// <para>The parameters that are used to override specific parameters.</para>
        /// </summary>
        [NameInMap("ParameterOverrides")]
        [Validation(Required=false)]
        public List<UpdateStackInstancesShrinkRequestParameterOverrides> ParameterOverrides { get; set; }
        public class UpdateStackInstancesShrinkRequestParameterOverrides : TeaModel {
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
            /// <para>The value of parameter N that you want to use to override a specific parameter. If you do not specify this parameter, ROS uses the value that you specified when you created the stack group.</para>
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
        /// <para>The IDs of the regions where you want to update the stacks. You can specify up to 20 region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;, &quot;cn-beijing&quot;]</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

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
        /// <para>The timeout period for the update operation.</para>
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
