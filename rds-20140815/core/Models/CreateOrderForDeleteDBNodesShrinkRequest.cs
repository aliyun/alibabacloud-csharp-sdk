// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateOrderForDeleteDBNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete the payment. Valid values:</para>
        /// <ol>
        /// <item><description><b>true</b>: You must make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: An unpaid order is generated.</description></item>
        /// </ol>
        /// <remarks>
        /// <para> Default value: true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The additional business information about the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;shopCartItemId\&quot;:\&quot;25******\&quot;,\&quot;produceDriver\&quot;:\&quot;NoOrder\&quot;,\&quot;aliyun_shopcart_order_source\&quot;:\&quot;fromShopcart\&quot;,\&quot;shopCartId\&quot;:\&quot;10190203suffix20230509******\&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bards</b>: The instance is a pay-as-you-go primary instance.</description></item>
        /// <item><description><b>rds</b>: The instance is a subscription primary instance.</description></item>
        /// <item><description><b>rords</b>: The instance is a pay-as-you-go read-only instance.</description></item>
        /// <item><description><b>rds_rordspre_public_cn</b>: The instance is a subscription read-only instance.</description></item>
        /// <item><description><b>bards_intl</b>: The instance is a pay-as-you-go primary instance.</description></item>
        /// <item><description><b>rds_intl</b>: The instance is a subscription primary instance.</description></item>
        /// <item><description><b>rords_intl</b>: The instance is a pay-as-you-go read-only instance.</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: The instance is a subscription read-only instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bards</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> operation to query the ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-8vb******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>An array that consists of information about the ID of the node.</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeIdShrink { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance. Valid values:</para>
        /// <para>Valid values if you set Engine to MySQL: <b>5.5, 5.6, 5.7, and 8.0</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The type of the database node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Master</b>: the primary node</description></item>
        /// <item><description><b>Slave</b>: the secondary node</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Master</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliwood-1688-mobile-promotion</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>buy</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
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

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
