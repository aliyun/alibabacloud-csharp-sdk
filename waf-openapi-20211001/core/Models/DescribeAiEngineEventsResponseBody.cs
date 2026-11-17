// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAiEngineEventsResponseBodyItems> Items { get; set; }
        public class DescribeAiEngineEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of attack source groups for the event.</para>
            /// </summary>
            [NameInMap("AttackSources")]
            [Validation(Required=false)]
            public List<DescribeAiEngineEventsResponseBodyItemsAttackSources> AttackSources { get; set; }
            public class DescribeAiEngineEventsResponseBodyItemsAttackSources : TeaModel {
                /// <summary>
                /// <para>The list of attack sources of this type.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public List<DescribeAiEngineEventsResponseBodyItemsAttackSourcesSources> Sources { get; set; }
                public class DescribeAiEngineEventsResponseBodyItemsAttackSourcesSources : TeaModel {
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
                    /// <para>The value of the attack source. If the attack source type is IP address (<b>Type</b> is set to <b>ip</b>), the value is an IP address.</para>
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
                /// <item><description><b>ip</b>: IP address.</description></item>
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
            /// <para>The number of deduplicated evidence requests that are suspected to have bypassed protection in the event.</para>
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
            /// <para>The ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EVT-20261025-109</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The name of the event in the selected language.</para>
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
            /// <para>The number of deduplicated evidence requests for the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("EvidenceRequestCount")]
            [Validation(Required=false)]
            public long? EvidenceRequestCount { get; set; }

            /// <summary>
            /// <para>The time when the event was first detected. The value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
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
            /// <para>The time when the event was last detected. The value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792973700000</para>
            /// </summary>
            [NameInMap("LastSeenAt")]
            [Validation(Required=false)]
            public long? LastSeenAt { get; set; }

            /// <summary>
            /// <para>The IDs of related events. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>EVT-0bda6<b><b>6b5c174,EVT-0bda6</b></b>6b5c175</para>
            /// </summary>
            [NameInMap("RelatedEventIds")]
            [Validation(Required=false)]
            public string RelatedEventIds { get; set; }

            /// <summary>
            /// <para>The list of protected objects involved in the event.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

            /// <summary>
            /// <para>The current risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>critical</b>: Critical.</para>
            /// </description></item>
            /// <item><description><para><b>high</b>: High.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: Medium.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: Low.</para>
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

        /// <summary>
        /// <para>The number of entries to return per page in a paging query. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for querying the next page. If a next page exists, this field returns a value.</para>
        /// <remarks>
        /// <para>If this parameter returns a value, a next page exists. You can use the returned <b>NextToken</b> as a request parameter to obtain the data on the next page. Repeat this operation until no value is returned, which indicates that all data is obtained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>token-demo</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The total number of events that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
