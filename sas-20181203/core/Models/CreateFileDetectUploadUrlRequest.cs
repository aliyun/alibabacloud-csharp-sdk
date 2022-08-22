// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlRequest : TeaModel {
        [NameInMap("HashKeyContextList")]
        [Validation(Required=false)]
        public List<CreateFileDetectUploadUrlRequestHashKeyContextList> HashKeyContextList { get; set; }
        public class CreateFileDetectUploadUrlRequestHashKeyContextList : TeaModel {
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

        }

        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
