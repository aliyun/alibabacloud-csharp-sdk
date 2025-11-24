// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmAppMeshInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce51a7de4a5144db88a864****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
