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
        /// <item><description><b>true</b> (default): enables automatic payment.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. If you set this parameter to <b>false</b>, the instance must be manually renewed before it expires. For more information, see <a href="https://help.aliyun.com/document_detail/26352.html">Renew an instance</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of the promotional event or the business information.</para>
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
        /// <para>The time when you want the configurations to be changed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b> (default): immediately changes the configurations.</description></item>
        /// <item><description><b>MaintainTime</b>: changes the configurations within the maintenance window. You can call the <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> operation to change the maintenance window.</description></item>
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
        /// <para>Specifies whether to forcibly change the configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The system does not forcefully change the configurations.</description></item>
        /// <item><description><b>true</b> (default): The system forcefully changes the configurations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>The new instance type. You can call the <a href="https://help.aliyun.com/document_detail/473765.html">DescribeAvailableResource</a> operation to query the instance types available for configuration change within the zone to which the instance belongs.</para>
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
        /// <para>The major version of the classic instance that you want to upgrade. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
        /// <remarks>
        /// <para> The <b>InstanceClass</b> parameter is required when you upgrade the instance version. This parameter indicates that you can upgrade the instance version only when you update the instance specifications. If you only need to upgrade the instance version, call the <a href="https://help.aliyun.com/document_detail/473776.html">ModifyInstanceMajorVersion</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// <para>The type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MASTER_SLAVE</b>: high availability (master-replica)</description></item>
        /// <item><description><b>STAND_ALONE</b>: standalone</description></item>
        /// <item><description><b>double</b>: master-replica</description></item>
        /// <item><description><b>single</b>: standalone</description></item>
        /// </list>
        /// <remarks>
        /// <para> To create a cloud-native instance, set this parameter to <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b>. To create a classic instance, set this parameter to <b>double</b> or <b>single</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The change type. This parameter is required when you change the configurations of a subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b> (default): upgrades the configurations of the subscription instance.</description></item>
        /// <item><description><b>DOWNGRADE</b>: downgrades the configurations of the subscription instance.</description></item>
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
        /// <item><description>If the instance is a cloud-native standard instance, you can set this parameter to a value greater than 0 to enable the read/write splitting architecture.</description></item>
        /// <item><description>If the instance is a cloud-native read/write splitting instance, you can use this parameter to customize the number of read replicas. You can also set this parameter to 0 to disable the read/write splitting architecture and switch the instance to the standard architecture.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the primary zone. This parameter is applicable only to cloud-native multi-replica cluster instances. Valid values: 1 to 4.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The sum of the values of this parameter and the SlaveReplicaCount parameter cannot be greater than 4.</para>
        /// </description></item>
        /// <item><description><para>You can specify either ReplicaCount or ReadOnlyCount.</para>
        /// </description></item>
        /// <item><description><para>A master-replica instance cannot contain multiple replica nodes.</para>
        /// </description></item>
        /// </list>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of shards. This parameter is applicable only to cloud-native cluster instances.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you want to change a cloud-native cluster instance to a standard instance, you must explicitly set the ShardCount parameter to 1 and specify the specifications of the master-replica instance.</para>
        /// </description></item>
        /// <item><description><para>To change a cloud-native standard instance to a cluster instance, you must explicitly set the ShardCount parameter to a value greater than 1 and specify the specifications of the cluster instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the secondary zone when you create a read/write splitting instance that is deployed across multiple zones. Valid values: 1 to 9. The sum of the values of this parameter and the ReadOnlyCount parameter cannot be greater than 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the secondary zone when you create a cloud-native multi-replica cluster instance that is deployed across multiple zones. The sum of the values of this parameter and the ReplicaCount parameter cannot be greater than 4.</para>
        /// <remarks>
        /// <para> When you create a cloud-native multi-replica cluster instance that is deployed across multiple zones, you must specify both SlaveReplicaCount and SecondaryZoneId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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

        /// <summary>
        /// <para>The storage capacity of the ESSD/SSD-based instance. The valid values vary based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/2527111.html">ESSD/SSD-based instances</a>.</para>
        /// <remarks>
        /// <para> This parameter is required only when you set the <b>InstanceType</b> parameter to <b>tair_essd</b> to create an ESSD-based instance. If you create a Tair <b>SSD</b>-based instance, the Storage parameter is automatically specified based on predefined specifications. You do not need to specify this parameter.</para>
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
        /// <para> This parameter is required only when you set the <b>InstanceType</b> parameter to <b>tair_essd</b> to create an ESSD-based instance.</para>
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
