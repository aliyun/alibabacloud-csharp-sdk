// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyNodeSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically align the primary node to the primary zone after operations such as specification changes for multi-zone instances. If you choose not to align the node, one primary/secondary switchover (transient disconnection) is avoided. Default value: true.</para>
        /// </summary>
        [NameInMap("AlignPrimaryZone")]
        [Validation(Required=false)]
        public bool? AlignPrimaryZone { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Automatic payment is enabled. Make sure that your account has sufficient balance.</description></item>
        /// <item><description><b>false</b>: Manual payment is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The additional parameter that contains business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. Make sure that the value is unique across different requests and contains a maximum of 64 ASCII characters. The value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> or <b>null</b> (default): Use a coupon.</description></item>
        /// <item><description><b>youhuiquan_promotion_option_id_for_blank</b>: Do not use a coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1c0b990184****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The effective period of the configuration change. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b> (default): The configuration change takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The configuration change takes effect within the maintenance window of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The source of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OpenApi</b>: The request is sent from OpenAPI.</description></item>
        /// <item><description><b>mongo_buy</b>: The request is sent from the console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OpenApi</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The specifications of the shard or mongos node. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance specifications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongos.standard</para>
        /// </summary>
        [NameInMap("NodeClass")]
        [Validation(Required=false)]
        public string NodeClass { get; set; }

        /// <summary>
        /// <para>The ID of the shard or mongos node in the sharded cluster instance. You can call the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> operation to query the node ID.</para>
        /// <remarks>
        /// <para>If the value is a shard node ID, you must also specify the <b>NodeStorage</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp143e1b1637****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The storage space of the shard node. The step size is 10 GB.</para>
        /// <list type="bullet">
        /// <item><description>For local SSDs, valid values: <b>10</b> to <b>2000</b>.</description></item>
        /// <item><description>For PL1 ESSDs, valid values: <b>20</b> to <b>16000</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("NodeStorage")]
        [Validation(Required=false)]
        public int? NodeStorage { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b>: Upgrade.</description></item>
        /// <item><description><b>DOWNGRADE</b>: Downgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
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
        /// <para>The number of read-only nodes in the shard node.</para>
        /// <para>Valid values: <b>0</b> to <b>5</b>. The value must be an integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public int? ReadonlyReplicas { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The time when the configuration change is executed. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. Use the EffectiveTime parameter instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-05T03:18:53Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The destination hidden zone for zone migration.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("TargetHiddenZoneId")]
        [Validation(Required=false)]
        public string TargetHiddenZoneId { get; set; }

        /// <summary>
        /// <para>The destination secondary zone for zone migration.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("TargetSecondaryZoneId")]
        [Validation(Required=false)]
        public string TargetSecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the destination vSwitch for zone migration.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxx</para>
        /// </summary>
        [NameInMap("TargetVswitchId")]
        [Validation(Required=false)]
        public string TargetVswitchId { get; set; }

        /// <summary>
        /// <para>The destination primary zone for zone migration.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

    }

}
