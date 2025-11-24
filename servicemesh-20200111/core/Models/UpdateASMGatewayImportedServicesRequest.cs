// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateASMGatewayImportedServicesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the ASM gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingressgateway</para>
        /// </summary>
        [NameInMap("ASMGatewayName")]
        [Validation(Required=false)]
        public string ASMGatewayName { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The names of the services. Separate multiple service names with commas (,). Example: reviews,sleep.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reviews,sleep</para>
        /// </summary>
        [NameInMap("ServiceNames")]
        [Validation(Required=false)]
        public string ServiceNames { get; set; }

        /// <summary>
        /// <para>The namespace in which the service resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ServiceNamespace")]
        [Validation(Required=false)]
        public string ServiceNamespace { get; set; }

    }

}
