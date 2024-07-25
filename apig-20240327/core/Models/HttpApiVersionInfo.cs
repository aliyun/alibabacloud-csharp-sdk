// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiVersionInfo : TeaModel {
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("headerName")]
        [Validation(Required=false)]
        public string HeaderName { get; set; }

        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        [NameInMap("scheme")]
        [Validation(Required=false)]
        public string Scheme { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
