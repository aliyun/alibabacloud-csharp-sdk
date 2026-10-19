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
        /// <para>The storage capacity used to specify the instance type, in MB. This parameter is used only to query Redis Community Edition instances in classic deployment mode. We recommend that you use the <b>InstanceClass</b> parameter to specify an exact instance type.</para>
        /// <remarks>
        /// <para>After you specify the <b>InstanceClass</b> parameter, you do not need to specify this parameter.</para>
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
        /// <para>Specifies whether to forcibly change the configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: yes.</description></item>
        /// <item><description><b>true</b> (default): no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>The instance type specified by using the <b>InstanceClass</b> code. To find the <b>InstanceClass</b> code:</para>
        /// <ol>
        /// <item><description>In the <a href="https://help.aliyun.com/document_detail/26350.html">instance type navigation</a>, select the desired instance type and click the value in the <b>Architecture</b> column to open the specification document.</description></item>
        /// <item><description>In the instance type table of the specification document, find the desired instance type and locate the code in the <b>InstanceClass</b> column.</description></item>
        /// </ol>
        /// <remarks>
        /// <para>The following example describes the parameters required for querying the price of a new instance. In addition to other key parameters, specify at least the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>Classic Edition instance: specify this parameter.</description></item>
        /// <item><description>Cloud-native Edition standard architecture instance: specify this parameter.</description></item>
        /// <item><description>Cloud-native Edition cluster architecture instance: specify this parameter and the <b>ShardCount</b> parameter.</description></item>
        /// <item><description>Cloud-native Edition read/write splitting architecture instance: specify this parameter and the <b>Instances</b> parameter.</description></item>
        /// <item><description>Multiple instances of different types, or Tair ESSD-based instances (custom storage type and storage capacity): specify the Instances parameter (this parameter is not required).</description></item>
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
        /// <para>If you want to query the price of cloud-native read/write splitting architecture instances, Tair ESSD-based instances, or multiple instances of different types, specify this parameter. The value is a JSON-formatted string. For more information, see <b>Additional description of the Instances parameter</b> below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RegionId&quot;: &quot;cn-hangzhou&quot;,&quot;ZoneId&quot;: &quot;cn-hangzhou-b&quot;,&quot;ShardClass&quot;: &quot;tair.scm.with.proxy.standard.2m.8d&quot;,&quot;ShardCount&quot;: &quot;3&quot;,&quot;Period&quot;: &quot;1&quot;,&quot;Quantity&quot;: &quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STAND_ALONE</b>: standalone (single replica).</description></item>
        /// <item><description><b>MASTER_SLAVE</b> (default): high availability (dual replicas).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return order parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): does not return order parameters.</description></item>
        /// <item><description><b>true</b>: returns order parameters.</description></item>
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
        /// <item><description><b>BUY</b>: new purchase.</description></item>
        /// <item><description><b>UPGRADE</b>: configuration change.</description></item>
        /// <item><description><b>RENEW</b>: renewal.</description></item>
        /// <item><description><b>CONVERT</b>: billing method conversion.</description></item>
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
        /// <para>The subscription duration, in months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> to query available regions.</para>
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
        /// <para>The secondary zone ID. You can call <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> to query available zones.</para>
        /// <remarks>
        /// <para>The value of this parameter must be different from the value of the ZoneId parameter.</para>
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
        /// <para>The number of data shard nodes in a cloud-native cluster instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> to query available zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
