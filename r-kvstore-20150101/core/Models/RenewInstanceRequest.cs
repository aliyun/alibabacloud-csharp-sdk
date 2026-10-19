// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. This is the default value.</description></item>
        /// <item><description><b>false</b>: disables automatic payment.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;If you set this parameter to false, you must log on to the console, choose <b>Billing</b> &gt; <b>Renewal Management</b> in the top navigation bar, and then choose <b>Order Management</b> &gt; <b>My Orders</b> in the left-side navigation pane to find and pay for the order.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;If you set this parameter to false, you must log on to the console, choose <b>Billing</b> &gt; <b>Renewal Management</b> in the top navigation bar, and then click <b>Order Management</b> in the left-side navigation pane to find and pay for the order.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;If you set this parameter to false, you must log on to the console, choose <b>Billing</b> &gt; <b>Renewal Management</b> in the top navigation bar, and then click <b>Order Management</b> in the left-side navigation pane to find and pay for the order.</para>
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
        /// <item><description><b>true</b>: enables auto-renewal. The instance is renewed for the specified period. For example, if you set the renewal period to 3 months, the instance is automatically renewed for 3 months each time.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The activity ID and business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> You cannot change the storage capacity when you renew an instance. By default, the renewal order is placed based on the current specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public string Capacity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.6823317918435086</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>The source of the request. Default value: <b>OpenAPI</b>. You do not need to manually specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> You cannot change the instance type when you renew an instance. By default, the renewal order is placed based on the current specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The renewal period. Unit: months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
        /// <remarks>
        /// <para>For example, if an instance expires in 3 months and you renew it for 3 months, the instance will expire in 6 months after the renewal.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
