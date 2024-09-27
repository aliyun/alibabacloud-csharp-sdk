// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class OssUploadCredential : TeaModel {
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("OssPolicy")]
        [Validation(Required=false)]
        public string OssPolicy { get; set; }

        [NameInMap("OssSignature")]
        [Validation(Required=false)]
        public string OssSignature { get; set; }

        [NameInMap("StsToken")]
        [Validation(Required=false)]
        public string StsToken { get; set; }

    }

}
