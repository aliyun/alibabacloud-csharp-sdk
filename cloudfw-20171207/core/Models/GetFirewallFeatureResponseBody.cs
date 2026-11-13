// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class GetFirewallFeatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of firewall feature statuses. This list always returns the statuses of application control and web filtering.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<GetFirewallFeatureResponseBodyFeatures> Features { get; set; }
        public class GetFirewallFeatureResponseBodyFeatures : TeaModel {
            /// <summary>
            /// <para>The feature name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ApplicationControl</b>: Application control.</description></item>
            /// <item><description><b>WebFilter</b>: Web filtering.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ApplicationControl</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>The activation status of the feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Enabled.</description></item>
            /// <item><description><b>Disable</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
