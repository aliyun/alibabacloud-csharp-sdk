// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ModifyApiServerEipResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-bp1adu9jegmxnaoq****</para>
        /// </summary>
        [NameInMap("ApiServerEipId")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// <para>The type of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>UnBindEip</c>: disassociates an EIP from the API server.</description></item>
        /// <item><description><c>BindEip</c>: associates an EIP with the API server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BindEip</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud Service Mesh (ASM) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
