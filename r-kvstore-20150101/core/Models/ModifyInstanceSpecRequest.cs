// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal. If you set this parameter to <b>false</b>, the instance must be manually renewed before it expires. For more information, see <a href="https://help.aliyun.com/document_detail/26352.html">Renew an instance</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of the promotional event or business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000001</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: <c>youhuiquan_promotion_option_id_for_blank</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The time when to change the configurations. Default value: Immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The configurations are immediately changed.</description></item>
        /// <item><description><b>MaintainTime</b>: The configurations are changed within the maintenance window. You can call the <a href="https://help.aliyun.com/document_detail/61000.html">ModifyInstanceMaintainTime</a> operation to change the maintenance window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced transmission during a configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Before the configuration change, the system checks the minor version of the instance. If the minor version of the instance is outdated, an error is reported. You must update the minor version of the instance and try again.</description></item>
        /// <item><description><b>true</b>: The system skips the version check and directly performs the configuration change.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceTrans")]
        [Validation(Required=false)]
        public bool? ForceTrans { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully change the configurations of the instance. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The system does not forcefully change the configurations.</description></item>
        /// <item><description><b>true</b>: The system forcefully changes the configurations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>The new instance type. You can call the <a href="https://help.aliyun.com/document_detail/120580.html">DescribeAvailableResource</a> operation to query the instance types available for configuration change within the zone to which the instance belongs.</para>
        /// <remarks>
        /// <para> For more information about the instance types, see <a href="https://help.aliyun.com/document_detail/26350.html">Overview</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/60933.html">DescribeInstances</a> operation to query the ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The major version to which you want to upgrade the instance. When you change the configurations of an instance, you can upgrade the major version of the instance by setting this parameter. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>. We recommend that you upgrade the major version to 5.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MASTER_SLAVE</b>: high availability (master-replica)</description></item>
        /// <item><description><b>STAND_ALONE</b>: standalone</description></item>
        /// <item><description><b>double</b>: master-replica</description></item>
        /// <item><description><b>single</b>: standalone</description></item>
        /// </list>
        /// <remarks>
        /// <para> For cloud-native instances, set this parameter to <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b>. For classic instances, set this parameter to <b>double</b> or <b>single</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The change type. This parameter is required when you change the configurations of a subscription instance. Default value: UPGRADE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b>: upgrades the configurations of a subscription instance.</description></item>
        /// <item><description><b>DOWNGRADE</b>: downgrades the configurations of a subscription instance.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To downgrade a subscription instance, you must set this parameter to <b>DOWNGRADE</b>.</para>
        /// </description></item>
        /// <item><description><para>If the price of an instance increases after its configurations are changed, the instance is upgraded. If the price decreases, the instance is downgraded. For example, the price of an 8 GB read/write splitting instance with five read replicas is higher than that of a 16 GB cluster instance. If you want to change a 16 GB cluster instance to an 8 GB read/write splitting instance with five read replicas, you must upgrade the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DOWNGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the primary zone. Valid values: 0 to 5. This parameter applies only to the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If the instance is a standard instance that uses cloud disks, you can set this parameter to a value greater than 0 to enable the read/write splitting architecture.</description></item>
        /// <item><description>If the instance is a read/write splitting instance that uses cloud disks, you can use this parameter to customize the number of read replicas. You can also set this parameter to 0 to disable the read/write splitting architecture and switch the instance to the standard architecture.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61012.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of shards. This parameter is available only for cluster instances that use cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the secondary zone. This parameter is used to create a read/write splitting instance that is deployed in multiple zones. Valid values: 1 to 9. The sum of the SlaveReadOnlyCount and ReadOnlyCount values cannot be greater than 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>The source of the operation. This parameter is used only for internal maintenance. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
