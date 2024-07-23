// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PreCheckCreateOrderForDeleteDBNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete the payment. Valid values:</para>
        /// <ol>
        /// <item><description><b>true</b>: automatically completes the payment. You must make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: does not automatically complete the payment. An unpaid order is generated.</description></item>
        /// </ol>
        /// <remarks>
        /// <para> The default value is true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The additional business information about the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;promotion_input_param\&quot;:\&quot;{\\\&quot;promotionFilter\\\&quot;:{},\\\&quot;promotionOptionCode\\\&quot;:\\\&quot;youhui_quan\\\&quot;}\&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity code. Valid value:</para>
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
        /// <para>rds</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-wz9rziy3he051if82</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The node IDs.</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public List<string> DBNodeId { get; set; }

        /// <summary>
        /// <para>The major engine version of the destination instance. The value of this parameter varies based on the value of <b>Engine</b>.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when Engine is set to MySQL: <b>5.5, 5.6, 5.7, and 8.0</b></description></item>
        /// <item><description>Valid values when Engine is set to SQLServer: <b>2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, and 2019_ent</b></description></item>
        /// <item><description>Valid values when Engine is set to PostgreSQL: <b>10.0, 11.0, 12.0, 13.0, 14.0, and 15.0</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The type of the database node. Valid value:</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>buy</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

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
