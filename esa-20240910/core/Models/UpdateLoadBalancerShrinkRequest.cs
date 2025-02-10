// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateLoadBalancerShrinkRequest : TeaModel {
        [NameInMap("AdaptiveRouting")]
        [Validation(Required=false)]
        public string AdaptiveRoutingShrink { get; set; }

        [NameInMap("DefaultPools")]
        [Validation(Required=false)]
        public string DefaultPoolsShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>96228666776****</para>
        /// </summary>
        [NameInMap("FallbackPool")]
        [Validation(Required=false)]
        public long? FallbackPool { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95913670174****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Monitor")]
        [Validation(Required=false)]
        public string MonitorShrink { get; set; }

        [NameInMap("RandomSteering")]
        [Validation(Required=false)]
        public string RandomSteeringShrink { get; set; }

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
        [NameInMap("RegionPools")]
        [Validation(Required=false)]
        public object RegionPools { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

        /// <summary>
        /// <para>Session persistence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off:disables session persistence.</description></item>
        /// <item><description>ip: enables session persistence by IP address.</description></item>
        /// <item><description>cookie: disables session persistence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("SessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        [NameInMap("SessionAffinityAttributes")]
        [Validation(Required=false)]
        public string SessionAffinityAttributesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateLoadBalancer</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("SteeringPolicy")]
        [Validation(Required=false)]
        public string SteeringPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;AL,MO&quot;: [92298024898****],&quot;CN-SH,CN-SX,CN-SC&quot;:[92304347804****,92843536908****]}</para>
        /// </summary>
        [NameInMap("SubRegionPools")]
        [Validation(Required=false)]
        public object SubRegionPools { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
