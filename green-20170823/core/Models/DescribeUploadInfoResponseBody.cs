// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeUploadInfoResponseBody : TeaModel {
        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        [NameInMap("Expire")]
        [Validation(Required=false)]
        public int? Expire { get; set; }

        [NameInMap("Folder")]
        [Validation(Required=false)]
        public string Folder { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
