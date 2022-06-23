// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlRequest : TeaModel {
        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
