// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of attack source groups for the event.</para>
        /// </summary>
        [NameInMap("AttackSources")]
        [Validation(Required=false)]
        public List<DescribeAiEngineEventResponseBodyAttackSources> AttackSources { get; set; }
        public class DescribeAiEngineEventResponseBodyAttackSources : TeaModel {
            /// <summary>
            /// <para>The list of attack sources of this type.</para>
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public List<DescribeAiEngineEventResponseBodyAttackSourcesSources> Sources { get; set; }
            public class DescribeAiEngineEventResponseBodyAttackSourcesSources : TeaModel {
                /// <summary>
                /// <para>The display attribute of the attack source, such as the region code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN-510100</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The value of the attack source. If the attack source type is IP address (<b>Type</b> is <b>ip</b>), the value is an IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>203.0.113.109</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the attack source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: IP-based attack source.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The statistical value of suspected bypass evidence requests for the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BypassRequestCount")]
        [Validation(Required=false)]
        public long? BypassRequestCount { get; set; }

        /// <summary>
        /// <para>The list of domain names involved in the event.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EVT-0bda6****6b5cwwz</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The name of the event in the specified language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Suspected injection attack</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The number of nodes included in the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EventNodeCount")]
        [Validation(Required=false)]
        public int? EventNodeCount { get; set; }

        /// <summary>
        /// <para>The summary of the event in the specified language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Requests suspected of injection attacks were detected.</para>
        /// </summary>
        [NameInMap("EventSummary")]
        [Validation(Required=false)]
        public string EventSummary { get; set; }

        /// <summary>
        /// <para>The statistical value of evidence requests for the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("EvidenceRequestCount")]
        [Validation(Required=false)]
        public long? EvidenceRequestCount { get; set; }

        /// <summary>
        /// <para>The time when the event was first detected. The time is a UNIX timestamp in UTC. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1792973400000</para>
        /// </summary>
        [NameInMap("FirstSeenAt")]
        [Validation(Required=false)]
        public long? FirstSeenAt { get; set; }

        /// <summary>
        /// <para>The current manual handling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>unhandled</b>: Unhandled.</para>
        /// </description></item>
        /// <item><description><para><b>handling</b>: Handling.</para>
        /// </description></item>
        /// <item><description><para><b>handled</b>: Handled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>unhandled</para>
        /// </summary>
        [NameInMap("HandleStatus")]
        [Validation(Required=false)]
        public string HandleStatus { get; set; }

        /// <summary>
        /// <para>The time when the event was last detected. The time is a UNIX timestamp in UTC. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1792973700000</para>
        /// </summary>
        [NameInMap("LastSeenAt")]
        [Validation(Required=false)]
        public long? LastSeenAt { get; set; }

        /// <summary>
        /// <para>The IDs of the related events. Multiple IDs are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>EVT-0bda6<b><b>6b5c174,EVT-0bda6</b></b>6b5c175</para>
        /// </summary>
        [NameInMap("RelatedEventIds")]
        [Validation(Required=false)]
        public string RelatedEventIds { get; set; }

        /// <summary>
        /// <para>The event analysis report in the specified language, in Markdown format.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Event analysis report</h1>
        /// <para>Requests suspected of injection attacks were detected.</para>
        /// </summary>
        [NameInMap("ReportMarkdown")]
        [Validation(Required=false)]
        public string ReportMarkdown { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-demo</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of IDs of the protected objects involved in the event.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// <para>The current risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>critical</b>: Urgent.</para>
        /// </description></item>
        /// <item><description><para><b>high</b>: High-risk.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: Medium-risk.</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: Low-risk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

    }

}
