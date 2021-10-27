// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeUploadInfoResponse : TeaModel {
        [NameInMap("Accessid")]
        [Validation(Required=true)]
        public string Accessid { get; set; }

        [NameInMap("Expire")]
        [Validation(Required=true)]
        public long? Expire { get; set; }

        [NameInMap("Folder")]
        [Validation(Required=true)]
        public string Folder { get; set; }

        [NameInMap("Host")]
        [Validation(Required=true)]
        public string Host { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=true)]
        public string Policy { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=true)]
        public string Signature { get; set; }

    }

}
