// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic payment is enabled. This is the default value.</description></item>
        /// <item><description><b>false</b>: Manual payment is enabled. If this parameter is set to <b>false</b>, you must manually renew the instance in the console before the instance expires. For more information, see <a href="https://help.aliyun.com/document_detail/26352.html">Manual renewal</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The activity ID and business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000001</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <para>The time when the specification change is executed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The change is executed immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: The change is executed during the maintenance window of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> operation to modify the maintenance window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced transmission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Before the specification change, the system checks the current minor kernel version of the instance. If the Milvus version is too low, an error is reported. You must upgrade the minor kernel version and retry.</description></item>
        /// <item><description><b>true</b>: The check is skipped and the specification change is directly executed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceTrans")]
        [Validation(Required=false)]
        public bool? ForceTrans { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly change the specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The specifications are not forcibly changed.</description></item>
        /// <item><description><b>true</b>: The specifications are forcibly changed. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>The instance type code after the change. You can call the <a href="https://help.aliyun.com/document_detail/473765.html">DescribeAvailableResource</a> operation to query the available instance types in the zone to which the instance belongs.</para>
        /// <remarks>
        /// <para>For more information about instance types, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The major version to which you want to upgrade a classic instance. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
        /// <remarks>
        /// <para>When you upgrade the major version, the <b>InstanceClass</b> parameter is required. This indicates that this operation only supports upgrading the major version when you update the instance specifications. If you only need to upgrade the major version, call the <a href="https://help.aliyun.com/document_detail/473776.html">ModifyInstanceMajorVersion</a> operation.</para>
        /// </remarks>
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
        /// <item><description><b>MASTER_SLAVE</b>: The high-availability (dual-replica) architecture.</description></item>
        /// <item><description><b>STAND_ALONE</b>: The single-replica architecture.</description></item>
        /// <item><description><b>double</b>: The dual-replica architecture.</description></item>
        /// <item><description><b>single</b>: The single-replica architecture.<remarks>
        /// <para>For cloud-native instances, select <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b>. For classic instances, select <b>double</b> or <b>single</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The type of the specification change. This parameter is required when you change the specifications of a subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b>: Upgrades the configurations. This is the default value.</description></item>
        /// <item><description><b>DOWNGRADE</b>: Downgrades the configurations.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you downgrade the configurations of a subscription instance, you must set this parameter to <b>DOWNGRADE</b>.</description></item>
        /// <item><description>If the price of the target specifications is higher than that of the current specifications, the operation is an upgrade. Otherwise, the operation is a downgrade. For example, the price of the 8 GB read/write splitting edition with 5 read-only nodes is higher than that of the 16 GB cluster edition. Changing the specifications from the latter to the former is an upgrade.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The number of read-only nodes in the primary zone. This parameter applies only to creating cloud-native read/write splitting instances.</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses the standard architecture, valid values are 0 to 9. A value of 0 indicates that read/write splitting is disabled and the instance is switched to the standard architecture.</description></item>
        /// <item><description>If the instance uses the cluster architecture, valid values are 1 to 4, which indicates the number of read-only nodes per shard.<remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and the SlaveReadOnlyCount parameter to specify the number of read-only nodes in the primary and secondary zones.</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses the standard architecture, the sum of this parameter and SlaveReadOnlyCount cannot be greater than 9.</description></item>
        /// <item><description>If the instance uses the cluster architecture, the sum of this parameter and SlaveReadOnlyCount cannot be greater than 4.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query available regions. Use this parameter to specify the region of the instance whose specifications you want to change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of secondary nodes in the primary zone. This parameter applies only to cloud-native multi-replica cluster instances. You can use this parameter to specify a custom number of secondary nodes. Valid values: 1 to 4.</para>
        /// <remarks>
        /// <para>If the instance is deployed across multiple zones, you can use this parameter and the SlaveReplicaCount parameter to specify the number of secondary nodes in the primary and secondary zones. The sum of this parameter and the SlaveReplicaCount parameter cannot exceed 4.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone. When you change the specifications of a single-zone instance and migrate it to multiple zones, you must specify the secondary zone ID. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the zone ID.</para>
        /// <remarks>
        /// <para>The value of this parameter cannot be the same as that of the ZoneId parameter, and you cannot specify the ID of a multi-zone deployment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of shards. This parameter applies only to cloud-native cluster instances. You can use this parameter to specify a custom number of shards.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To change a cloud-native cluster instance to a standard instance, you must explicitly set ShardCount to 1 and specify a standard instance type.</description></item>
        /// <item><description>To change a cloud-native standard instance to a cluster instance, you must explicitly set ShardCount to a value greater than 1 and specify a cluster instance type.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of secondary nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>The source of the call. This parameter is used only for internal maintenance and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// <para>The storage capacity of the disk instance. The value range varies based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/2527111.html">Disk instance types</a>.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>InstanceType</b> is set to <b>tair_essd</b> and you create a Tair ESSD instance. When you create a Tair SSD instance, the capacity field is defined as a fixed value based on the instance type, and you do not need to specify this field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values: <b>essd_pl1</b>, <b>essd_pl2</b>, and <b>essd_pl3</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>InstanceType</b> is set to <b>tair_essd</b> and the instance is a Tair ESSD instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>essd_pl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
