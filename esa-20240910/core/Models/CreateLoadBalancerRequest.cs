// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>Configuration for failover across pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestAdaptiveRouting AdaptiveRouting { get; set; }
        public class CreateLoadBalancerRequestAdaptiveRouting : TeaModel {
            /// <summary>
            /// <para>Whether to failover across pools.</para>
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
        /// <para>List of default pools.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public List<long?> DefaultPools { get; set; }

        /// <summary>
        /// <para>Detailed description of the load balancer, for easier management and identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试负载均衡器描述</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <para>Monitor configuration for health checks.</para>
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
            /// <para>Number of consecutive failed probes required to consider the target as down, such as <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            /// <summary>
            /// <para>Number of consecutive successful probes required to consider the target as up, such as <c>3</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            /// <summary>
            /// <para>Expected status codes, such as <c>200,202</c>, indicating successful HTTP responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
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
            /// <para>Header information included during the probe, which is an HTTP header.</para>
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
            /// <para>Monitoring interval, such as <c>60</c> seconds, indicating the frequency of checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Monitor request method, such as <c>GET</c>, which is a method in the HTTP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>Monitor check path, such as <c>/healthcheck</c>, which is an HTTP request path.</para>
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
            /// <para>1921</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>Application health check timeout, in seconds, with a value range of 1-10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>Monitor protocol type, such as HTTP, used for health checks. When the value is <c>off</c>, it indicates that no check will be performed.</para>
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
        /// <para>The name of the load balancer, which must meet domain name format validation and be a subdomain under the site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb.example.com</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Weighted round-robin configuration, used to control the traffic distribution weights among different pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestRandomSteering RandomSteering { get; set; }
        public class CreateLoadBalancerRequestRandomSteering : TeaModel {
            /// <summary>
            /// <para>Default weight for all pools that do not have individual weights specified. The value range is an integer between 0 and 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            /// <summary>
            /// <para>Weight configuration for each backend server pool, with the key being the pool ID and the value being the weight coefficient. The weight coefficient represents the proportion of relative traffic distribution.</para>
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
        /// <para>Rule information.</para>
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
            /// <para>Execute a specified response after matching the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;content_type&quot;: &quot;application/json&quot;, &quot;location&quot;: &quot;<a href="http://www.example.com">www.example.com</a>&quot;, &quot;message_body&quot;: &quot;Testing Hello&quot;, &quot;status_code&quot;: 0}</para>
            /// </summary>
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public CreateLoadBalancerRequestRulesFixedResponse FixedResponse { get; set; }
            public class CreateLoadBalancerRequestRulesFixedResponse : TeaModel {
                /// <summary>
                /// <para>Content-Type field in the HTTP Header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/octet-stream</para>
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
            /// <para>Modify the corresponding load balancing configuration after matching the rule. The configured fields will override the corresponding fields in the load balancer configuration.</para>
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
            /// <para>Matching rule information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(http.request.method eq &quot;GET&quot; and http.request.version eq &quot;HTTP/1.0&quot;) or (ip.geoip.country eq &quot;CN&quot;) or (http.host eq &quot;<a href="http://www.example.com">www.example.com</a>&quot;)</para>
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
            /// <para>Rule execution order. It can be left blank, in which case the rules will be executed in the list order. If filled, it should be a positive integer greater than 0.</para>
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
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Load balancing strategy.</para>
        /// <list type="bullet">
        /// <item><description>geo: Geographical strategy.</description></item>
        /// <item><description>random: Weighted round-robin.</description></item>
        /// <item><description>order: Primary and backup method.</description></item>
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
        /// <para>Address pools corresponding to secondary regions. When multiple secondary regions share a set of address pools, you can use a comma-separated list of secondary regions as the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <para>TTL value, the time-to-live for DNS records, with a default of 30 seconds. The value range is 10-600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
