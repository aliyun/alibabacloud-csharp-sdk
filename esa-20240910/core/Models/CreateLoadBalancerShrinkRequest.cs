// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateLoadBalancerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for failover across address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public string AdaptiveRoutingShrink { get; set; }

        /// <summary>
        /// <para>A list of default address pool IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public string DefaultPoolsShrink { get; set; }

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
        public string MonitorShrink { get; set; }

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
        public string RandomSteeringShrink { get; set; }

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
        public string RulesShrink { get; set; }

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
