// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>Configuration for cross-pool origin fallback.</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public UpdateLoadBalancerRequestAdaptiveRouting AdaptiveRouting { get; set; }
        public class UpdateLoadBalancerRequestAdaptiveRouting : TeaModel {
            /// <summary>
            /// <para>Whether to perform cross-pool origin fallback.</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
        /// <para>Detailed description of the load balancer, which is useful for management and identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>负载均衡器描述</para>
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
        /// <para>Fallback pool ID, where traffic will be directed when all other pools are unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96228666776****</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <para>Load balancer ID, which can be obtained by calling the <a href="~~ListLoadBalancers~~">ListLoadBalancers</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95913670174****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Monitor configuration for health checks.</para>
        /// </summary>
        [NameInMap("Monitor")]
        [Validation(Required=false)]
        public UpdateLoadBalancerRequestMonitor Monitor { get; set; }
        public class UpdateLoadBalancerRequestMonitor : TeaModel {
            /// <summary>
            /// <para>Number of consecutive failed probes required to consider the target unhealthy, such as 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            /// <summary>
            /// <para>Number of consecutive successful probes required to consider the target healthy, such as 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            /// <summary>
            /// <para>Expected status codes, such as 200,202, which are successful HTTP responses.</para>
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
            /// <para>Monitor request header configuration.</para>
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
            /// <para>Monitor interval, such as 60 seconds, which is the check frequency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Monitor request method, such as GET, which is a method in the HTTP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>Monitor check path, such as /healthcheck, which is the HTTP request path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/health</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>Origin server port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>Application health check timeout, in seconds. The range is 1-10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>Monitor protocol type, such as HTTP, used for health checks. When the value is \&quot;off\&quot;, it indicates that no check will be performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Weighted round-robin configuration, used to control the traffic distribution weights among different pools.</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public UpdateLoadBalancerRequestRandomSteering RandomSteering { get; set; }
        public class UpdateLoadBalancerRequestRandomSteering : TeaModel {
            /// <summary>
            /// <para>The default round-robin weight, used for all pools that do not have a specific weight set. The value range is an integer between 0 and 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            /// <summary>
            /// <para>Weight configuration for each backend server pool, where the key is the pool ID and the value is the weight coefficient. The weight coefficient represents the proportion of relative traffic distribution.</para>
            /// </summary>
            [NameInMap("PoolWeights")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PoolWeights { get; set; }

        }

        /// <summary>
        /// <para>Address pools corresponding to the primary region.</para>
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
        /// <para>Rule configuration list, used to define behavior overrides under specific conditions.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerRequestRules> Rules { get; set; }
        public class UpdateLoadBalancerRequestRules : TeaModel {
            /// <summary>
            /// <para>Execute a specified response after matching the rule.</para>
            /// </summary>
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public UpdateLoadBalancerRequestRulesFixedResponse FixedResponse { get; set; }
            public class UpdateLoadBalancerRequestRulesFixedResponse : TeaModel {
                /// <summary>
                /// <para>Content-Type field in the HTTP Header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/json</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>Location field in the HTTP response.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/index.html">http://www.example.com/index.html</a></para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>Response body value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello World!</para>
                /// </summary>
                [NameInMap("MessageBody")]
                [Validation(Required=false)]
                public string MessageBody { get; set; }

                /// <summary>
                /// <para>Response status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public int? StatusCode { get; set; }

            }

            /// <summary>
            /// <para>Modify the corresponding load balancing configuration after matching the rule. The fields in the configuration will override the corresponding fields in the load balancer configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///             &quot;adaptive_routing&quot;: {
            ///                 &quot;failover_across_pools&quot;: true
            ///             },
            ///             &quot;sub_region_pools&quot;: {
            ///                 &quot;AL,AT&quot;: [
            ///                     92298024898****,
            ///                     92304347804****
            ///                 ],
            ///                 &quot;BG,BY&quot;: [
            ///                     92298024898****
            ///                 ]
            ///             },
            ///             &quot;default_pools&quot;: [
            ///                 92298024898****,
            ///                 92304347804****
            ///             ],
            ///             &quot;fallback_pool&quot;: 92298024898****,
            ///             &quot;location_strategy&quot;: {
            ///                 &quot;mode&quot;: &quot;resolver_ip&quot;,
            ///                 &quot;prefer_ecs&quot;: &quot;always&quot;
            ///             },
            ///             &quot;random_steering&quot;: {
            ///                 &quot;default_weight&quot;: 0.3,
            ///                 &quot;pool_weights&quot;: {
            ///                     &quot;92298024898****&quot;: 0.7,
            ///                     &quot;92304347804****&quot;: 0.8
            ///                 }
            ///             },
            ///             &quot;region_pools&quot;: {
            ///                 &quot;CN,SEAS&quot;: [
            ///                     92298024898****,
            ///                     92304347804****
            ///                 ],
            ///                 &quot;SAF,SAS&quot;: [
            ///                     92304347804****
            ///                 ]
            ///             },
            ///             &quot;session_affinity&quot;: &quot;ip&quot;,
            ///             &quot;steering_policy&quot;: &quot;geo&quot;,
            ///             &quot;ttl&quot;: 30
            ///         }</para>
            /// </summary>
            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public object Overrides { get; set; }

            /// <summary>
            /// <para>Matching condition, such as a rule based on the request URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http.request.method eq &quot;GET&quot;</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Rule switch.</para>
            /// <list type="bullet">
            /// <item><description>on: Enable the rule.</description></item>
            /// <item><description>off: Disable the rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>Rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution order of the rule. It can be left blank, in which case the rules will be executed in the list order. If specified, it must be a positive integer.</para>
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
            /// <item><description>false: No.</description></item>
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
        /// <item><description>cookie: Not enabled for session persistence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("SessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1159101787****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

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
        /// <para>Address pools corresponding to the secondary region. When multiple secondary regions share a set of address pools, you can use a comma-separated list of secondary regions as the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <para>TTL value, the time-to-live for DNS records. The default is 30, and the range is 10-600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
