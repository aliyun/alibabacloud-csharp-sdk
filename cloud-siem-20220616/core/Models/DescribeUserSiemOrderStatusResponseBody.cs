// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeUserSiemOrderStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserSiemOrderStatusResponseBodyData Data { get; set; }
        public class DescribeUserSiemOrderStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Agentic SOC Credits instance ID. If SiemOrderFrom is CREDITS_PRE_PAY, this field returns the Credits subscription instance ID for prepaid orders. If SiemOrderFrom is CREDITS_POST_PAY, this field returns the Credits pay-as-you-go instance ID. This field is empty if no Credits instance is found. For legacy orders, the Security Center instance ID is returned by SasInstanceId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asoc-instance-xxxxx</para>
            /// </summary>
            [NameInMap("AsocInstanceId")]
            [Validation(Required=false)]
            public string AsocInstanceId { get; set; }

            /// <summary>
            /// <para>The end time of the Agentic SOC Credits prepaid subscription, expressed as a 13-digit Unix timestamp in milliseconds. This field is returned only when SiemOrderFrom is CREDITS_PRE_PAY. In other cases, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785542400456</para>
            /// </summary>
            [NameInMap("AsocSubscriptionInstanceEndTime")]
            [Validation(Required=false)]
            public long? AsocSubscriptionInstanceEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the Agentic SOC Credits prepaid subscription, expressed as a 13-digit Unix timestamp in milliseconds. This field is returned only when SiemOrderFrom is CREDITS_PRE_PAY. In other cases, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1754006400123</para>
            /// </summary>
            [NameInMap("AsocSubscriptionInstanceStartTime")]
            [Validation(Required=false)]
            public long? AsocSubscriptionInstanceStartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the current account can perform order operations for threat detection and response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The account can purchase, upgrade, or change specifications.</description></item>
            /// <item><description>false: The account cannot perform order operations for threat detection and response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanBuy")]
            [Validation(Required=false)]
            public bool? CanBuy { get; set; }

            /// <summary>
            /// <para>The SLS log storage capacity purchased for threat detection and response, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            /// <summary>
            /// <para>The source of the log storage capacity order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PRE_PAY_CAPACITY: a prepaid capacity order.</description></item>
            /// <item><description>POST_PAY_CAPACITY: a pay-as-you-go capacity order.</description></item>
            /// </list>
            /// <para>The capacity order source is independent of the traffic order source indicated by SiemOrderFrom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRE_PAY_CAPACITY</para>
            /// </summary>
            [NameInMap("CapacityOrderFrom")]
            [Validation(Required=false)]
            public string CapacityOrderFrom { get; set; }

            /// <summary>
            /// <para>The SLS log storage capacity purchased for threat detection and response 1.0, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("DeliveryCapacity")]
            [Validation(Required=false)]
            public int? DeliveryCapacity { get; set; }

            /// <summary>
            /// <para>The number of days until the threat detection and response service expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DurationDays")]
            [Validation(Required=false)]
            public long? DurationDays { get; set; }

            /// <summary>
            /// <para>The expiration time of threat detection and response, expressed as a millisecond-level timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669823999000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The traffic capacity purchased for threat detection and response, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("FlowCapacity")]
            [Validation(Required=false)]
            public int? FlowCapacity { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that purchased threat detection and response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// <para>The master account ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("MasterUserId")]
            [Validation(Required=false)]
            public long? MasterUserId { get; set; }

            /// <summary>
            /// <para>The resource directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-xxxxxx</para>
            /// </summary>
            [NameInMap("RdId")]
            [Validation(Required=false)]
            public string RdId { get; set; }

            /// <summary>
            /// <para>Indicates whether the order is a SIEM public preview order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RdOrder")]
            [Validation(Required=false)]
            public int? RdOrder { get; set; }

            /// <summary>
            /// <para>The Security Center instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-instance-xxxxx</para>
            /// </summary>
            [NameInMap("SasInstanceId")]
            [Validation(Required=false)]
            public string SasInstanceId { get; set; }

            /// <summary>
            /// <para>The source of the traffic order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PRE_PAY_FLOW: a prepaid traffic order for threat detection and response.</description></item>
            /// <item><description>POST_PAY_FLOW: a pay-as-you-go traffic order for threat detection and response.</description></item>
            /// <item><description>CREDITS_PRE_PAY: an Agentic SOC Credits prepaid subscription.</description></item>
            /// <item><description>CREDITS_POST_PAY: an Agentic SOC Credits pay-as-you-go instance.</description></item>
            /// </list>
            /// <para>This field describes the traffic order source. The log storage capacity order source is independently indicated by CapacityOrderFrom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREDITS_PRE_PAY</para>
            /// </summary>
            [NameInMap("SiemOrderFrom")]
            [Validation(Required=false)]
            public string SiemOrderFrom { get; set; }

            /// <summary>
            /// <para>Indicates whether a valid SIEM order exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The SIEM order is valid.</description></item>
            /// <item><description>0: The SIEM order is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiemOrderStatus")]
            [Validation(Required=false)]
            public int? SiemOrderStatus { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the current logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// <para>The user type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
