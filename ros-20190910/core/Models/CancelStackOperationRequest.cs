// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CancelStackOperationRequest : TeaModel {
        /// <summary>
        /// <para>The operations that you want to cancel on the stack.</para>
        /// </summary>
        [NameInMap("AllowedStackOperations")]
        [Validation(Required=false)]
        public List<string> AllowedStackOperations { get; set; }

        /// <summary>
        /// <para>The method that you want to use to cancel the operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Quick: cancels the operations on the stack at the earliest opportunity. In this case, Resource Orchestration Service (ROS) stops scheduling new resources and stops running resources at the earliest opportunity. If you use this method, the resource status may become invalid and subsequent stack operations may be affected.</description></item>
        /// <item><description>Safe (default): cancels the operations on the stack in a secure manner. In this case, ROS stops scheduling new resources and waits for running resources to be stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Safe</para>
        /// </summary>
        [NameInMap("CancelType")]
        [Validation(Required=false)]
        public string CancelType { get; set; }

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
        /// <para>The stack ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
