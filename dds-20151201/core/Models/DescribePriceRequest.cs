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
        /// <para>The code of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dds</b>: a replica set instance that uses the pay-as-you-go billing method</description></item>
        /// <item><description><b>badds</b>: a replica set instance that uses the subscription billing method</description></item>
        /// <item><description><b>dds_sharding</b>: a sharded cluster instance that uses the pay-as-you-go billing method</description></item>
        /// <item><description><b>badds_sharding</b>: a sharded cluster instance that uses the subscription billing method</description></item>
        /// <item><description><b>badds_sharding_intl</b>: a sharded cluster instance that uses the subscription billing method and is available on the International site (alibabacloud.com)</description></item>
        /// <item><description><b>dds_sharding_intl</b>: a sharded cluster instance that uses the pay-as-you-go billing method and is available on the International site (alibabacloud.com)</description></item>
        /// <item><description><b>badds_sharding_jp</b>: a sharded cluster instance that uses the subscription billing method and is available on the Japan site (jp.alibabacloud.com)</description></item>
        /// <item><description><b>badds_intl</b>: a replica set instance that uses the subscription billing method and is available on the International site (alibabacloud.com)</description></item>
        /// <item><description><b>dds_intl</b>: a replica set instance that uses the pay-as-you-go billing method and is available on the International site (alibabacloud.com)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>badds</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Default value: null. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> or <b>null</b>: uses coupons.</description></item>
        /// <item><description><b>youhuiquan_promotion_option_id_for_blank</b>: does not use coupons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>A JSON string that contains the details of the instance. For more information about the parameter and sample JSON formats, see <a href="https://help.aliyun.com/document_detail/197291.html">DescribePrice</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;DBInstanceId&quot;:&quot;dds-bp1b6e54e7cc****&quot;, &quot;RegionId&quot;:&quot;cn-hangzhou&quot;, &quot;ZoneId&quot;:&quot;cn-hangzhou-h&quot;, &quot;Engine&quot;:&quot;MongoDB&quot;, &quot;EngineVersion&quot;:&quot; 5.0&quot;, &quot;DBInstanceClass&quot;:&quot;mdb.shard.2x.xlarge.d&quot;, &quot;DBInstanceStorage&quot;:30, &quot;ChargeType&quot;:&quot;PrePaid&quot;, &quot;Period&quot;:1, &quot;StorageType&quot;:&quot;cloud_essd1&quot; } ]</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public string DBInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the OrderParams parameter. Valid values:</para>
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
        /// <item><description><b>BUY</b></description></item>
        /// <item><description><b>UPGRADE</b></description></item>
        /// <item><description><b>RENEW</b></description></item>
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
        /// <para>The code of the service. Default value: <b>dds</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
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
