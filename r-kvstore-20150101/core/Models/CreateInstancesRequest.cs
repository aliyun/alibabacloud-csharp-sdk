// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. This is the default value.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. You must manually pay for the order. In the top navigation bar of the console, choose <b>Billing</b> &gt; <b>Renewal Management</b>. In the left-side navigation pane, choose <b>Order Management</b> &gt; <b>My Orders</b>, find the order, and then complete the payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when the <b>ChargeType</b> parameter in the <b>Instances</b> array is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when the <b>ChargeType</b> parameter in the <b>Instances</b> array is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The extended business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: <c>youhuiquan_promotion_option_id_for_blank</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The Redis-compatible engine version of the instance. Valid values: <b>4.0</b> and <b>5.0</b>.</para>
        /// <remarks>
        /// <para>Default value: <b>5.0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The configuration information of the new instances. The value must be in JSON format. For more information, see the supplementary description of the Instances parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,
        ///     &quot;izNo&quot;: &quot;cn-hangzhou-b&quot;,
        ///     &quot;quantity&quot;: 1,
        ///     &quot;instanceType&quot;: &quot;Redis&quot;,
        ///     &quot;instanceClass&quot;: &quot;redis.logic.sharding.1g.2db.0rodb.4proxy.default&quot;,
        ///     &quot;EngineVersion&quot;: &quot;5.0&quot;, 
        ///     &quot;ChargeType&quot;:&quot;PrePaid&quot;,
        ///     &quot;Period&quot;:&quot;1&quot;,
        ///     &quot;networkType&quot;: &quot;VPC&quot; ,
        ///     &quot;vpcId&quot;: &quot;vpc-2zex6u1nu32k3ux35oxxx&quot;, 
        ///     &quot;vSwitchId&quot;: &quot;vsw-2zesk464e647104kw3xxx&quot;
        /// }]</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to rebuild and restore the source instance from the recycle bin. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when the <b>SrcDBInstanceId</b> parameter is specified in the <b>Instances</b> array.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RebuildInstance")]
        [Validation(Required=false)]
        public bool? RebuildInstance { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-resourcegroupid1</para>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
