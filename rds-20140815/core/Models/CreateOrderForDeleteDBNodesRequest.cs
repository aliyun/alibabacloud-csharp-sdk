// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateOrderForDeleteDBNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete automatic payment. Valid values:</para>
        /// <ol>
        /// <item><description><para><b>true</b>: automatically completes automatic payment. Make sure that your account balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: generates the order without completing automatic payment.</para>
        /// </description></item>
        /// </ol>
        /// <remarks>
        /// <para>Default value: true. If your payment method has insufficient balance, set AutoPay to false. In this case, an unpaid order is generated. You can log on to the ApsaraDB RDS console to complete automatic payment.</para>
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
        /// <para>None</para>
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
        /// <item><description><b>bards</b>: pay-as-you-go primary instance</description></item>
        /// <item><description><b>rds</b>: subscription primary instance</description></item>
        /// <item><description><b>rords</b>: pay-as-you-go read-only instance</description></item>
        /// <item><description><b>rds_rordspre_public_cn</b>: subscription read-only instance</description></item>
        /// <item><description><b>bards_intl</b>: pay-as-you-go primary instance</description></item>
        /// <item><description><b>rds_intl</b>: subscription primary instance</description></item>
        /// <item><description><b>rords_intl</b>: pay-as-you-go read-only instance</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: subscription read-only instance</description></item>
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
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-8vb9******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of node IDs.</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public List<string> DBNodeId { get; set; }

        /// <summary>
        /// <para>The current database engine version. Valid values:</para>
        /// <para>MySQL: <b>5.5, 5.6, 5.7, 8.0</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The database node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Master</b>: primary node</description></item>
        /// <item><description><b>Slave</b>: secondary node</description></item>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource.</para>
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
