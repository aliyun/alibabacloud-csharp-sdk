// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class RevokeKubeconfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the kubeconfig file for private access.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: returns the kubeconfig file for private access.</description></item>
        /// <item><description><c>false</c>: returns the kubeconfig file for public access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the ASM instance for which you want to revoke its kubeconfig file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf08a11940e8c46c48bc791fcdb3****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
