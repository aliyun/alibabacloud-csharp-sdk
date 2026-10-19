// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The additional parameter for business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AccountPassword&quot;:&quot;Pw123456&quot;,&quot;DBInstanceDescription&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The commodity code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dds</b>: pay-as-you-go replica set instance</description></item>
        /// <item><description><b>badds</b>: subscription replica set instance</description></item>
        /// <item><description><b>dds_sharding</b>: pay-as-you-go sharded cluster instance</description></item>
        /// <item><description><b>badds_sharding</b>: subscription sharded cluster instance</description></item>
        /// <item><description><b>badds_sharding_intl</b>: subscription sharded cluster instance on the international site</description></item>
        /// <item><description><b>dds_sharding_intl</b>: pay-as-you-go sharded cluster instance on the international site</description></item>
        /// <item><description><b>badds_sharding_jp</b>: subscription sharded cluster instance on the Japan site</description></item>
        /// <item><description><b>badds_intl</b>: subscription replica set instance on the international site</description></item>
        /// <item><description><b>dds_intl</b>: pay-as-you-go replica set instance on the international site</description></item>
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
        /// <para>The JSON-formatted string that contains multiple pieces of information about instances. For metric descriptions and more JSON format examples, see <a href="https://help.aliyun.com/document_detail/197291.html">DBInstances metric description for the DescribePrice operation</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;DBInstanceId&quot;:&quot;dds-bp1b6e54e7cc****&quot;, &quot;RegionId&quot;:&quot;cn-hangzhou&quot;, &quot;ZoneId&quot;:&quot;cn-hangzhou-h&quot;, &quot;Engine&quot;:&quot;MongoDB&quot;, &quot;EngineVersion&quot;:&quot; 5.0&quot;, &quot;DBInstanceClass&quot;:&quot;mdb.shard.2x.xlarge.d&quot;, &quot;DBInstanceStorage&quot;:30, &quot;ChargeType&quot;:&quot;PrePaid&quot;, &quot;Period&quot;:1, &quot;StorageType&quot;:&quot;cloud_essd1&quot; } ]</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public string DBInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to return order parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Do not return order parameters.</description></item>
        /// <item><description><b>true</b>: Return order parameters.</description></item>
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
        /// <item><description><b>BUY</b>: Create an instance.</description></item>
        /// <item><description><b>UPGRADE</b>: Upgrade instance configurations.</description></item>
        /// <item><description><b>RENEW</b>: Renew an instance.</description></item>
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
        /// <para>The product code. Default value: <b>dds</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
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
