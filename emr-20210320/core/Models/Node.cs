// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Node : TeaModel {
        /// <summary>
        /// <para>Whether auto-renewal is enabled for the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Auto-renewal is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration for the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("AutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string AutoRenewDurationUnit { get; set; }

        /// <summary>
        /// <para>The creation time of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603728394857</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The expiration time of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603728394857</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The instance type of the node. This corresponds to an ECS instance type. You can call the ECS <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the available instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g7.xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The maintenance status of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ON: The node is in maintenance mode.</para>
        /// </description></item>
        /// <item><description><para>OFF: The node is not in maintenance mode.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is empty, the node is not in maintenance mode.</para>
        /// </summary>
        [NameInMap("MaintenanceStatus")]
        [Validation(Required=false)]
        public string MaintenanceStatus { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The type of the node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MASTER: A master node group.</para>
        /// </description></item>
        /// <item><description><para>CORE: A core node group.</para>
        /// </description></item>
        /// <item><description><para>TASK: A task node group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CORE</para>
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1cudc25w2bfwl5****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The name of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>core1-1</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The state of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The node is being created.</para>
        /// </description></item>
        /// <item><description><para>Starting: The node is starting up.</para>
        /// </description></item>
        /// <item><description><para>Running: The node is operational and running services.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The node is shutting down.</para>
        /// </description></item>
        /// <item><description><para>Stopped: The node is powered off.</para>
        /// </description></item>
        /// <item><description><para>Terminated: The node has been permanently deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("NodeState")]
        [Validation(Required=false)]
        public string NodeState { get; set; }

        /// <summary>
        /// <para>The private IP address of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.10.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// <para>The public IP address of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.1.1.**</para>
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>The ID of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
