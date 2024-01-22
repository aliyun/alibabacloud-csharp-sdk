// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationVersionsOutput : TeaModel {
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<Version> Versions { get; set; }

    }

}
