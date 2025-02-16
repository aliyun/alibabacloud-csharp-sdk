// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The load balancers returned.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            [NameInMap("AdaptiveRouting")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAdaptiveRouting AdaptiveRouting { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAdaptiveRouting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FailoverAcrossPools")]
                [Validation(Required=false)]
                public bool? FailoverAcrossPools { get; set; }

            }

            [NameInMap("DefaultPools")]
            [Validation(Required=false)]
            public List<long?> DefaultPools { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>96228666776****</para>
            /// </summary>
            [NameInMap("FallbackPool")]
            [Validation(Required=false)]
            public long? FallbackPool { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>998676487607104</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Monitor")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersMonitor Monitor { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersMonitor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ConsecutiveDown")]
                [Validation(Required=false)]
                public int? ConsecutiveDown { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ConsecutiveUp")]
                [Validation(Required=false)]
                public int? ConsecutiveUp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200,202</para>
                /// </summary>
                [NameInMap("ExpectedCodes")]
                [Validation(Required=false)]
                public string ExpectedCodes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FollowRedirects")]
                [Validation(Required=false)]
                public bool? FollowRedirects { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///         &quot;host&quot;: [
                ///             &quot;example1.com&quot;,
                ///             &quot;example2.com&quot;
                ///         ]
                ///     }</para>
                /// </summary>
                [NameInMap("Header")]
                [Validation(Required=false)]
                public object Header { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb.example.com</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RandomSteering")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersRandomSteering RandomSteering { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersRandomSteering : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("DefaultWeight")]
                [Validation(Required=false)]
                public int? DefaultWeight { get; set; }

                [NameInMap("PoolWeights")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PoolWeights { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;ENAM&quot;: [
            ///     12345678****
            ///   ],
            ///   &quot;WNAM&quot;: [
            ///     23456789****,
            ///     23456789****
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("RegionPools")]
            [Validation(Required=false)]
            public object RegionPools { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersRules> Rules { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersRules : TeaModel {
                [NameInMap("FixedResponse")]
                [Validation(Required=false)]
                public ListLoadBalancersResponseBodyLoadBalancersRulesFixedResponse FixedResponse { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersRulesFixedResponse : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>application/json</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/index.html">http://www.example.com/index.html</a></para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Hello World.</para>
                    /// </summary>
                    [NameInMap("MessageBody")]
                    [Validation(Required=false)]
                    public string MessageBody { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("StatusCode")]
                    [Validation(Required=false)]
                    public int? StatusCode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///             &quot;adaptive_routing&quot;: {
                ///                 &quot;failover_across_pools&quot;: true
                ///             },
                ///             &quot;sub_region_pools&quot;: {
                ///                 &quot;GB&quot;: [
                ///                     96228666776****
                ///                 ],
                ///                 &quot;US&quot;: [
                ///                     96228666776****
                ///                 ]
                ///             },
                ///             &quot;default_pools&quot;: [
                ///                 96228666776****,
                ///                 96228666776****
                ///             ],
                ///             &quot;fallback_pool&quot;: 96228666776****,
                ///             &quot;location_strategy&quot;: {
                ///                 &quot;mode&quot;: &quot;resolver_ip&quot;,
                ///                 &quot;prefer_ecs&quot;: &quot;always&quot;
                ///             },
                ///             &quot;random_steering&quot;: {
                ///                 &quot;default_weight&quot;: 30,
                ///                 &quot;pool_weights&quot;: {
                ///                     &quot;96228666776****&quot;: 70,
                ///                     &quot;96228666776****&quot;: 80
                ///                 }
                ///             },
                ///             &quot;region_pools&quot;: {
                ///                 &quot;ENAM&quot;: [
                ///                     96228666776****,
                ///                     92843536908****
                ///                 ],
                ///                 &quot;WNAM&quot;: [
                ///                     92843536908****
                ///                 ]
                ///             },
                ///             &quot;session_affinity&quot;: &quot;cookie&quot;,
                ///             &quot;session_affinity_attributes&quot;: {
                ///                 &quot;drain_duration&quot;: 100,
                ///                 &quot;headers&quot;: [&quot;none&quot;],
                ///                 &quot;require_all_headers&quot;: false,
                ///                 &quot;samesite&quot;: &quot;Auto&quot;,
                ///                 &quot;secure&quot;: &quot;Auto&quot;,
                ///                 &quot;zero_downtime_failover&quot;: &quot;sticky&quot;
                ///             },
                ///             &quot;session_affinity_ttl&quot;: 1800,
                ///             &quot;steering_policy&quot;: &quot;dynamic_latency&quot;,
                ///             &quot;ttl&quot;: 30
                ///         }</para>
                /// </summary>
                [NameInMap("Overrides")]
                [Validation(Required=false)]
                public object Overrides { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http.request.uri.path contains &quot;/testing&quot;</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("RuleEnable")]
                [Validation(Required=false)]
                public string RuleEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>r2</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Terminates")]
                [Validation(Required=false)]
                public bool? Terminates { get; set; }

            }

            /// <summary>
            /// <para>The session persistence mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: disables session persistence.</description></item>
            /// <item><description>ip: enables session persistence by IP address.</description></item>
            /// <item><description>cookie: enables session persistence by cookie.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SessionAffinity")]
            [Validation(Required=false)]
            public string SessionAffinity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1159101787****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>order</para>
            /// </summary>
            [NameInMap("SteeringPolicy")]
            [Validation(Required=false)]
            public string SteeringPolicy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
            /// </summary>
            [NameInMap("SubRegionPools")]
            [Validation(Required=false)]
            public object SubRegionPools { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
