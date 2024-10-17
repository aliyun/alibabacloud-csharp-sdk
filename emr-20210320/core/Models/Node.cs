// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Node : TeaModel {
        /// <summary>
        /// <para>节点是否自动续费。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>节点自动续费时长。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>节点自动续费时长单位。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("AutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string AutoRenewDurationUnit { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>节点过期时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603728394857</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>实例类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6e.xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>运维模式状态。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>ON：处于运维模式。</description></item>
        /// <item><description>OFF：处于非运维模式。</description></item>
        /// </list>
        /// <para>为空表示处于非运维模式。</para>
        /// </summary>
        [NameInMap("MaintenanceStatus")]
        [Validation(Required=false)]
        public string MaintenanceStatus { get; set; }

        /// <summary>
        /// <para>节点组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>节点组类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CORE</para>
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// <para>节点ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1cudc25w2bfwl5****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>节点名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>core1-1</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>节点状态。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>Pending：创建中。</description></item>
        /// <item><description>Starting：启动中。</description></item>
        /// <item><description>Running：运行中。</description></item>
        /// <item><description>Stopping：停止中。</description></item>
        /// <item><description>Stopped：已停止。</description></item>
        /// <item><description>Terminated：已终止。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("NodeState")]
        [Validation(Required=false)]
        public string NodeState { get; set; }

        /// <summary>
        /// <para>私网IP。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.1</para>
        /// </summary>
        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// <para>公网IP。</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.120.75.***</para>
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>可用区ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
