// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeUploadInfoResponseBody : TeaModel {
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        [NameInMap("Folder")]
        [Validation(Required=false)]
        public string Folder { get; set; }

        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

    }

}
