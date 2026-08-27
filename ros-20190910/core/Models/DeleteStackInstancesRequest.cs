// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DeleteStackInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the accounts from which to delete stack instances. This parameter applies only to stack groups that use self-managed permissions. You can specify up to 50 account IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;151266687691****&quot;]</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use your client to generate the token, but you must make sure that the token is unique among different requests.<br>The token can be up to 64 characters long and can contain letters, digits, hyphens (-), and underscores (_).<br>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment targets from which to delete stack instances. This parameter applies only to stack groups that use service-managed permissions.</para>
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public DeleteStackInstancesRequestDeploymentTargets DeploymentTargets { get; set; }
        public class DeleteStackInstancesRequestDeploymentTargets : TeaModel {
            /// <summary>
            /// <para>The IDs of member accounts in the resource directory. You can specify up to 30 member account IDs.</para>
            /// <remarks>
            /// <para>You can find the member account IDs on the Overview page in the Resource Management console. For more information, see <a href="https://help.aliyun.com/document_detail/111624.html">View the details of a member</a>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<string> AccountIds { get; set; }

            /// <summary>
            /// <para>The IDs of folders in the resource directory. You can specify up to 20 folder IDs.</para>
            /// <para>Stack instances are deleted from all member accounts in the specified folders. If you specify the Root folder, stack instances are deleted from all member accounts in your resource directory.</para>
            /// <remarks>
            /// <para>You can find the folder IDs on the Overview page in the Resource Management console. For more information, see <a href="https://help.aliyun.com/document_detail/111223.html">View the basic information of a folder</a>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

        }

        /// <summary>
        /// <para>The description of the operation to delete stack instances.</para>
        /// <para>The description can be 1 to 256 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Delete stack instances in hangzhou and beijing</para>
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// <para>The preferences for the operation to delete stack instances.</para>
        /// <para>This parameter contains the following subparameters:</para>
        /// <list type="bullet">
        /// <item><description><para>{&quot;FailureToleranceCount&quot;: N}</para>
        /// <para>The number of accounts in each region for which the deletion of stack instances can fail. If the number of failures in a region exceeds this value, the operation stops in that region. If the operation stops in one region, it does not continue in other regions.</para>
        /// <para>The value of N must be an integer from 0 to 20.</para>
        /// <para>If you do not specify FailureToleranceCount, the default value is 0.</para>
        /// </description></item>
        /// <item><description><para>{&quot;FailureTolerancePercentage&quot;: N}</para>
        /// <para>The percentage of accounts in each region for which the deletion of stack instances can fail. If the percentage of failures in a region exceeds this value, the operation stops in that region.</para>
        /// <para>The value of N must be an integer from 0 to 100. If the calculated percentage is not an integer, ROS rounds it down to the nearest integer.</para>
        /// <para>If you do not specify FailureTolerancePercentage, the default value is 0.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentCount&quot;: N}</para>
        /// <para>The maximum number of accounts in each region for which stack instances can be deleted at the same time.</para>
        /// <para>The value of N must be an integer from 1 to 20.</para>
        /// <para>If you do not specify MaxConcurrentCount, the default value is 1.</para>
        /// </description></item>
        /// <item><description><para>{&quot;MaxConcurrentPercentage&quot;: N}</para>
        /// <para>The maximum percentage of accounts in each region for which stack instances can be deleted at the same time.</para>
        /// <para>The value of N must be an integer from 1 to 100. If the calculated percentage is not an integer, ROS rounds it down to the nearest integer.</para>
        /// <para>If you do not specify MaxConcurrentPercentage, the default value is 1.</para>
        /// </description></item>
        /// <item><description><para>{&quot;RegionConcurrencyType&quot;: N}
        /// The concurrency model for deleting stack instances in different regions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SEQUENTIAL (default): Deletes stack instances in each specified region sequentially. At any given time, the operation deletes stack instances in only one region.</para>
        /// </description></item>
        /// <item><description><para>PARALLEL: Deletes stack instances in all specified regions in parallel.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Separate multiple parameters with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You cannot specify both MaxConcurrentCount and MaxConcurrentPercentage.</para>
        /// </description></item>
        /// <item><description><para>You cannot specify both FailureToleranceCount and FailureTolerancePercentage.</para>
        /// </description></item>
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
        /// <para>The region ID of the stack group. Call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the regions where the stack instances are deployed. You can specify up to 20 region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;, &quot;cn-beijing&quot;]</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the stacks.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The stacks are retained.</para>
        /// </description></item>
        /// <item><description><para>false: The stacks are deleted.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RetainStacks")]
        [Validation(Required=false)]
        public bool? RetainStacks { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region.<br>The name can be up to 255 characters long. It must start with a letter or a digit and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
