// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:
        /// \* <b>true</b>: Enables automatic payment. This is the default value.
        /// \* <b>false</b>: Disables automatic payment. You must go to the console to complete the payment. In the top navigation bar, choose <b>Expenses</b> &gt; <b>Renewal Management</b>. In the navigation pane on the left, click <b>Or*er Management</b> &gt; <b>My Or*ers</b>, find the or*er, and then complete the payment.
        /// \&gt; This parameter is valid only when <b>ChargeType</b> is set to <b>PrePaid</b> in <b>Instances</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:
        /// \* <b>true</b>: Enables auto-renewal.
        /// \* <b>false</b>: Disables auto-renewal. This is the default value.
        /// \&gt; This parameter is valid only when <b>ChargeType</b> is set to <b>PrePaid</b> in <b>Instances</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Additional business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The coupon code. The default value is <c>youhuiquan_promotion_option_id_for_blank</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The Redis-compatible engine version for the instance. Valid values: <b>4.0</b> and <b>5.0</b>. The default value is <b>5.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The configurations of the new instances, specified in JSON format. For more information, see the details of the Instances parameter.</para>
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
        /// <para>Specifies whether to rebuild an instance from the recycle bin. Valid values:
        /// \* <b>true</b>: Rebuilds the instance.
        /// \* <b>false</b>: Does not rebuild the instance. This is the default value.
        /// \&gt; This parameter is valid only when <b>SrcDBInstanceId</b> is specified in <b>Instances</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RebuildInstance")]
        [Validation(Required=false)]
        public bool? RebuildInstance { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
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
        /// <para>A client-generated token to ensure request idempotence. The value must be unique across requests, case-sensitive, and up to 64 ASCII characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
