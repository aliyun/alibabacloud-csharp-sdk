// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of load balancing instances returned in array format.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The cross-origin address pool back-to-origin configuration.</para>
            /// </summary>
            [NameInMap("AdaptiveRouting")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAdaptiveRouting AdaptiveRouting { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAdaptiveRouting : TeaModel {
                /// <summary>
                /// <para>Indicates whether cross-origin address pool failover is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FailoverAcrossPools")]
                [Validation(Required=false)]
                public bool? FailoverAcrossPools { get; set; }

                /// <summary>
                /// <para>Specifies whether to retry the next IP address when back-to-origin fails and the origin server is a domain name that resolves to multiple IP addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OriginLevelRetry")]
                [Validation(Required=false)]
                public bool? OriginLevelRetry { get; set; }

            }

            /// <summary>
            /// <para>The list of default address pool IDs.</para>
            /// </summary>
            [NameInMap("DefaultPools")]
            [Validation(Required=false)]
            public List<long?> DefaultPools { get; set; }

            /// <summary>
            /// <para>The description of the load balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the load balancing instance is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the fallback address pool. When all other address pools are unavailable, traffic is redirected to this address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96228666776****</para>
            /// </summary>
            [NameInMap("FallbackPool")]
            [Validation(Required=false)]
            public long? FallbackPool { get; set; }

            /// <summary>
            /// <para>The unique identity ID of the load balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>998676487607104</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The monitor configuration.</para>
            /// </summary>
            [NameInMap("Monitor")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersMonitor Monitor { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersMonitor : TeaModel {
                /// <summary>
                /// <para>The number of consecutive failed probes required to consider the check failed, such as 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ConsecutiveDown")]
                [Validation(Required=false)]
                public int? ConsecutiveDown { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful probes required to consider the check successful, such as 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ConsecutiveUp")]
                [Validation(Required=false)]
                public int? ConsecutiveUp { get; set; }

                /// <summary>
                /// <para>The expected status codes for a successful HTTP response, such as 200,202.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200,202</para>
                /// </summary>
                [NameInMap("ExpectedCodes")]
                [Validation(Required=false)]
                public string ExpectedCodes { get; set; }

                /// <summary>
                /// <para>Indicates whether to follow redirects. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FollowRedirects")]
                [Validation(Required=false)]
                public bool? FollowRedirects { get; set; }

                /// <summary>
                /// <para>The HTTP header information included in the probe request.</para>
                /// 
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
                /// <para>The interval of the health check, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The method used for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The region where the probe nodes are located. Default value: Global. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Global: worldwide.</description></item>
                /// <item><description>ChineseMainland: the Chinese mainland.</description></item>
                /// <item><description>OutsideChineseMainland: worldwide (excluding the Chinese mainland).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
                /// </summary>
                [NameInMap("MonitoringRegion")]
                [Validation(Required=false)]
                public string MonitoringRegion { get; set; }

                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The target port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period of the health check, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The monitor protocol type, such as HTTP, used for health checks. A value of off indicates that no health check is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the load balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb.example.com</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The weighted round-robin configuration, which controls the traffic distribution weight across different address pools.</para>
            /// </summary>
            [NameInMap("RandomSteering")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersRandomSteering RandomSteering { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersRandomSteering : TeaModel {
                /// <summary>
                /// <para>The weight configuration for each backend server pool. The key is the pool ID and the value is the weight coefficient. The weight coefficient represents the relative proportion of traffic distribution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("DefaultWeight")]
                [Validation(Required=false)]
                public int? DefaultWeight { get; set; }

                /// <summary>
                /// <para>The weight configuration for each backend server pool. The key is the pool ID and the value is the weight coefficient.</para>
                /// </summary>
                [NameInMap("PoolWeights")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PoolWeights { get; set; }

            }

            /// <summary>
            /// <para>The address pools mapped to primary regions.</para>
            /// 
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

            /// <summary>
            /// <para>The list of rule configurations that define behaviors under specific conditions.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersRules> Rules { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersRules : TeaModel {
                /// <summary>
                /// <para>The fixed response content returned after a rule is matched.</para>
                /// </summary>
                [NameInMap("FixedResponse")]
                [Validation(Required=false)]
                public ListLoadBalancersResponseBodyLoadBalancersRulesFixedResponse FixedResponse { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersRulesFixedResponse : TeaModel {
                    /// <summary>
                    /// <para>The Content-Type field in the HTTP header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/json</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The location field in the HTTP response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/index.html">http://www.example.com/index.html</a></para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The response body value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hello World.</para>
                    /// </summary>
                    [NameInMap("MessageBody")]
                    [Validation(Required=false)]
                    public string MessageBody { get; set; }

                    /// <summary>
                    /// <para>The status code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("StatusCode")]
                    [Validation(Required=false)]
                    public int? StatusCode { get; set; }

                }

                /// <summary>
                /// <para>The load balancing configuration overrides applied after a rule is matched. The configured fields override the corresponding fields in the load balancer configuration.</para>
                /// 
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
                /// <para>The rule content, which uses conditional expressions to match user requests. This parameter does not need to be set when adding a global configuration. Two scenarios are supported:</para>
                /// <list type="bullet">
                /// <item><description>Match all incoming requests: Set the value to true.</description></item>
                /// <item><description>Match specific requests: Set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>http.request.uri.path contains &quot;/testing&quot;</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. This parameter does not need to be set when adding a global configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: Enabled.</description></item>
                /// <item><description>off: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("RuleEnable")]
                [Validation(Required=false)]
                public string RuleEnable { get; set; }

                /// <summary>
                /// <para>The rule name. This parameter does not need to be set when adding a global configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r2</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order. A higher value indicates higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// <para>Indicates whether to stop executing subsequent rules. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No. This is the default value.</description></item>
                /// </list>
                /// 
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
            /// <item><description>off: Disabled.</description></item>
            /// <item><description>ip: IP-based session persistence.</description></item>
            /// <item><description>cookie: Cookie-based session persistence.</description></item>
            /// <item><description>http_header: HTTP header-based session persistence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SessionAffinity")]
            [Validation(Required=false)]
            public string SessionAffinity { get; set; }

            /// <summary>
            /// <para>The ID of the site to which the load balancing instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1159101787****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The status of the load balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The load balancing policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order</para>
            /// </summary>
            [NameInMap("SteeringPolicy")]
            [Validation(Required=false)]
            public string SteeringPolicy { get; set; }

            /// <summary>
            /// <para>The address pools mapped to secondary regions. When multiple secondary regions share the same set of address pools, the secondary region names can be concatenated with commas as the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
            /// </summary>
            [NameInMap("SubRegionPools")]
            [Validation(Required=false)]
            public object SubRegionPools { get; set; }

            /// <summary>
            /// <para>The TTL value, which specifies the time-to-live of the DNS record. Default value: 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <para>The page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
