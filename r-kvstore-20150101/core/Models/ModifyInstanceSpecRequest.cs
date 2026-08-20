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
        /// <item><description><b>false</b>: Automatic payment is disabled. If you set this parameter to <b>false</b>, you must manually renew the instance before the instance expires in the console. For details, see <a href="https://help.aliyun.com/document_detail/26352.html">Manual renewal</a>.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <para>The time when the specification change takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The specification change takes effect immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: The specification change takes effect during the maintenance window of the instance. You can call <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> to modify the maintenance window.</description></item>
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
        /// <item><description><b>false</b> (default): Before the specification change, the system checks the current minor engine version of the instance. If the minor engine version is too old, an error is returned. You must upgrade the minor engine version and retry.</description></item>
        /// <item><description><b>true</b>: Skips the check and directly executes the specification change operation.</description></item>
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
        /// <item><description><b>false</b>: does not forcibly change the specifications.</description></item>
        /// <item><description><b>true</b>: forcibly changes the specifications. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>The new instance type. You can call <a href="https://help.aliyun.com/document_detail/473765.html">DescribeAvailableResource</a> to query the instance types available for specification changes in the zone where the instance resides.</para>
        /// <remarks>
        /// <para>For more information about instance types, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance type navigation</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The major engine version for upgrading a classic instance. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
        /// <remarks>
        /// <para>When you upgrade the version, the <b>InstanceClass</b> parameter is required. This indicates that this operation supports version upgrades only when the instance specifications are also changed. To upgrade only the instance version, call <a href="https://help.aliyun.com/document_detail/473776.html">ModifyInstanceMajorVersion</a>.</para>
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
        /// <item><description><b>MASTER_SLAVE</b>: high availability (dual-replica)</description></item>
        /// <item><description><b>STAND_ALONE</b>: single replica</description></item>
        /// <item><description><b>double</b>: dual-replica</description></item>
        /// <item><description><b>single</b>: single replica<remarks>
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
        /// <para>The type of specification change. This parameter is required when you change the specifications of a subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b>: Upgrade. This is the default value.</description></item>
        /// <item><description><b>DOWNGRADE</b>: Downgrade.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must set this parameter to <b>DOWNGRADE</b> when you downgrade a subscription instance.</description></item>
        /// <item><description>If the price of the target instance type is higher than that of the current instance type, the change is an upgrade. Otherwise, the change is a downgrade. For example, the price of the read/write splitting 8 GB edition (5 read-only nodes) is higher than that of the 16 GB cluster edition. Changing from the latter to the former is an upgrade.</description></item>
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
        /// <para>The number of read-only nodes in the primary zone. This parameter is applicable only to cloud-native read/write splitting instances.</para>
        /// <list type="bullet">
        /// <item><description>For standard architecture instances, valid values are 0 to 9. A value of 0 indicates that read/write splitting is shutdown and the instance is switched to the standard architecture.</description></item>
        /// <item><description>For cluster architecture instances, valid values are 1 to 4, which specifies the number of read-only nodes per data shard.<remarks>
        /// <para>For multi-zone instances, you can use this parameter together with the SlaveReadOnlyCount parameter to specify the number of read-only nodes in the primary and secondary zones.</para>
        /// <list type="bullet">
        /// <item><description>For standard architecture instances, the sum of this parameter and SlaveReadOnlyCount cannot exceed 9.</description></item>
        /// <item><description>For cluster architecture instances, the sum of this parameter and SlaveReadOnlyCount cannot exceed 4.</description></item>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> to query available regions. Use this parameter to specify the region of the instance whose specifications you want to change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the primary zone. This parameter is applicable only to cloud-native cluster multi-replica instances. You can use this parameter to specify a custom number of replica nodes. Valid values: 1 to 4.</para>
        /// <remarks>
        /// <para>For multi-zone instances, you can use this parameter together with the SlaveReplicaCount parameter to specify the number of replica nodes in the primary and secondary zones. The sum of this parameter and the SlaveReplicaCount parameter cannot exceed 4.</para>
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
        /// <para>The secondary zone ID. This parameter is required when you change the specifications of a single-zone instance and migrate it to a multi-zone deployment. You can call <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> to query available zones.</para>
        /// <remarks>
        /// <para>The value of this parameter must be different from the value of the ZoneId parameter. Do not set this parameter to the ID of a multi-zone.</para>
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
        /// <para>The number of shards. This parameter is applicable only to cloud-native cluster instances. You can use this parameter to specify a custom number of shards.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To change a cloud-native cluster instance to a standard architecture, set ShardCount to 1 and set the instance type to a standard instance type.</description></item>
        /// <item><description>To change a cloud-native standard instance to a cluster architecture, set ShardCount to a value greater than 1 and set the instance type to a cluster instance type.</description></item>
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
        /// <para>The number of replica nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>The source of the request. This parameter is used only for internal maintenance and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// <para>The storage capacity of a cloud disk instance. The valid values vary based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/2527111.html">Cloud disk-based instance types</a>.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>InstanceType</b> is set to <b>tair_essd</b> and you are creating a Tair ESSD-based cloud disk instance. For Tair SSD-based cloud disk instances, the storage capacity is a fixed value based on the instance type, and you do not need to specify this parameter.</para>
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
        /// <para>This parameter is required only when <b>InstanceType</b> is set to <b>tair_essd</b> and the instance is a Tair ESSD-based cloud disk instance.</para>
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
