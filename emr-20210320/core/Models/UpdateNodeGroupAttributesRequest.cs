// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateNodeGroupAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The ACK cluster configuration.</para>
        /// </summary>
        [NameInMap("AckConfig")]
        [Validation(Required=false)]
        public AckConfig AckConfig { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The list of security group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sg-hp3abbae8lb6lmb1****&quot;]</para>
        /// </summary>
        [NameInMap("AdditionalSecurityGroupIds")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AdditionalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The automatic compensation state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCompensateState")]
        [Validation(Required=false)]
        public bool? AutoCompensateState { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cost-optimized mode configuration.</para>
        /// </summary>
        [NameInMap("CostOptimizedConfig")]
        [Validation(Required=false)]
        public CostOptimizedConfig CostOptimizedConfig { get; set; }

        /// <summary>
        /// <para>The node group description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr-core-1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The spot instance strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("EcsSpotStrategy")]
        [Validation(Required=false)]
        public string EcsSpotStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable graceful decommission. When a cluster is created in V303, graceful decommission is disabled by default for task groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableGracefulDecommission")]
        [Validation(Required=false)]
        public bool? EnableGracefulDecommission { get; set; }

        /// <summary>
        /// <para>The list of ECS instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The key pair for ECS logon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_pair</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        [Obsolete]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// <para>The minimum number of instances in the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        /// <summary>
        /// <para>The target number of nodes in the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <para>The node group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The node group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CORE1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>The node scale-out strategy. Valid values: COST_OPTIMIZED and PRIORITY. Default value: PRIORITY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("NodeResizeStrategy")]
        [Validation(Required=false)]
        public string NodeResizeStrategy { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The maximum bid prices for spot instances. This parameter takes effect only when spotStrategy is set to SpotWithPriceLimit.</para>
        /// </summary>
        [NameInMap("SpotBidPrices")]
        [Validation(Required=false)]
        public List<SpotBidPrice> SpotBidPrices { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable spot instance supplementation. If this feature is enabled, the scaling group attempts to create new instances to replace spot instances that are about to be reclaimed when the system sends a reclamation notification. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-hp35g7ya5ymw68mmg****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        [Obsolete]
        public string VSwitchId { get; set; }

    }

}
