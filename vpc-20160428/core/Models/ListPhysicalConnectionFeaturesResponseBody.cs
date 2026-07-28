// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPhysicalConnectionFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Express Connect circuit attributes.</para>
        /// </summary>
        [NameInMap("PhysicalConnectionFeatures")]
        [Validation(Required=false)]
        public List<ListPhysicalConnectionFeaturesResponseBodyPhysicalConnectionFeatures> PhysicalConnectionFeatures { get; set; }
        public class ListPhysicalConnectionFeaturesResponseBodyPhysicalConnectionFeatures : TeaModel {
            /// <summary>
            /// <para>The attribute key of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SubifRateLimit</b>: sub-interface rate limiting.</description></item>
            /// <item><description><b>BFD能力</b>: Bidirectional Forwarding Detection (BFD) capability.</description></item>
            /// <item><description><b>DualStack</b>: the capability to support both IPv4 and IPv6.</description></item>
            /// <item><description><b>CEN</b>: when a Virtual Border Router (VBR) is attached to a Cloud Enterprise Network (CEN) instance, the original route attributes such as <b>as-path</b> and <b>community</b> can be carried when advertising BGP routes to the user side.</description></item>
            /// <item><description><b>CENv6</b>: when a VBR is attached to an IPv6-enabled CEN instance, the original route attributes such as <b>as-path</b> and <b>community</b> can be carried when advertising BGP routes to the user side.</description></item>
            /// <item><description><b>QOS</b>: the device supports configuring QoS policies on physical ports.</description></item>
            /// <item><description><b>MSHA</b>: the device supports configuring a fast failover group between two VBRs.</description></item>
            /// <item><description><b>MULTI_MS_HA</b>: the device supports configuring a fast failover group among up to 8 VBRs. These VBRs must be added to the same Express Connect Router (ECR).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SubifRateLimit</para>
            /// </summary>
            [NameInMap("FeatureKey")]
            [Validation(Required=false)]
            public string FeatureKey { get; set; }

            /// <summary>
            /// <para>The attribute value of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OK</b>: Supported.</description></item>
            /// <item><description><b>NOK</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("FeatureValue")]
            [Validation(Required=false)]
            public string FeatureValue { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A599D38F-3618-18FD-9427-108FB9B5BD26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
