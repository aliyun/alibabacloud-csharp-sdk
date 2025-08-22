// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateRegistryNamespaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>iac</para>
        /// </summary>
        [NameInMap("namespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B4672AE3-C313-5B7A-BB24-45345570D398</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
