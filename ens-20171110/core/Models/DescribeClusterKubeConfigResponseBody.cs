// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterKubeConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c8f0377146d104687ac562eef9403****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1
        /// clusters:</para>
        /// <list type="bullet">
        /// <item><description>cluster:
        ///   certificate-authority-data:***
        ///   server: https://****:6443
        /// name: kubernetes
        /// contexts:</description></item>
        /// <item><description>context:
        ///   cluster: kubernetes
        ///   user: &quot;2580306074811*****&quot;
        /// name: 258*******
        /// kind: Config
        /// users:</description></item>
        /// <item><description>name: &quot;2580306074811*****&quot;
        /// user:
        ///   client-certificate-data:***
        ///   client-key-data: ***</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Kubeconfig")]
        [Validation(Required=false)]
        public string Kubeconfig { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
