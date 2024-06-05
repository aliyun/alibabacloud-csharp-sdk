// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UCObjectInfo : TeaModel {
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        [NameInMap("object_key")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("sha1")]
        [Validation(Required=false)]
        public string Sha1 { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
