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
            /// <para>The ID of the Agentic SOC Credits instance. If SiemOrderFrom is CREDITS_PRE_PAY, the ID of the Credits subscription instance is returned. If SiemOrderFrom is CREDITS_POST_PAY, the ID of the Credits pay-as-you-go instance is returned. If no Credits instance is found, this field is empty. The Security Center instance ID for legacy orders is returned by SasInstanceId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asoc-instance-xxxxx</para>
            /// </summary>
            [NameInMap("AsocInstanceId")]
            [Validation(Required=false)]
            public string AsocInstanceId { get; set; }

            /// <summary>
            /// <para>The end time of the Agentic SOC Credits subscription. The value is a UNIX timestamp in milliseconds (13 digits). This field is returned only when SiemOrderFrom is CREDITS_PRE_PAY. Otherwise, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785542400456</para>
            /// </summary>
            [NameInMap("AsocSubscriptionInstanceEndTime")]
            [Validation(Required=false)]
            public long? AsocSubscriptionInstanceEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the Agentic SOC Credits subscription. The value is a UNIX timestamp in milliseconds (13 digits). This field is returned only when SiemOrderFrom is CREDITS_PRE_PAY. Otherwise, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1754006400123</para>
            /// </summary>
            [NameInMap("AsocSubscriptionInstanceStartTime")]
            [Validation(Required=false)]
            public long? AsocSubscriptionInstanceStartTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the current account can perform operations on threat analysis orders. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The account can purchase, upgrade, or change the configuration of threat analysis.</description></item>
            /// <item><description>false: The account cannot perform operations on threat analysis orders.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanBuy")]
            [Validation(Required=false)]
            public bool? CanBuy { get; set; }

            /// <summary>
            /// <para>The purchased Simple Log Service (SLS) capacity for threat analysis. Unit: GB.</para>
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
            /// <item><description>PRE_PAY_CAPACITY: Prepaid capacity order.</description></item>
            /// <item><description>POST_PAY_CAPACITY: Pay-as-you-go capacity order.</description></item>
            /// </list>
            /// <para>The source of the capacity order is independent of the traffic order source represented by SiemOrderFrom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRE_PAY_CAPACITY</para>
            /// </summary>
            [NameInMap("CapacityOrderFrom")]
            [Validation(Required=false)]
            public string CapacityOrderFrom { get; set; }

            /// <summary>
            /// <para>The information about the Credits pay-as-you-go instance. This field is returned when a Credits pay-as-you-go instance is found, and can be returned simultaneously with a valid legacy traffic order.</para>
            /// </summary>
            [NameInMap("CreditsPostpaidInfo")]
            [Validation(Required=false)]
            public DescribeUserSiemOrderStatusResponseBodyDataCreditsPostpaidInfo CreditsPostpaidInfo { get; set; }
            public class DescribeUserSiemOrderStatusResponseBodyDataCreditsPostpaidInfo : TeaModel {
                /// <summary>
                /// <para>The billing status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Normal.</description></item>
                /// <item><description>2: Suspended due to overdue payment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("BillingStatus")]
                [Validation(Required=false)]
                public int? BillingStatus { get; set; }

                /// <summary>
                /// <para>The source of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>POSTPAID: Independent pay-as-you-go instance.</description></item>
                /// <item><description>SUBSCRIPTION_DEFAULT_PAYG: Default pay-as-you-go instance for subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAID</para>
                /// </summary>
                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                /// <summary>
                /// <para>The user switch status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Enabled.</description></item>
                /// <item><description>0: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserSwitchStatus")]
                [Validation(Required=false)]
                public int? UserSwitchStatus { get; set; }

            }

            /// <summary>
            /// <para>The purchased SLS capacity for Threat Analysis 1.0. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("DeliveryCapacity")]
            [Validation(Required=false)]
            public int? DeliveryCapacity { get; set; }

            /// <summary>
            /// <para>The number of days until the threat analysis service expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DurationDays")]
            [Validation(Required=false)]
            public long? DurationDays { get; set; }

            /// <summary>
            /// <para>The expiration time of threat analysis. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669823999000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The purchased traffic for threat analysis. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("FlowCapacity")]
            [Validation(Required=false)]
            public int? FlowCapacity { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that purchased threat analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// <para>The ID of the master account in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("MasterUserId")]
            [Validation(Required=false)]
            public long? MasterUserId { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-xxxxxx</para>
            /// </summary>
            [NameInMap("RdId")]
            [Validation(Required=false)]
            public string RdId { get; set; }

            /// <summary>
            /// <para>Specifies whether the order is a SIEM public preview order.</para>
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
            /// <item><description>PRE_PAY_FLOW: Prepaid traffic order for threat analysis.</description></item>
            /// <item><description>POST_PAY_FLOW: Pay-as-you-go traffic order for threat analysis.</description></item>
            /// <item><description>CREDITS_PRE_PAY: Agentic SOC Credits subscription.</description></item>
            /// <item><description>CREDITS_POST_PAY: Agentic SOC Credits pay-as-you-go instance.</description></item>
            /// </list>
            /// <para>This field describes the source of the traffic order. The source of the log storage capacity order is independently represented by CapacityOrderFrom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREDITS_PRE_PAY</para>
            /// </summary>
            [NameInMap("SiemOrderFrom")]
            [Validation(Required=false)]
            public string SiemOrderFrom { get; set; }

            /// <summary>
            /// <para>Specifies whether there is a valid SIEM order. Valid values:</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
