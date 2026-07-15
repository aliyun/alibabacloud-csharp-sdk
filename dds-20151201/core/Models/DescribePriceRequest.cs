// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The business information. This is an additional parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AccountPassword&quot;:&quot;Pw123456&quot;,&quot;DBInstanceDescription&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The commodity code of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dds</b>: pay-as-you-go ReplicaSet instance.</para>
        /// </description></item>
        /// <item><description><para><b>badds</b>: subscription ReplicaSet instance.</para>
        /// </description></item>
        /// <item><description><para><b>dds_sharding</b>: pay-as-you-go sharded cluster instance.</para>
        /// </description></item>
        /// <item><description><para><b>badds_sharding</b>: subscription sharded cluster instance.</para>
        /// </description></item>
        /// <item><description><para><b>badds_sharding_intl</b>: subscription sharded cluster instance on the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
        /// </description></item>
        /// <item><description><para><b>dds_sharding_intl</b>: pay-as-you-go sharded cluster instance on the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
        /// </description></item>
        /// <item><description><para><b>badds_sharding_jp</b>: subscription sharded cluster instance on the Alibaba Cloud Japan Website.</para>
        /// </description></item>
        /// <item><description><para><b>badds_intl</b>: subscription ReplicaSet instance on the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
        /// </description></item>
        /// <item><description><para><b>dds_intl</b>: pay-as-you-go ReplicaSet instance on the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>badds</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b> or <b>null</b> (default): A coupon is used.</para>
        /// </description></item>
        /// <item><description><para><b>youhuiquan_promotion_option_id_for_blank</b>: A coupon is not used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>A JSON string that contains information about the instance. For more information about the parameters and JSON examples, see <a href="https://help.aliyun.com/document_detail/197291.html">DBInstances parameter of the DescribePrice operation</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;DBInstanceId&quot;:&quot;dds-bp1b6e54e7cc****&quot;, &quot;RegionId&quot;:&quot;cn-hangzhou&quot;, &quot;ZoneId&quot;:&quot;cn-hangzhou-h&quot;, &quot;Engine&quot;:&quot;MongoDB&quot;, &quot;EngineVersion&quot;:&quot; 5.0&quot;, &quot;DBInstanceClass&quot;:&quot;mdb.shard.2x.xlarge.d&quot;, &quot;DBInstanceStorage&quot;:30, &quot;ChargeType&quot;:&quot;PrePaid&quot;, &quot;Period&quot;:1, &quot;StorageType&quot;:&quot;cloud_essd1&quot; } ]</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public string DBInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the order parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): The order parameters are not returned.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The order parameters are returned.</para>
        /// </description></item>
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
        /// <item><description><para><b>BUY</b>: Creates an instance.</para>
        /// </description></item>
        /// <item><description><para><b>UPGRADE</b>: Changes the configuration of an instance.</para>
        /// </description></item>
        /// <item><description><para><b>RENEW</b>: Renews an instance.</para>
        /// </description></item>
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
        /// <para>The product code. The default value is <b>dds</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region ID. Call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
