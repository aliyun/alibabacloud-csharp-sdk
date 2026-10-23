// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: enables automatic payment. This is the default value. You must ensure that your account balance is sufficient. If your account balance is insufficient, an abnormal order is generated and can only be canceled. </description></item>
        /// <item><description>false: generates an order without deducting fees. If your account balance is insufficient, a normal unpaid order is generated. You can log on to the Alibaba Cloud <b>Expenses and Costs</b> console and pay the order on the &lt;props=&quot;china&quot;&gt;<ph><a href="https://usercenter2.aliyun.com/order/list">My Orders</a></ph>&lt;props=&quot;intl&quot;&gt;<ph><a href="https://usercenter2-intl.aliyun.com/order/list">Orders</a></ph> page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud disk. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>PrePaid: changes the billing method of the data cloud disk from pay-as-you-go to subscription. This is the default value. </description></item>
        /// <item><description>PostPaid: changes the billing method of the data cloud disk from subscription to pay-as-you-go.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you change the billing method of a pay-as-you-go cloud disk to subscription, the billing cycle of the capacity fee is automatically synchronized with that of the associated ECS instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// <para>The list of cloud disk IDs. The value is a JSON array. You can specify up to 16 IDs. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d-bp67acfmxazb4ph****&quot;, &quot;d-bp67acfmxazb4pi****&quot;, … &quot;d-bp67acfmxazb4pj****&quot;]</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the cloud disk is attached.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1i778bq705cvx1****</para>
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
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
