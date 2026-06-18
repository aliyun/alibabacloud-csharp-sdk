// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateLoadBalancerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Configures origin-pull behavior across address pools.</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public string AdaptiveRoutingShrink { get; set; }

        /// <summary>
        /// <para>A list of default address pool IDs.</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public string DefaultPoolsShrink { get; set; }

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
        public string MonitorShrink { get; set; }

        /// <summary>
        /// <para>The configuration for weighted round-robin. This setting controls the weight of traffic distributed to different address pools.</para>
        /// </summary>
        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public string RandomSteeringShrink { get; set; }

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
        public string RulesShrink { get; set; }

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
