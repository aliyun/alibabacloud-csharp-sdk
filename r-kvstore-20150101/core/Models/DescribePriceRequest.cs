// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The extended information such as the promotional event ID and business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Unit: MB. This parameter is used only to query Redis Open-Source Edition instances that are deployed in classic mode. We recommend that you use the <b>InstanceClass</b> parameter to specify an exact instance type.</para>
        /// <remarks>
        /// <para> If you specify the <b>InstanceClass</b> parameter, you do not need to specify the Capacity parameter.</para>
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
        /// <item><description><b>PostPaid</b> (default): pay-as-you-go</description></item>
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: youhuiquan_promotion_option_id_for_blank. This value indicates that no coupon code is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The engine version of the instance. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully change the configurations of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: forcefully changes the configurations.</description></item>
        /// <item><description><b>true</b> (default): does not forcefully change the configurations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <para><b>To view the instance type, perform the following steps:</b></para>
        /// <ol>
        /// <item><description>In the <a href="https://help.aliyun.com/document_detail/26350.html">Overview</a> topic, click the link in the <b>Reference</b> column corresponding to the instance type that you want to view.</description></item>
        /// <item><description>In the instance type table of the page that appears, find the instance type in the <b>InstanceClass</b> column.</description></item>
        /// </ol>
        /// <para>When you query cloud-native cluster instances, you must set this parameter to one of the following values and use the Instances parameter to specify the instance type that you want to query.</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB for Redis cluster instances: redis.cluster.sharding.common.ce</description></item>
        /// <item><description>Tair DRAM-based cluster instances: tair.rdb.cluster.sharding.common</description></item>
        /// <item><description>Tair persistent memory-based cluster instances: tair.scm.cluster.sharding.common.ce</description></item>
        /// </list>
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
        /// <para> This parameter is required when the <b>OrderType</b> parameter is set to <b>UPGRADE</b> or <b>RENEW</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A JSON string that contains information about one or more cloud-native cluster instances. For more information, see the &quot;Additional description of the Instances parameter&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instances=[{&quot;RegionId&quot;: &quot;cn-hangzhou&quot;,&quot;ZoneId&quot;: &quot;cn-hangzhou-b&quot;,&quot;InstanceClass&quot;: &quot;redis.master.small.default&quot;,&quot;Period&quot;: &quot;1&quot;,&quot;Quantity&quot;: &quot;1&quot;,&quot;Capacity&quot;: &quot;4096&quot;}]</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STAND_ALONE</b>: standalone</description></item>
        /// <item><description><b>MASTER_SLAVE</b> (default): high availability (master-replica)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return parameters related to the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
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
        /// <item><description><b>BUY</b>: specifies the orders that are used to purchase instances.</description></item>
        /// <item><description><b>UPGRADE</b>: specifies the orders that are used to change the configurations of instances.</description></item>
        /// <item><description><b>RENEW</b>: specifies the orders that are used to renew instances.</description></item>
        /// <item><description><b>CONVERT</b>: specifies the orders that are used to change the billing methods of instances.</description></item>
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
        /// <para>The subscription duration. Unit: months. Valid values: <b>1</b>, 2, 3, 4, 5, 6, 7, 8, <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The number of instances that you want to purchase. Valid values: <b>1</b> to <b>30</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of shards. This parameter is applicable only to cloud-native cluster instances. You can use this parameter to customize the number of shards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
