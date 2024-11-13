// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class QuerySchedruleOnDemandResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the on-demand instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-z2q1qzxb****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A8F9980-5ACB-497F-9F15-48E9D6B29028</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the scheduling rule.</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public List<QuerySchedruleOnDemandResponseBodyRuleConfig> RuleConfig { get; set; }
        public class QuerySchedruleOnDemandResponseBodyRuleConfig : TeaModel {
            /// <summary>
            /// <para>The scheduling action. The value is set to <b>declare</b>, which indicates that the route is advertised.</para>
            /// 
            /// <b>Example:</b>
            /// <para>declare</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            /// <summary>
            /// <para>If the inbound bandwidth or packets consecutively exceed the threshold for the specified number of times, the scheduling rule is triggered and traffic is rerouted to the on-demand instance. The specified number of times is the value of this parameter.</para>
            /// <remarks>
            /// <para> The threshold of inbound bandwidth is the value of <b>RuleConditionMbps</b>. The threshold of inbound packets is the value of <b>RuleConditionKpps</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RuleConditionCnt")]
            [Validation(Required=false)]
            public string RuleConditionCnt { get; set; }

            /// <summary>
            /// <para>The threshold of inbound packets. Unit: kilo packets per second (Kpps). Minimum value: <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RuleConditionKpps")]
            [Validation(Required=false)]
            public string RuleConditionKpps { get; set; }

            /// <summary>
            /// <para>The threshold of inbound bandwidth. Unit: Mbit/s. Minimum value: <b>100</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RuleConditionMbps")]
            [Validation(Required=false)]
            public string RuleConditionMbps { get; set; }

            /// <summary>
            /// <para>The name of the scheduling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-z2q1qzxb****</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Indicates whether the scheduling rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled.</description></item>
            /// <item><description><b>off</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public string RuleSwitch { get; set; }

            /// <summary>
            /// <para>The start time of the period during which the scheduling rule is automatically stopped. The time must be in the 24-hour clock and in the <c>hh:mm</c> format.</para>
            /// <para>If the system detects that DDoS attacks stop, the system no longer reroutes traffic to the on-demand instance from the time you specified. We recommend that you set this parameter to a value that is defined as off-peak hours.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when the value of <b>RuleUndoMode</b> is <b>auto</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>03:00</para>
            /// </summary>
            [NameInMap("RuleUndoBeginTime")]
            [Validation(Required=false)]
            public string RuleUndoBeginTime { get; set; }

            /// <summary>
            /// <para>The end time of the period during which the scheduling rule is automatically stopped. The time must be in the 24-hour clock and in the <c>hh:mm</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03:05</para>
            /// </summary>
            [NameInMap("RuleUndoEndTime")]
            [Validation(Required=false)]
            public string RuleUndoEndTime { get; set; }

            /// <summary>
            /// <para>The stop method of the scheduling rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>auto</b></description></item>
            /// <item><description><b>manual</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("RuleUndoMode")]
            [Validation(Required=false)]
            public string RuleUndoMode { get; set; }

            /// <summary>
            /// <para>The time zone of the time when the scheduling rule automatically stops. The time zone must be in the <c>GMT-hh:mm</c> format.</para>
            /// <para>For example, the value <c>GMT-08:00</c> indicates that the time zone is UTC+8.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when the value of <b>RuleUndoMode</b> is <b>auto</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>GMT-08:00</para>
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <para>The status of the scheduling rule.</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public List<QuerySchedruleOnDemandResponseBodyRuleStatus> RuleStatus { get; set; }
        public class QuerySchedruleOnDemandResponseBodyRuleStatus : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the on-demand instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.<em><b>.</b></em>.0/24</para>
            /// </summary>
            [NameInMap("Net")]
            [Validation(Required=false)]
            public string Net { get; set; }

            /// <summary>
            /// <para>The scheduling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>scheduled</b></description></item>
            /// <item><description><b>unscheduled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unscheduled</para>
            /// </summary>
            [NameInMap("RuleSchedStatus")]
            [Validation(Required=false)]
            public string RuleSchedStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>171986973287****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
