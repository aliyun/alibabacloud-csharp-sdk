// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceNetworkSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to assign a public IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
        /// <para>Specifies whether to automatically complete the payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: After you modify the bandwidth configurations, the payment is automatically completed. Make sure that your account balance is sufficient before you set AutoPay to true. If your account balance is insufficient, your order cannot be paid in the ECS console and becomes invalid. You must cancel the order.</description></item>
        /// <item><description>false: After you modify the bandwidth configurations, an order is generated but the payment is not automatically completed. If your account balance is insufficient, you can set AutoPay to false to generate an unpaid order. Then, you can log on to the <a href="https://ecs.console.aliyun.com">ECS console</a> to pay for the order.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. <b>The token can contain only ASCII characters and cannot exceed 64 characters in length.</b> For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end time of the temporary bandwidth upgrade. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddThhZ format. The time must be in UTC and accurate to <b>hours</b> (hh).</para>
        /// <remarks>
        /// <para> The interval between the end time and start time of temporary bandwidth upgrade must be greater than or equal to 3 hours.</para>
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
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which you want to modify network configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum inbound bandwidth from the Internet. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of this parameter are 1 to 10 and the default value is 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the <c>InternetMaxBandwidthOut</c> value and the default value is the <c>InternetMaxBandwidthOut</c> value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values when the pay-by-traffic billing method for network usage is used: 0 to 100.</para>
        /// </description></item>
        /// <item><description><para>Valid values when the pay-by-bandwidth billing method for network usage is used:</para>
        /// <list type="bullet">
        /// <item><description>Valid values for subscription instances: 0 to 200.</description></item>
        /// <item><description>Valid values for pay-as-you-go instances: 0 to 100.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> The maximum outbound bandwidth of a single instance is also limited by the <b>network baseline bandwidth (Gbit/s) and network burst bandwidth (Gbit/s)</b> of the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth</description></item>
        /// <item><description>PayByTraffic</description></item>
        /// </list>
        /// <remarks>
        /// <para>When the <b>pay-by-traffic</b> billing method for network usage is used, the maximum inbound and outbound bandwidth values are used as the upper limits of bandwidths instead of guaranteed values. In scenarios where demand outstrips resource supplies, these maximum bandwidths may be limited. If you want guaranteed bandwidths for your instance, use the <b>pay-by-bandwidth</b> billing method for network usage.</para>
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
        /// <para>The start time of the temporary bandwidth upgrade. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddThh:mmZ format. The time must be in UTC and accurate to <b>minutes (mm)</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-05T22:40Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
