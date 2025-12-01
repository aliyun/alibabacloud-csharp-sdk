// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostsChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete the payment. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>true: The payment is automatically completed. Ensure that your account balance is sufficient. Otherwise, your order becomes invalid and must be canceled.</description></item>
        /// <item><description>false: An order is generated but no payment is made.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <remarks>
        /// <para> If you do not have sufficient balance in your account, you can set <c>AutoPay</c> to <c>false</c> to generate an unpaid order. Then, you can pay for the order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <c>token</c> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The new billing method for the dedicated host. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: changes the billing method from pay-as-you-go to subscription.</description></item>
        /// <item><description>PostPaid: changes the billing method from subscription to pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("DedicatedHostChargeType")]
        [Validation(Required=false)]
        public string DedicatedHostChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of the dedicated hosts. The value can be a JSON array that consists of up to 20 dedicated host IDs. Separate the IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;dh-bp181e5064b5sotr****&quot;,&quot;dh-bp18064b5sotrr9c****&quot;]</para>
        /// </summary>
        [NameInMap("DedicatedHostIds")]
        [Validation(Required=false)]
        public string DedicatedHostIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the billing details of the order when the billing method is changed from subscription to pay-as-you-go.</para>
        /// <para>Indicates whether the nfs volume is set to the read-only mode. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DetailFee")]
        [Validation(Required=false)]
        public bool? DetailFee { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including invalid AccessKey pairs, unauthorized Resource Access Management (RAM) users, and missing parameter values. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// <para>Indicates whether the nfs volume is set to the read-only mode. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The renewal duration of the subscription dedicated hosts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>PeriodUnit</c> to Week, valid values of <c>Period</c> are 1, 2, 3, and 4.</description></item>
        /// <item><description>If you set <c>PeriodUnit</c> to Month, valid values of <c>Period</c> are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration specified by <c>Period</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Week</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the dedicated hosts. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
