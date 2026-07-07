// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The cross-origin address pool back-to-origin configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestAdaptiveRouting AdaptiveRouting { get; set; }
        public class CreateLoadBalancerRequestAdaptiveRouting : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable cross-origin address pool failover. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Not enabled.</description></item>
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
            /// <para>false</para>
            /// </summary>
            [NameInMap("OriginLevelRetry")]
            [Validation(Required=false)]
            public bool? OriginLevelRetry { get; set; }

        }

        /// <summary>
        /// <para>The list of default address pool IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public List<long?> DefaultPools { get; set; }

        /// <summary>
        /// <para>The description of the load balancer for management and identification purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Load Balancer Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the load balancer is enabled. Valid values:</para>
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
        /// <para>The fallback address pool ID. Traffic is directed to this pool when all other pools are unavailable.</para>
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
            /// <para>The number of consecutive failed probes required to consider the check failed, such as <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful probes required to consider the check successful, such as <c>3</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            /// <summary>
            /// <para>The expected status codes, such as <c>200,202</c>. These are the HTTP response codes that indicate success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ExpectedCodes")]
            [Validation(Required=false)]
            public string ExpectedCodes { get; set; }

            /// <summary>
            /// <para>Specifies whether to follow redirects. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Follow redirects.</description></item>
            /// <item><description>false: Do not follow redirects.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FollowRedirects")]
            [Validation(Required=false)]
            public bool? FollowRedirects { get; set; }

            /// <summary>
            /// <para>The header information included in the probe request. This is the HTTP header.</para>
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
            /// <para>The monitoring interval in seconds, such as <c>60</c>. This specifies the check frequency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The monitor request method, such as <c>GET</c>. This is the HTTP method used for health checks.</para>
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
            /// <para>The monitor check path, such as <c>/healthcheck</c>. This is the URI of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/health</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The origin server port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1921</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The health check timeout period. Unit: seconds. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The monitor protocol type used for health checks. A value of off indicates that health checks are disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>SMTP</description></item>
            /// <item><description>HTTPS</description></item>
            /// <item><description>HTTP</description></item>
            /// <item><description>ICMP Ping</description></item>
            /// <item><description>off</description></item>
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
        /// <para>The name of the load balancer. The name must be in a valid domain name format and must be a subdomain of the site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb.example.com</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The weighted round-robin configuration that controls the traffic distribution weight across different address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestRandomSteering RandomSteering { get; set; }
        public class CreateLoadBalancerRequestRandomSteering : TeaModel {
            /// <summary>
            /// <para>The default round-robin weight applied to all address pools that do not have an individually specified weight. Valid values: integers from 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            /// <summary>
            /// <para>The weight configuration for each backend server pool. The key is the pool ID and the value is the weight coefficient. The weight coefficient represents the relative proportion of traffic distribution.</para>
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
        /// <para>The rule information.</para>
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
            /// <para>The fixed response content returned after a rule is matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;content_type&quot;: &quot;application/json&quot;, &quot;location&quot;: &quot;<a href="http://www.example.com">www.example.com</a>&quot;, &quot;message_body&quot;: &quot;Testing Hello&quot;, &quot;status_code&quot;: 0}</para>
            /// </summary>
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public CreateLoadBalancerRequestRulesFixedResponse FixedResponse { get; set; }
            public class CreateLoadBalancerRequestRulesFixedResponse : TeaModel {
                /// <summary>
                /// <para>The Content-Type field in the HTTP header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/octet-stream</para>
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
                /// <para>Hello World!</para>
                /// </summary>
                [NameInMap("MessageBody")]
                [Validation(Required=false)]
                public string MessageBody { get; set; }

                /// <summary>
                /// <para>The response status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public int? StatusCode { get; set; }

            }

            /// <summary>
            /// <para>The load balancing configuration that overwrites the corresponding fields in the load balancer configuration when a rule is matched. The specified fields overwrite the corresponding fields in the load balancer configuration.</para>
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
            /// <para>The rule content that uses conditional expressions to match user requests. This parameter is not required when you add a global configuration. Two scenarios are supported:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true.</description></item>
            /// <item><description>Match specified requests: Set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.request.method eq &quot;GET&quot; and http.request.version eq &quot;HTTP/1.0&quot;) or (ip.geoip.country eq &quot;CN&quot;) or (http.host eq &quot;<a href="http://www.example.com">www.example.com</a>&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule switch. This parameter is not required when you add a global configuration. Valid values:</para>
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
            /// <para>The rule name. This parameter is not required when you add a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule execution order. This parameter is optional. If not specified, rules are executed in list order. If specified, the value must be a positive integer. A larger value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Specifies whether to stop executing subsequent rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Stop executing subsequent rules.</description></item>
            /// <item><description>false: Continue executing subsequent rules. This is the default value.</description></item>
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
        /// <item><description>off: disabled.</description></item>
        /// <item><description>ip: IP-based session persistence.</description></item>
        /// <item><description>cookie: cookie-based session persistence.</description></item>
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
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The load balancing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>geo: geo-based routing.</description></item>
        /// <item><description>random: weighted round-robin.</description></item>
        /// <item><description>order: primary/secondary mode.</description></item>
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
        /// <para>The address pools mapped to secondary regions. If multiple secondary regions share the same set of address pools, you can concatenate the secondary region names with commas as the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <para>The TTL value, which specifies the time-to-live of the DNS record. Default value: 30 seconds. Valid values: 10 to 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
