// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestAdaptiveRouting AdaptiveRouting { get; set; }
        public class CreateLoadBalancerRequestAdaptiveRouting : TeaModel {
            [NameInMap("FailoverAcrossPools")]
            [Validation(Required=false)]
            public bool? FailoverAcrossPools { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public List<long?> DefaultPools { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("Monitor")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestMonitor Monitor { get; set; }
        public class CreateLoadBalancerRequestMonitor : TeaModel {
            [NameInMap("ConsecutiveDown")]
            [Validation(Required=false)]
            public int? ConsecutiveDown { get; set; }

            [NameInMap("ConsecutiveUp")]
            [Validation(Required=false)]
            public int? ConsecutiveUp { get; set; }

            [NameInMap("ExpectedCodes")]
            [Validation(Required=false)]
            public string ExpectedCodes { get; set; }

            [NameInMap("FollowRedirects")]
            [Validation(Required=false)]
            public bool? FollowRedirects { get; set; }

            [NameInMap("Header")]
            [Validation(Required=false)]
            public object Header { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb.example.com</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestRandomSteering RandomSteering { get; set; }
        public class CreateLoadBalancerRequestRandomSteering : TeaModel {
            [NameInMap("DefaultWeight")]
            [Validation(Required=false)]
            public int? DefaultWeight { get; set; }

            [NameInMap("PoolWeights")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PoolWeights { get; set; }

        }

        [NameInMap("RegionPools")]
        [Validation(Required=false)]
        public object RegionPools { get; set; }

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
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestRules> Rules { get; set; }
        public class CreateLoadBalancerRequestRules : TeaModel {
            [NameInMap("FixedResponse")]
            [Validation(Required=false)]
            public CreateLoadBalancerRequestRulesFixedResponse FixedResponse { get; set; }
            public class CreateLoadBalancerRequestRulesFixedResponse : TeaModel {
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("MessageBody")]
                [Validation(Required=false)]
                public string MessageBody { get; set; }

                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public int? StatusCode { get; set; }

            }

            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public object Overrides { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            [NameInMap("Terminates")]
            [Validation(Required=false)]
            public bool? Terminates { get; set; }

        }

        [NameInMap("SessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        [NameInMap("SessionAffinityAttributes")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestSessionAffinityAttributes SessionAffinityAttributes { get; set; }
        public class CreateLoadBalancerRequestSessionAffinityAttributes : TeaModel {
            [NameInMap("SameSite")]
            [Validation(Required=false)]
            public string SameSite { get; set; }

            [NameInMap("Secure")]
            [Validation(Required=false)]
            public string Secure { get; set; }

            [NameInMap("ZeroDowntimeFailover")]
            [Validation(Required=false)]
            public string ZeroDowntimeFailover { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("SteeringPolicy")]
        [Validation(Required=false)]
        public string SteeringPolicy { get; set; }

        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
