// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for failover across address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestAdaptiveRouting AdaptiveRouting { get; set; }
        public class CreateLoadBalancerRequestAdaptiveRouting : TeaModel {
            /// <summary>
            /// <para>Indicates whether to fail over across address pools.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Yes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: No.</para>
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
        /// <para>A list of default address pool IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public List<long?> DefaultPools { get; set; }

        /// <summary>
        /// <para>A description of the Server Load Balancer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test load balancer description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Server Load Balancer.</para>
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
        /// <para>The ID of the fallback pool. The system directs traffic to this pool when all other pools are unavailable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <para>The monitor configuration for health checks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("Monitor")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestMonitor Monitor { get; set; }
        public class CreateLoadBalancerRequestMonitor : TeaModel {
            /// <summary>
            /// <para>The number of consecutive failed health checks required to mark an origin server as unhealthy. For example, <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful health checks required to mark an origin server as healthy. For example, <c>3</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            /// <summary>
            /// <para>The expected HTTP status codes that indicate a successful health check. Separate multiple codes with commas. For example, <c>200,202</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ExpectedCodes")]
            [Validation(Required=false)]
            public string ExpectedCodes { get; set; }

            /// <summary>
            /// <para>Specifies whether the health check monitor follows HTTP redirects.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Yes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: No.</para>
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
            /// <para>The interval in seconds between consecutive health checks. For example, <c>60</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The HTTP method for the health check. For example, <c>GET</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The regions from which the monitor initiates health check probes. Default: <c>Global</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Global</c>: Worldwide.</para>
            /// </description></item>
            /// <item><description><para><c>ChineseMainland</c>: Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><c>OutsideChineseMainland</c>: Regions outside the Chinese mainland.</para>
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
            /// <para>The request path for the HTTP health check. For example, <c>/healthcheck</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/health</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The port on the origin server to check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1921</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The timeout for the health check, in seconds. The value must be between 1 and 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The protocol for the health check. Setting this to <c>off</c> disables health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>TCP</para>
            /// </description></item>
            /// <item><description><para>UDP</para>
            /// </description></item>
            /// <item><description><para>SMTP</para>
            /// </description></item>
            /// <item><description><para>HTTPS</para>
            /// </description></item>
            /// <item><description><para>HTTP</para>
            /// </description></item>
            /// <item><description><para>ICMP Ping</para>
            /// </description></item>
            /// <item><description><para>off</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the Server Load Balancer. It must be a valid domain name and a subdomain of the site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb.example.com</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration for weighted round-robin steering. This setting controls how the system distributes traffic across different address pools based on their weights.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestRandomSteering RandomSteering { get; set; }
        public class CreateLoadBalancerRequestRandomSteering : TeaModel {
            /// <summary>
            /// <para>The default weight for the weighted round-robin policy. This weight applies to all address pools without a specifically assigned weight. Valid values: 0–100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            /// <summary>
            /// <para>A map of weights for each address pool, where the key is the pool ID and the value is its weight. The weight determines the proportion of traffic that the pool receives.</para>
            /// </summary>
            [NameInMap("PoolWeights")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PoolWeights { get; set; }

        }

        /// <summary>
        /// <para>The mapping of primary regions to address pools.</para>
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
        /// <para>A list of rules to override the default traffic steering policy for specific requests.</para>
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
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestRules> Rules { get; set; }
        public class CreateLoadBalancerRequestRules : TeaModel {
            /// <summary>
            /// <para>Specifies a fixed response to return when a request matches the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;content_type&quot;: &quot;application/json&quot;, &quot;location&quot;: &quot;<a href="http://www.example.com">www.example.com</a>&quot;, &quot;message_body&quot;: &quot;Testing Hello&quot;, &quot;status_code&quot;: 0}</para>
            /// </summary>
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public CreateLoadBalancerRequestRulesFixedResponse FixedResponse { get; set; }
            public class CreateLoadBalancerRequestRulesFixedResponse : TeaModel {
                /// <summary>
                /// <para>The value of the <c>Content-Type</c> field in the HTTP response header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/octet-stream</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The value of the <c>Location</c> field in the HTTP response header, typically used for redirects.</para>
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
            /// <para>The Server Load Balancer settings to override when a request matches the rule. The fields specified here replace the corresponding fields in the main Server Load Balancer configuration.</para>
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
            /// <para>A conditional expression that matches incoming requests.</para>
            /// <list type="bullet">
            /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>To match specific requests, provide a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.request.method eq &quot;GET&quot; and http.request.version eq &quot;HTTP/1.0&quot;) or (ip.geoip.country eq &quot;CN&quot;) or (http.host eq &quot;<a href="http://www.example.com">www.example.com</a>&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Specifies whether the rule is enabled. This parameter is not required when adding a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: The rule is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: The rule is disabled.</para>
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
            /// <para>The name of the rule. This parameter is not required when adding a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution order of the rule. If you do not specify a value, the system executes rules in the order they appear in the list. If specified, the value must be an integer greater than 0. The system executes rules with a higher value first.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Specifies whether to stop processing subsequent rules after a match.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Yes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: No. (Default)</para>
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
        /// <para>Specifies the session affinity policy, which consistently routes requests from the same client to the same origin server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>off</c>: Disables session affinity.</para>
        /// </description></item>
        /// <item><description><para><c>ip</c>: Routes requests based on the client\&quot;s IP address.</para>
        /// </description></item>
        /// <item><description><para><c>cookie</c>: Uses a cookie to maintain session affinity.</para>
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
        /// <para>The site ID. Call the <a href="~~ListSites~~">ListSites</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The traffic steering policy, which determines how the system distributes traffic among the address pools. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>geo</c>: Geographic routing.</para>
        /// </description></item>
        /// <item><description><para><c>random</c>: Weighted round-robin.</para>
        /// </description></item>
        /// <item><description><para><c>order</c>: Primary/standby.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("SteeringPolicy")]
        [Validation(Required=false)]
        public string SteeringPolicy { get; set; }

        /// <summary>
        /// <para>The mapping of secondary regions to address pools. To map multiple secondary regions to the same address pools, combine their region codes with commas to form the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <para>The time to live (TTL) for the DNS record, in seconds. The default value is 30. The value must be between 10 and 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
