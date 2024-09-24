// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can be up to 64 characters in length.\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The option for returning logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: does not return logs.</description></item>
        /// <item><description>Stack (default): returns the logs of the stack.</description></item>
        /// <item><description>Resource: returns the logs of resources in the stack.</description></item>
        /// <item><description>All: returns all logs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stack</para>
        /// </summary>
        [NameInMap("LogOption")]
        [Validation(Required=false)]
        public string LogOption { get; set; }

        /// <summary>
        /// <para>Specifies whether to return Outputs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled (default)</description></item>
        /// <item><description>Disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para> The Outputs parameter requires a long period of time to calculate. If you do not require Outputs of the stack, we recommend that you set OutputOption to Disabled to improve the response speed of the GetStack operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about ResourceProgress. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Disabled (default): does not return information about ResourceProgress.</description></item>
        /// <item><description>PercentageOnly: returns StackOperationProgress and StackActionProgress of ResourceProgress.</description></item>
        /// </list>
        /// <remarks>
        /// <para> ROS and Terraform stacks are supported. Creation, resumed creation, update, deletion, import, and rollback operations on stacks are supported.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>EnabledIfCreateStack (not recommend): returns \*Count and InProgressResourceDetails of ResourceProgress only during a stack creation operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para> During a creation operation, a stack is in one of the following states: CREATE_IN_PROGRESS, CREATE_COMPLETE, CREATE_FAILED, CREATE_ROLLBACK_IN_PROGRESS, CREATE_ROLLBACK_COMPLETE, and CREATE_ROLLBACK_FAILED.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("ShowResourceProgress")]
        [Validation(Required=false)]
        public string ShowResourceProgress { get; set; }

        /// <summary>
        /// <para>The stack ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c754d2a4-28f1-46df-b557-9586173a****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
