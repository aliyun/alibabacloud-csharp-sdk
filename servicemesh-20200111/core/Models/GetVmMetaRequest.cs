// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmMetaRequest : TeaModel {
        /// <summary>
        /// <para>The name of the namespace. This parameter is valid only after you set the Namespace and the ServiceAccount parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The service account. This parameter is valid only after you set the Namespace and the ServiceAccount parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http-sa</para>
        /// </summary>
        [NameInMap("ServiceAccount")]
        [Validation(Required=false)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce51a7de4a5144db88a864ed91****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The trusted domain. Default value: cluster.local. This parameter is valid only after you set the Namespace and the ServiceAccount parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("TrustDomain")]
        [Validation(Required=false)]
        public string TrustDomain { get; set; }

    }

}
