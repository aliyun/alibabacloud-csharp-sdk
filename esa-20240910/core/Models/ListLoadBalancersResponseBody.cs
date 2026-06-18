// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of load balancers.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The configuration for failover across pools.</para>
            /// </summary>
            [NameInMap("AdaptiveRouting")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAdaptiveRouting AdaptiveRouting { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAdaptiveRouting : TeaModel {
                /// <summary>
                /// <para>Indicates whether to enable failover across pools.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FailoverAcrossPools")]
                [Validation(Required=false)]
                public bool? FailoverAcrossPools { get; set; }

                [NameInMap("OriginLevelRetry")]
                [Validation(Required=false)]
                public bool? OriginLevelRetry { get; set; }

            }

            /// <summary>
            /// <para>A list of default pool IDs.</para>
            /// </summary>
            [NameInMap("DefaultPools")]
            [Validation(Required=false)]
            public List<long?> DefaultPools { get; set; }

            /// <summary>
            /// <para>The description of the load balancer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the load balancer is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the fallback pool. The load balancer routes traffic to this pool when all other pools are unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96228666776****</para>
            /// </summary>
            [NameInMap("FallbackPool")]
            [Validation(Required=false)]
            public long? FallbackPool { get; set; }

            /// <summary>
            /// <para>The unique ID of the load balancer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>998676487607104</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The health check configuration.</para>
            /// </summary>
            [NameInMap("Monitor")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersMonitor Monitor { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersMonitor : TeaModel {
                /// <summary>
                /// <para>The number of consecutive failed health checks required to consider a pool unhealthy. For example, <c>5</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ConsecutiveDown")]
                [Validation(Required=false)]
                public int? ConsecutiveDown { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks required to consider a pool healthy. For example, <c>3</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ConsecutiveUp")]
                [Validation(Required=false)]
                public int? ConsecutiveUp { get; set; }

                /// <summary>
                /// <para>The expected HTTP status codes that indicate a successful health check, such as <c>200</c> or <c>202</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200,202</para>
                /// </summary>
                [NameInMap("ExpectedCodes")]
                [Validation(Required=false)]
                public string ExpectedCodes { get; set; }

                /// <summary>
                /// <para>Indicates whether the health check should follow redirects.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Follows redirects.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Does not follow redirects.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FollowRedirects")]
                [Validation(Required=false)]
                public bool? FollowRedirects { get; set; }

                /// <summary>
                /// <para>The HTTP headers to include in the health check probe.</para>
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
                /// <para>The interval between health checks, in seconds.</para>
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
                /// <para>The probe locations for health checks. The default is <c>Global</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Global</c>: Sends probes from global locations.</para>
                /// </description></item>
                /// <item><description><para><c>ChineseMainland</c>: Sends probes from locations within the Chinese mainland.</para>
                /// </description></item>
                /// <item><description><para><c>OutsideChineseMainland</c>: Sends probes from global locations outside the Chinese mainland.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
                /// </summary>
                [NameInMap("MonitoringRegion")]
                [Validation(Required=false)]
                public string MonitoringRegion { get; set; }

                /// <summary>
                /// <para>The path to request for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The destination port for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout for a single health check, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The protocol for the health check, such as <c>HTTP</c>. Set to <c>off</c> to disable health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the load balancer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb.example.com</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The configuration for weighted round robin, which controls traffic distribution among pools.</para>
            /// </summary>
            [NameInMap("RandomSteering")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersRandomSteering RandomSteering { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersRandomSteering : TeaModel {
                /// <summary>
                /// <para>The default weight applied to any pool not defined in <c>PoolWeights</c>. The weight determines the proportion of traffic sent to the pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("DefaultWeight")]
                [Validation(Required=false)]
                public int? DefaultWeight { get; set; }

                /// <summary>
                /// <para>The weight configuration for each backend pool, where the key is the pool ID and the value is the weight.</para>
                /// </summary>
                [NameInMap("PoolWeights")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PoolWeights { get; set; }

            }

            /// <summary>
            /// <para>The pools that correspond to regions.</para>
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
            /// <para>A list of rule configurations that define behavior for specific conditions.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersRules> Rules { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersRules : TeaModel {
                /// <summary>
                /// <para>Specifies the response to return when a rule matches.</para>
                /// </summary>
                [NameInMap("FixedResponse")]
                [Validation(Required=false)]
                public ListLoadBalancersResponseBodyLoadBalancersRulesFixedResponse FixedResponse { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersRulesFixedResponse : TeaModel {
                    /// <summary>
                    /// <para>The <c>Content-Type</c> header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/json</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The <c>Location</c> response header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/index.html">http://www.example.com/index.html</a></para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The content of the response body.</para>
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
                /// <para>The load balancer settings to override when a rule matches. Any field you specify overwrites the load balancer\&quot;s corresponding setting.</para>
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
                /// <para>The rule expression that matches user requests. This parameter is not required for global configurations. Use cases:</para>
                /// <list type="bullet">
                /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
                /// </description></item>
                /// <item><description><para>To match specific requests, set the value to a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>http.request.uri.path contains &quot;/testing&quot;</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. This parameter is not required for global configurations. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>on</c>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><c>off</c>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("RuleEnable")]
                [Validation(Required=false)]
                public string RuleEnable { get; set; }

                /// <summary>
                /// <para>The name of the rule. This parameter is not required for global configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r2</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The execution priority of the rule. Higher values indicate higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// <para>Specifies whether to stop executing subsequent rules after this rule matches.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Stops executing subsequent rules.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Continues to execute subsequent rules. This is the default value.</para>
                /// </description></item>
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
            /// <para>The session affinity setting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>off</c>: Session affinity is disabled.</para>
            /// </description></item>
            /// <item><description><para><c>ip</c>: Enables session affinity based on the client\&quot;s IP address.</para>
            /// </description></item>
            /// <item><description><para><c>cookie</c>: Enables session affinity based on a cookie.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SessionAffinity")]
            [Validation(Required=false)]
            public string SessionAffinity { get; set; }

            /// <summary>
            /// <para>The site ID of the load balancer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1159101787****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The status of the load balancer.</para>
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
            /// <para>The pools that correspond to sub-regions. If multiple sub-regions share the same set of pools, you can use a comma-separated list of sub-region codes as the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
            /// </summary>
            [NameInMap("SubRegionPools")]
            [Validation(Required=false)]
            public object SubRegionPools { get; set; }

            /// <summary>
            /// <para>The Time to Live (TTL) for the DNS record, in seconds. The default value is 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <para>The page number. This value matches the <c>PageNumber</c> request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
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
        /// <para>The total number of entries found.</para>
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
