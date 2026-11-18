// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The extended information, such as the promotion ID and business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>Specifies the instance type by using the storage capacity of the instance. Unit: MB. This parameter applies only to instances of ApsaraDB for Redis Community Edition in the classic deployment mode. We recommend that you use the <b>InstanceClass</b> parameter to specify an exact instance type.</para>
        /// <remarks>
        /// <para>If you specify the <b>InstanceClass</b> parameter, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PostPaid</b> (default): pay-as-you-go.</description></item>
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: youhuiquan_promotion_option_id_for_blank, which indicates that no coupon code is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;Database engine version of the Redis instance. Valid values: <b>2.8</b>, <b>4.0</b>, <b>5.0</b>, and <b>6.0</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;Database engine version of the Redis instance. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;Database engine version of the Redis instance. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly upgrade or downgrade the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Yes.</description></item>
        /// <item><description><b>true</b> (default): No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>Specifies the instance type by using the <b>InstanceClass</b> code. To query the <b>InstanceClass</b> code, perform the following steps:</para>
        /// <ol>
        /// <item><description>On the <a href="https://help.aliyun.com/document_detail/26350.html">Instance type query</a> page, select the instance type as needed and click the value in the <b>Architecture Type</b> column to open the instance type documentation.</description></item>
        /// <item><description>In the instance type table of the documentation, select the required instance type and find the code in the <b>InstanceClass</b> column.</description></item>
        /// </ol>
        /// <remarks>
        /// <para>For example, to query pricing for a new purchase, you must specify at least the following parameters in addition to other key parameters:</para>
        /// <list type="bullet">
        /// <item><description>To query a classic instance: specify this parameter.</description></item>
        /// <item><description>To query a cloud-native standard architecture instance: specify this parameter.</description></item>
        /// <item><description>To query a cloud-native cluster architecture instance: specify this parameter and the <b>ShardCount</b> parameter.</description></item>
        /// <item><description>To query a cloud-native read/write splitting architecture instance: specify this parameter and the <b>Instances</b> parameter.</description></item>
        /// <item><description>To query multiple instances of different types, or to query Tair ESSD instances (with custom storage types and storage space): specify the Instances parameter. You do not need to specify this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>OrderType</b> is set to <b>UPGRADE</b> or <b>RENEW</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instances to query. This parameter is required when you query cloud-native read/write splitting architecture instances, Tair ESSD instances, or multiple instances of different types. The value is a JSON string. For more information, see <b>Supplementary description of the Instances parameter</b> below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RegionId&quot;: &quot;cn-hangzhou&quot;,&quot;ZoneId&quot;: &quot;cn-hangzhou-b&quot;,&quot;ShardClass&quot;: &quot;tair.scm.with.proxy.standard.2m.8d&quot;,&quot;ShardCount&quot;: &quot;3&quot;,&quot;Period&quot;: &quot;1&quot;,&quot;Quantity&quot;: &quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// <para>Specifies whether to return unavailable coupons.</para>
        /// </summary>
        [NameInMap("NeedUnavailableCoupon")]
        [Validation(Required=false)]
        public bool? NeedUnavailableCoupon { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STAND_ALONE</b>: Single-replica.</description></item>
        /// <item><description><b>MASTER_SLAVE</b> (default): High-availability (dual-replica).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the order parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Not returned.</description></item>
        /// <item><description><b>true</b>: Returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OrderParamOut")]
        [Validation(Required=false)]
        public string OrderParamOut { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUY</b>: New purchase.</description></item>
        /// <item><description><b>UPGRADE</b>: Upgrade or downgrade.</description></item>
        /// <item><description><b>RENEW</b>: Renewal.</description></item>
        /// <item><description><b>CONVERT</b>: Billing method conversion.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
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
        /// <para>The subscription duration. Unit: months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The number of instances to purchase. Valid values: <b>1</b> to <b>30</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query available regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The secondary zone ID. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query available zones.</para>
        /// <remarks>
        /// <para>The value of this parameter cannot be the same as the value of the ZoneId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of data shard nodes in the cloud-native cluster instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query available zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
