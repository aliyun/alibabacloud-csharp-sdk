// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment.</description></item>
        /// <item><description><b>false</b>: disables automatic payment.</description></item>
        /// </list>
        /// <para>If you select false, you must choose <b>Expenses</b> &gt; <b>Renewal Management</b> in the top navigation bar. In the left-side navigation pane, click <b>Orders</b>. Find the specified order and pay for it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal. The instance is renewed based on the specified renewal duration. For example, if you set the renewal duration to three months, you are charged for three months of service each time the instance is automatically renewed.</description></item>
        /// <item><description><b>false</b> (default): disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the promotional event or business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Unit: MB. When you renew the instance, you can specify this parameter to change specifications of the instance.</para>
        /// <remarks>
        /// <para>To change the specifications when you renew the instance, you must specify at least one of the <c>Capacity</c> and <c>InstanceClass</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public string Capacity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token is case-sensitive. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TF-ModifyInstanceSpec-1686645570-7dac7257-4a14-4811-939c-51a282f</para>
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
        /// <para>The source of the request. The default value is <b>OpenAPI</b> and cannot be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The instance type code. For more information, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance specifications overview</a>. When you renew the instance, you can specify this parameter to change specifications of the instance.</para>
        /// <remarks>
        /// <para>To change the specifications when you renew the instance, you must specify at least one of the <c>Capacity</c> and <c>InstanceClass</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
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
        /// <para>The renewal period. Valid values: <b>1</b>, 2, 3, 4, 5, 6, 7, 8, <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>. Unit: months.</para>
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
