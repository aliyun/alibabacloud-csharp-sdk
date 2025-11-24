// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class RevokeKubeconfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The new kubeconfig file generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1 clusters: - cluster:     server: <a href="https://121.**.**.**:6443">https://121.**.**.**:6443</a>     certificate-authority-data: *****   name: kubernetes contexts: - context:     cluster: kubernetes     user: &quot;<em><b><b>&quot;   name: ***** current-context: ***** kind: Config preferences: {} users: - name: &quot;</b></b></em>&quot;   user:     client-certificate-data: *****     client-key-data: *****</para>
        /// </summary>
        [NameInMap("Kubeconfig")]
        [Validation(Required=false)]
        public string Kubeconfig { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CF71C8B-79DD-150F-929E-267C51C5E311</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
