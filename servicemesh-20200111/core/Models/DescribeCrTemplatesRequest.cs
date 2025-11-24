// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCrTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The version of Istio used by the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.9.7.31-g24cdcb43-aliyun</para>
        /// </summary>
        [NameInMap("IstioVersion")]
        [Validation(Required=false)]
        public string IstioVersion { get; set; }

        /// <summary>
        /// <para>The type of Istio resource whose common YAML templates you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AuthorizationPolicy</description></item>
        /// <item><description>RequestAuthentication</description></item>
        /// <item><description>PeerAuthentication</description></item>
        /// <item><description>WorkloadGroup</description></item>
        /// <item><description>WorkloadEntry</description></item>
        /// <item><description>Sidecar</description></item>
        /// <item><description>EnvoyFilter</description></item>
        /// <item><description>ServiceEntry</description></item>
        /// <item><description>Gateway</description></item>
        /// <item><description>DestinationRule</description></item>
        /// <item><description>VirtualService</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VirtualService</para>
        /// </summary>
        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

    }

}
