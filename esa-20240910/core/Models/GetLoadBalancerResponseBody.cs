// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// <para>Cross-pool failover configuration.</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public GetLoadBalancerResponseBodyAdaptiveRouting AdaptiveRouting { get; set; }
        public class GetLoadBalancerResponseBodyAdaptiveRouting : TeaModel {
            /// <summary>
            /// <para>Whether to fail over across pools.</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FailoverAcrossPools")]
            [Validation(Required=false)]
            public bool? FailoverAcrossPools { get; set; }

        }

        /// <summary>
        /// <para>List of default pool IDs.</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public List<long?> DefaultPools { get; set; }

        /// <summary>
        /// <para>Description of the load balancer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether the load balancer is enabled.</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The fallback pool ID, to which traffic will be redirected if all other pools are unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96228666776****</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <para>The unique identifier ID of the load balancer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99867648760****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Monitor configuration.</para>
        /// </summary>
        [NameInMap("Monitor")]
        [Validation(Required=false)]
        public GetLoadBalancerResponseBodyMonitor Monitor { get; set; }
        public class GetLoadBalancerResponseBodyMonitor : TeaModel {
            /// <summary>
            /// <para>The number of consecutive failed probes required to consider the target as unhealthy, for example, <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful probes required to consider the target as healthy, for example, <c>3</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            /// <summary>
            /// <para>Expected status codes, such as 200, 202, for successful HTTP responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200,202</para>
            /// </summary>
            [NameInMap("ExpectedCodes")]
            [Validation(Required=false)]
            public string ExpectedCodes { get; set; }

            /// <summary>
            /// <para>Whether to follow redirects.</para>
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
            /// <para>The HTTP headers to be included in the probe request.</para>
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
            /// <para>Health check interval, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Health check method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>Path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>Target port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The timeout for the health check, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>Monitor protocol type, such as HTTP, used for health checks. When the value is <c>off</c>, it indicates that no check is performed.</para>
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
        /// <para>Weighted round-robin configuration, used to control the traffic distribution weights among different pools.</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public GetLoadBalancerResponseBodyRandomSteering RandomSteering { get; set; }
        public class GetLoadBalancerResponseBodyRandomSteering : TeaModel {
            /// <summary>
            /// <para>The default round-robin weight, used for all pools that do not have individually specified weights. The value range is 0-100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            /// <summary>
            /// <para>Weight configurations for each backend server pool, where the key is the pool ID and the value is the weight coefficient. The weight coefficient represents the relative traffic distribution ratio.</para>
            /// </summary>
            [NameInMap("PoolWeights")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PoolWeights { get; set; }

        }

        /// <summary>
        /// <para>Address pools corresponding to primary regions.</para>
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
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of rule configurations, used to define behavior under specific conditions.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<GetLoadBalancerResponseBodyRules> Rules { get; set; }
        public class GetLoadBalancerResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>Executes a specified response after matching the rule.</para>
            /// </summary>
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public GetLoadBalancerResponseBodyRulesFixedResponse FixedResponse { get; set; }
            public class GetLoadBalancerResponseBodyRulesFixedResponse : TeaModel {
                /// <summary>
                /// <para>The Content-Type field in the HTTP Header.</para>
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
                /// <para>The body value of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello World.</para>
                /// </summary>
                [NameInMap("MessageBody")]
                [Validation(Required=false)]
                public string MessageBody { get; set; }

                /// <summary>
                /// <para>Status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public int? StatusCode { get; set; }

            }

            /// <summary>
            /// <para>Modifies the load balancer configuration for the corresponding request after matching the rule. The fields in this configuration will override the corresponding fields in the load balancer\&quot;s configuration.</para>
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
            /// <para>Rule content, using conditional expressions to match user requests. This parameter is not required when adding global configurations. There are two usage scenarios:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true</description></item>
            /// <item><description>Match specific requests: Set the value to a custom expression, for example: (http.host eq \&quot;video.example.com\&quot;)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http.request.uri.path contains &quot;/testing&quot;</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Rule switch. This parameter is not required when adding global configurations. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>Rule name. This parameter is not required when adding global configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r2</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Rule execution order. The higher the number, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Whether to terminate the execution of subsequent rules.</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No, default value.</description></item>
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
        /// <para>Session persistence, with values:</para>
        /// <list type="bullet">
        /// <item><description>off: Not enabled.</description></item>
        /// <item><description>ip: Session persistence by IP.</description></item>
        /// <item><description>cookie: Session persistence by cookie.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("SessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        /// <summary>
        /// <para>The site ID to which the load balancer belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11591017874****</para>
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
        /// <para>Load balancing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("SteeringPolicy")]
        [Validation(Required=false)]
        public string SteeringPolicy { get; set; }

        /// <summary>
        /// <para>Address pools corresponding to secondary regions. When multiple secondary regions share a set of address pools, the keys can be concatenated with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <para>TTL value, the time-to-live for DNS records, with a default of 30 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
