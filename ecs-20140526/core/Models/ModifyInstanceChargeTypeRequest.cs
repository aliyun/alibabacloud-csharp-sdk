// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables automatic payment. Make sure that your account balance is sufficient. If your account balance is insufficient, abnormal orders are generated, and you can only cancel the orders.</para>
        /// </description></item>
        /// <item><description><para>false: generates orders without charging.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <remarks>
        /// <para>If your payment method has an insufficient balance, you can set AutoPay to false. In this case, unpaid orders are generated, and you can log on to the ECS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: sends a check request without querying resource status. The check items include whether your AccessKey pair is valid, whether the Resource Access Management (RAM) user is granted the required authorization, and whether the required parameters are specified. If the check fails, the corresponding error message is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para>false: sends a normal request. If the request passes the check, a 2XX HTTP status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert all pay-as-you-go data disks attached to the instance to subscription data disks.</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeDataDisks")]
        [Validation(Required=false)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// <para>The target billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PrePaid: converts pay-as-you-go instances to subscription instances.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: converts subscription instances to pay-as-you-go instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of instances. The value can be a JSON array that consists of up to 20 instance IDs. Separate the IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp67acfmxazb4p****&quot;,&quot;i-bp67acfmxazb4d****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to return order fee details when the billing method is converted from subscription to pay-as-you-go. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns the fee details.</description></item>
        /// <item><description>false: Does not return the fee details.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDetailFee")]
        [Validation(Required=false)]
        public bool? IsDetailFee { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription renewal period. If the ECS instance is hosted on a dedicated host, the value cannot exceed the subscription period of the dedicated host. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Week</c>, valid values of <c>Period</c>: 1, 2, 3, and 4.</description></item>
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values of <c>Period</c>: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;If <c>PeriodUnit</c> is set to <c>Month</c>, valid values of <c>Period</c>: 1, 2, 3, 4, 5, 6, 7, 8, 9, and 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal period, which is the unit of the <c>Period</c> parameter. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Week</description></item>
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;Month</para>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

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
