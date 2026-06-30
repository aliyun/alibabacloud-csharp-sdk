// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTrafficMarkingPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no next query is to be sent.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, the value is the token that is used for the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>699989E4-64A0-5F78-8B93-CDB32D98971F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of traffic marking policies.</para>
        /// </summary>
        [NameInMap("TrafficMarkingPolicies")]
        [Validation(Required=false)]
        public List<ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPolicies> TrafficMarkingPolicies { get; set; }
        public class ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPolicies : TeaModel {
            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value of the traffic marking policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MarkingDscp")]
            [Validation(Required=false)]
            public int? MarkingDscp { get; set; }

            /// <summary>
            /// <para>The priority of the traffic marking policy.</para>
            /// <para>A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The description of the traffic marking policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("TrafficMarkingPolicyDescription")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyDescription { get; set; }

            /// <summary>
            /// <para>The ID of the traffic marking policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tm-iz5egnyitxiroq****</para>
            /// </summary>
            [NameInMap("TrafficMarkingPolicyId")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the traffic marking policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("TrafficMarkingPolicyName")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyName { get; set; }

            /// <summary>
            /// <para>The status of the traffic marking policy.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The policy is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Active</b>: The policy is available.</para>
            /// </description></item>
            /// <item><description><para><b>Modifying</b>: The policy is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The policy is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("TrafficMarkingPolicyStatus")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyStatus { get; set; }

            /// <summary>
            /// <para>The list of traffic classification rules.</para>
            /// </summary>
            [NameInMap("TrafficMatchRules")]
            [Validation(Required=false)]
            public List<ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPoliciesTrafficMatchRules> TrafficMatchRules { get; set; }
            public class ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPoliciesTrafficMatchRules : TeaModel {
                /// <summary>
                /// <para>The address type. Valid values are IPv4, IPv6, or empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("AddressFamily")]
                [Validation(Required=false)]
                public string AddressFamily { get; set; }

                /// <summary>
                /// <para>The destination CIDR block of the traffic message. IPv4 and IPv6 addresses are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.120.0/24</para>
                /// </summary>
                [NameInMap("DstCidr")]
                [Validation(Required=false)]
                public string DstCidr { get; set; }

                /// <summary>
                /// <para>The destination port range to be matched by the traffic classification rule.</para>
                /// </summary>
                [NameInMap("DstPortRange")]
                [Validation(Required=false)]
                public List<int?> DstPortRange { get; set; }

                /// <summary>
                /// <para>The DSCP value of the traffic message.</para>
                /// <remarks>
                /// <para>If <b>MatchDscp</b> returns -1, it indicates that all DSCP values are matched.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("MatchDscp")]
                [Validation(Required=false)]
                public int? MatchDscp { get; set; }

                /// <summary>
                /// <para>The protocol type of the traffic message.</para>
                /// <remarks>
                /// <para>A traffic marking policy supports matching multiple protocol types. For more information about the protocol types, see the relevant documentation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The source CIDR block of the traffic message. IPv6 and IPv4 addresses are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.10.0/24</para>
                /// </summary>
                [NameInMap("SrcCidr")]
                [Validation(Required=false)]
                public string SrcCidr { get; set; }

                /// <summary>
                /// <para>The source port range to be matched by the traffic classification rule.</para>
                /// </summary>
                [NameInMap("SrcPortRange")]
                [Validation(Required=false)]
                public List<int?> SrcPortRange { get; set; }

                /// <summary>
                /// <para>The description of the traffic classification rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desctest</para>
                /// </summary>
                [NameInMap("TrafficMatchRuleDescription")]
                [Validation(Required=false)]
                public string TrafficMatchRuleDescription { get; set; }

                /// <summary>
                /// <para>The ID of the traffic classification rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tm-rule-fa9kgq1e90rmhc****</para>
                /// </summary>
                [NameInMap("TrafficMatchRuleId")]
                [Validation(Required=false)]
                public string TrafficMatchRuleId { get; set; }

                /// <summary>
                /// <para>The name of the traffic classification rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nametest</para>
                /// </summary>
                [NameInMap("TrafficMatchRuleName")]
                [Validation(Required=false)]
                public string TrafficMatchRuleName { get; set; }

                /// <summary>
                /// <para>The status of the traffic classification rule.</para>
                /// <list type="bullet">
                /// <item><description><para><b>Creating</b>: The rule is being created.</para>
                /// </description></item>
                /// <item><description><para><b>Active</b>: The rule is available.</para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b>: The rule is being deleted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Creating</para>
                /// </summary>
                [NameInMap("TrafficMatchRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMatchRuleStatus { get; set; }

            }

            /// <summary>
            /// <para>The ID of the TransitRouter instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-ccni***</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
