// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPhysicalConnectionFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Express Connect circuit features.</para>
        /// </summary>
        [NameInMap("PhysicalConnectionFeatures")]
        [Validation(Required=false)]
        public List<ListPhysicalConnectionFeaturesResponseBodyPhysicalConnectionFeatures> PhysicalConnectionFeatures { get; set; }
        public class ListPhysicalConnectionFeaturesResponseBodyPhysicalConnectionFeatures : TeaModel {
            /// <summary>
            /// <para>The feature key of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SubifRateLimit</b>: subinterface throttling</description></item>
            /// <item><description><b>BFD Capability</b>: Bidirectional Forwarding Detection (BFD)</description></item>
            /// <item><description><b>DualStack</b>: Dual stack</description></item>
            /// <item><description><b>CEN</b>: When a virtual border router (VBR) is attached to a Cloud Enterprise Network (CEN) instance and BGP routes are advertised on the user side, attributes such as <b>as-path</b> and <b>community</b> are carried.</description></item>
            /// <item><description><b>CENv6</b>: When a VBR is attached to an IPv6 CEN instance and BGP routes are advertised on the user side, attributes such as <b>as-path</b> and <b>community</b> are carried.</description></item>
            /// <item><description><b>QOS</b>: The device supports configuring QOS policies on physical ports.</description></item>
            /// <item><description><b>MSHA</b>: The device supports fast switching groups between two VBRs.</description></item>
            /// <item><description><b>MULTI_MS_HA</b>: The device supports a maximum of eight VBRs that can be added to the same ECR.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SubifRateLimit</para>
            /// </summary>
            [NameInMap("FeatureKey")]
            [Validation(Required=false)]
            public string FeatureKey { get; set; }

            /// <summary>
            /// <para>The feature value of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OK</b>: Supported</description></item>
            /// <item><description><b>NOK</b>: Not supported</description></item>
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
