// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class HeadObjectHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("If-Match")]
        [Validation(Required=false)]
        public string IfMatch { get; set; }

        [NameInMap("If-Modified-Since")]
        [Validation(Required=false)]
        public string IfModifiedSince { get; set; }

        [NameInMap("If-None-Match")]
        [Validation(Required=false)]
        public string IfNoneMatch { get; set; }

        [NameInMap("If-Unmodified-Since")]
        [Validation(Required=false)]
        public string IfUnmodifiedSince { get; set; }

    }

}
