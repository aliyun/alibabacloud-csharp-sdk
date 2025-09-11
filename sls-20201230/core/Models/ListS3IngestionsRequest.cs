// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListS3IngestionsRequest : TeaModel {
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public string Size { get; set; }

    }

}
