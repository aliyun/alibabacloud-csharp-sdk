// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUpgradeVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11fd0027-c27e-41bb-a565-75583054****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version information.</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public DescribeUpgradeVersionResponseBodyVersion Version { get; set; }
        public class DescribeUpgradeVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// <para>The version of the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.17.2.42-gf7619883-aliyun</para>
            /// </summary>
            [NameInMap("IstioOperatorVersion")]
            [Validation(Required=false)]
            public string IstioOperatorVersion { get; set; }

            /// <summary>
            /// <para>The Istio version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.17.2</para>
            /// </summary>
            [NameInMap("IstioVersion")]
            [Validation(Required=false)]
            public string IstioVersion { get; set; }

            /// <summary>
            /// <para>The Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.24.6-aliyun.1</para>
            /// </summary>
            [NameInMap("KubernetesVersion")]
            [Validation(Required=false)]
            public string KubernetesVersion { get; set; }

        }

    }

}
