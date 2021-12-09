// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetObjectRequest : TeaModel {
        [NameInMap("response-cache-control")]
        [Validation(Required=false)]
        public string ResponseCacheControl { get; set; }

        [NameInMap("response-content-disposition")]
        [Validation(Required=false)]
        public string ResponseContentDisposition { get; set; }

        [NameInMap("response-content-encoding")]
        [Validation(Required=false)]
        public string ResponseContentEncoding { get; set; }

        [NameInMap("response-content-language")]
        [Validation(Required=false)]
        public string ResponseContentLanguage { get; set; }

        [NameInMap("response-content-type")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

        [NameInMap("response-expires")]
        [Validation(Required=false)]
        public string ResponseExpires { get; set; }

    }

}
