// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>Configures origin-pull behavior across address pools.</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public UpdateLoadBalancerRequestAdaptiveRouting AdaptiveRouting { get; set; }
        public class UpdateLoadBalancerRequestAdaptiveRouting : TeaModel {
            /// <summary>
            /// <para>Specifies whether to perform origin-pull across address pools.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables origin-pull across address pools.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables origin-pull across address pools.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FailoverAcrossPools")]
            [Validation(Required=false)]
            public bool? FailoverAcrossPools { get; set; }

            [NameInMap("OriginLevelRetry")]
            [Validation(Required=false)]
            public bool? OriginLevelRetry { get; set; }

        }

        /// <summary>
        /// <para>A list of default address pool IDs.</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public List<long?> DefaultPools { get; set; }

        /// <summary>
        /// <para>An optional description of the load balancer for easier identification and management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Load balancer description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the load balancer is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The load balancer is enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The load balancer is disabled.</para>
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
        /// <para>The ID of the fallback address pool. Traffic is routed to this pool when all other address pools are unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96228666776****</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <para>The ID of the load balancer. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2868897.html">ListLoadBalancers</a> API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95913670174****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The health check monitor configuration.</para>
        /// </summary>
        [NameInMap("Monitor")]
        [Validation(Required=false)]
        public UpdateLoadBalancerRequestMonitor Monitor { get; set; }
        public class UpdateLoadBalancerRequestMonitor : TeaModel {
            /// <summary>
            /// <para>The number of consecutive failed health checks required to declare an origin server unhealthy. For example, <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful health checks required to declare an origin server healthy. For example, <c>3</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            /// <summary>
            /// <para>The expected HTTP status codes that indicate a healthy response. For example, <c>200,202</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200,202</para>
            /// </summary>
            [NameInMap("ExpectedCodes")]
            [Validation(Required=false)]
            public string ExpectedCodes { get; set; }

            /// <summary>
            /// <para>Specifies whether the health check monitor follows HTTP redirections.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The monitor follows HTTP redirections.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The monitor does not follow HTTP redirections.</para>
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
            /// <para>The HTTP request headers to send with each health check.</para>
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
            /// <para>The interval in seconds between each health check. For example, <c>60</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The HTTP method to use for the health check. For example, <c>GET</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The regions from which the health checks are performed. The default value is <c>Global</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Global</c>: From probe locations worldwide.</para>
            /// </description></item>
            /// <item><description><para><c>ChineseMainland</c>: From probe locations within the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><c>OutsideChineseMainland</c>: From probe locations outside the Chinese mainland.</para>
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
            /// <para>The path on the origin server to request for the health check. For example, <c>/healthcheck</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/health</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The port on the origin server to use for the health check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The timeout for the health check, in seconds. The value must be between 1 and 10, inclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The protocol to use for the health check, such as <c>HTTP</c>. If you set this to <c>off</c>, no health check is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The configuration for weighted round-robin. This setting controls the weight of traffic distributed to different address pools.</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public UpdateLoadBalancerRequestRandomSteering RandomSteering { get; set; }
        public class UpdateLoadBalancerRequestRandomSteering : TeaModel {
            /// <summary>
            /// <para>The default weight applied to all address pools that do not have a specific weight defined. The value must be an integer from 0 to 100, inclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            /// <summary>
            /// <para>A map of pool IDs to their corresponding weights. These weights determine the proportion of traffic routed to each backend server pool.</para>
            /// </summary>
            [NameInMap("PoolWeights")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PoolWeights { get; set; }

        }

        /// <summary>
        /// <para>A map of primary regions to their corresponding address pools.</para>
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
        /// <para>A list of rules that define behavior overrides for specific conditions.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerRequestRules> Rules { get; set; }
        public class UpdateLoadBalancerRequestRules : TeaModel {
            /// <summary>
            /// <para>The fixed response to return when the rule\&quot;s condition is met.</para>
            /// </summary>
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public UpdateLoadBalancerRequestRulesFixedResponse FixedResponse { get; set; }
            public class UpdateLoadBalancerRequestRulesFixedResponse : TeaModel {
                /// <summary>
                /// <para>The value of the <c>Content-Type</c> field in the HTTP response header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/json</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The value of the <c>Location</c> field in the HTTP response header. This is typically used for redirections.</para>
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
                /// <para>Hello World!</para>
                /// </summary>
                [NameInMap("MessageBody")]
                [Validation(Required=false)]
                public string MessageBody { get; set; }

                /// <summary>
                /// <para>The HTTP status code of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public int? StatusCode { get; set; }

            }

            /// <summary>
            /// <para>The settings to override for requests that match this rule\&quot;s condition. These settings take precedence over the load balancer\&quot;s main configuration.</para>
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
            /// <para>The content of the rule, specified as a conditional expression to match user requests. This parameter is not required when you configure global settings. Use cases:</para>
            /// <list type="bullet">
            /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>To match specific requests, set the value to a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http.request.method eq &quot;GET&quot;</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Specifies whether the rule is enabled. This parameter is not required when you configure global settings. Valid values:</para>
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
            /// <para>The name of the rule. This parameter is not required when you configure global settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution priority of the rule. This parameter is optional. If you do not specify this parameter, rules are executed in the order they are listed. If specified, the value must be an integer greater than 0. A larger value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Specifies whether to stop processing subsequent rules after this rule is matched.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Stop processing subsequent rules.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Continue processing subsequent rules. This is the default value.</para>
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
        /// <para>The method for session affinity, which ensures that requests from the same client are routed to the same origin server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>off</c>: Disables session affinity.</para>
        /// </description></item>
        /// <item><description><para><c>ip</c>: Enables session affinity based on the client IP address.</para>
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
        /// <para>The ID of the Site. You can obtain this ID by calling the <a href="~~ListSites~~">ListSites</a> API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1159101787****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The traffic steering policy, which determines how traffic is distributed among the address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("SteeringPolicy")]
        [Validation(Required=false)]
        public string SteeringPolicy { get; set; }

        /// <summary>
        /// <para>A map of secondary regions to their corresponding address pools. To assign the same address pools to multiple secondary regions, combine their codes into a single, comma-separated key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <para>The Time to Live (TTL) for the DNS record, in seconds. The default is 30. The value must be between 10 and 600, inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
