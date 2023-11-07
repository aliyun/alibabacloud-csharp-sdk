// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class GetOperationOssUploadPolicyResponseBody : TeaModel {
        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        [NameInMap("EncodedPolicy")]
        [Validation(Required=false)]
        public string EncodedPolicy { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("FileDir")]
        [Validation(Required=false)]
        public string FileDir { get; set; }

        /// <summary>
        /// OSS Endpoint。
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
