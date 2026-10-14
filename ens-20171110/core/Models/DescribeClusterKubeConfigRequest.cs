// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterKubeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is essentially required. If it is not provided, the service returns BadRequest. The target cluster must also have completed control plane deployment and certificate generation. You cannot obtain the kubeconfig for a cluster in the initial state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c8f0377146d104687ac562eef9403****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
