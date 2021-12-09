// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InventoryEncryption : TeaModel {
        /// <summary>
        /// The container that stores the CMK used in the SSE-KMS encryption method
        /// </summary>
        [NameInMap("SSE-KMS")]
        [Validation(Required=false)]
        public SSEKMS SSEKMS { get; set; }

        /// <summary>
        /// The container that stores the information about the SSE-OSS encryption method
        /// </summary>
        [NameInMap("SSE-OSS")]
        [Validation(Required=false)]
        public SSEOSS SSEOSS { get; set; }

    }

}
