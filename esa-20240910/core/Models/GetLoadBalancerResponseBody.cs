// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration for failover across pools.</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public GetLoadBalancerResponseBodyAdaptiveRouting AdaptiveRouting { get; set; }
        public class GetLoadBalancerResponseBodyAdaptiveRouting : TeaModel {
            /// <summary>
            /// <para>Indicates whether failover across pools is enabled.</para>
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
        /// <para>A list of default origin pool IDs.</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ID of the fallback pool. Routes traffic to this origin pool when all other origin pools are unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96228666776****</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <para>The unique identifier for the load balancer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99867648760****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The health check configuration.</para>
        /// </summary>
        [NameInMap("Monitor")]
        [Validation(Required=false)]
        public GetLoadBalancerResponseBodyMonitor Monitor { get; set; }
        public class GetLoadBalancerResponseBodyMonitor : TeaModel {
            /// <summary>
            /// <para>The number of consecutive failed probes required to declare an origin unhealthy. For example, <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful probes required to declare an origin healthy. For example, <c>3</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            /// <summary>
            /// <para>The expected HTTP status codes for a successful response, such as 200 or 202.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200,202</para>
            /// </summary>
            [NameInMap("ExpectedCodes")]
            [Validation(Required=false)]
            public string ExpectedCodes { get; set; }

            /// <summary>
            /// <para>Specifies whether the health check probe follows redirects.</para>
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
            /// <para>The HTTP headers to include in the health check request.</para>
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
            /// <para>The interval for health checks, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The method for the health check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The region from which probes are sent. Default is <c>Global</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Global</c>: From global locations.</para>
            /// </description></item>
            /// <item><description><para><c>ChineseMainland</c>: From locations within the Chinese Mainland.</para>
            /// </description></item>
            /// <item><description><para><c>OutsideChineseMainland</c>: From global locations outside of the Chinese Mainland.</para>
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
            /// <para>The path for the health check request.</para>
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
            /// <para>The health check timeout, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The protocol used for health checks, such as HTTP. If set to <c>off</c>, health checks are disabled.</para>
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
        /// <para>The weighted routing configuration, which controls the traffic distribution weight among origin pools.</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public GetLoadBalancerResponseBodyRandomSteering RandomSteering { get; set; }
        public class GetLoadBalancerResponseBodyRandomSteering : TeaModel {
            /// <summary>
            /// <para>The default weight for origin pools that do not have an individually assigned weight. The value must be an integer from 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            /// <summary>
            /// <para>A map of weights for individual origin pools, where the key is the origin pool ID and the value is its weight. The weight determines the traffic distribution ratio.</para>
            /// </summary>
            [NameInMap("PoolWeights")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PoolWeights { get; set; }

        }

        /// <summary>
        /// <para>A map of regions to their corresponding origin pools.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of rule configurations that define behavior for specific conditions.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<GetLoadBalancerResponseBodyRules> Rules { get; set; }
        public class GetLoadBalancerResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>Specifies a fixed response to return when the rule matches.</para>
            /// </summary>
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public GetLoadBalancerResponseBodyRulesFixedResponse FixedResponse { get; set; }
            public class GetLoadBalancerResponseBodyRulesFixedResponse : TeaModel {
                /// <summary>
                /// <para>The value for the <c>Content-Type</c> HTTP response header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/json</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The value for the <c>Location</c> HTTP response header.</para>
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
                /// <para>The HTTP status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public int? StatusCode { get; set; }

            }

            /// <summary>
            /// <para>A set of settings that override the primary load balancer configuration when this rule matches. Fields defined here take precedence over the primary configuration.</para>
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
            /// <para>The conditional expression used to match incoming requests. This parameter is not required for the global configuration.</para>
            /// <list type="bullet">
            /// <item><description><para>To match all requests, set the value to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>To match specific requests, use a custom expression. For example, <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
            /// <para>Indicates whether the rule is enabled. This parameter is not required for the global configuration. Valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The name of the rule. This parameter is not required when adding a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r2</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution priority of the rule. A higher value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Indicates whether to stop evaluating subsequent rules after this one matches.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Stop evaluation.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Continues evaluation. (Default)</para>
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
        /// <para>The session affinity policy. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><c>off</c>: Session affinity is disabled.</para>
        /// </description></item>
        /// <item><description><para><c>ip</c>: Session affinity is based on the client\&quot;s IP address.</para>
        /// </description></item>
        /// <item><description><para><c>cookie</c>: Session affinity is based on a cookie.</para>
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
        /// <para>The ID of the site for the load balancer.</para>
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
        /// <para>The steering policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("SteeringPolicy")]
        [Validation(Required=false)]
        public string SteeringPolicy { get; set; }

        /// <summary>
        /// <para>A map of sub-regions to their corresponding origin pools. To map multiple sub-regions to the same set of origin pools, concatenate their codes with commas to create the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <para>The Time to Live (TTL) for the DNS record, in seconds. The default is 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
