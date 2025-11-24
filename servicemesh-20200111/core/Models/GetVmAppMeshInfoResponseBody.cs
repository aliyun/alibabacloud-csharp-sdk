// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmAppMeshInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>...</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9522f7c9-63a1-4603-b850-37d12a****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
