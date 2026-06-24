// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceNetworkSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allocate a public IP address.</para>
        /// <list type="bullet">
        /// <item><description>true: allocates a public IP address.</description></item>
        /// <item><description>false: does not allocate a public IP address.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllocatePublicIp")]
        [Validation(Required=false)]
        public bool? AllocatePublicIp { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: After the bandwidth configuration is modified, the payment is automatically deducted. When you set the AutoPay parameter to true, make sure that your account has sufficient balance. If your account balance is insufficient, an abnormal order is generated. You cannot pay for the order on the ECS console. You can only cancel the order.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>false: After the bandwidth configuration is modified, only an order is generated and no payment is made. If your payment method has insufficient balance, you can set the AutoPay parameter to false to disable automatic payment. In this case, the API generates a normal unpaid order. You can log on to the <a href="https://ecs.console.aliyun.com">ECS console</a> to pay for the order.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>false: After the bandwidth configuration is modified, only an order is generated and no payment is made. If your payment method has insufficient balance, you can set the AutoPay parameter to false to disable automatic payment. In this case, the API generates a normal unpaid order. You can log on to the <a href="https://ecs.console.aliyun.com">ECS console</a> to pay for the order.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end time of the temporary bandwidth upgrade. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in UTC+0 time in the yyyy-MM-ddTHHZ format. The time must be accurate to the <b>hour</b> (HH).</para>
        /// <remarks>
        /// <para>The interval between the end time and the start time of the temporary bandwidth upgrade must be greater than or equal to 3 hours.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-06T22Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not yet available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which you want to modify the network configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s (Megabit per second). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased maximum outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
        /// <item><description>If the purchased maximum outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>InternetMaxBandwidthOut</c>. Default value: the value of <c>InternetMaxBandwidthOut</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s (Megabit per second). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pay-by-traffic: 0 to 100.</para>
        /// </description></item>
        /// <item><description><para>Pay-by-bandwidth:</para>
        /// <list type="bullet">
        /// <item><description>Subscription instance: 0 to 200.</description></item>
        /// <item><description>Pay-as-you-go instance: 0 to 100.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The maximum outbound bandwidth per instance is also limited by the <b>Network Bandwidth Baseline/Burstable (Gbit/s)</b> metric of the ECS instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The conversion target for the network billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
        /// </list>
        /// <remarks>
        /// <para>In <b>pay-by-traffic</b> mode, the inbound and outbound bandwidth peaks are both bandwidth upper limits and are not guaranteed as committed service metrics. When resource contention occurs, the bandwidth peaks may be throttled. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("NetworkChargeType")]
        [Validation(Required=false)]
        public string NetworkChargeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the temporary bandwidth upgrade. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in UTC+0 time in the yyyy-MM-ddTHH:mmZ format. The time must be accurate to the <b>minute</b> (mm).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-05T22:40Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
