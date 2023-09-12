// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FuzzyQueryResponseBody : TeaModel {
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalHits")]
        [Validation(Required=false)]
        public long? TotalHits { get; set; }

    }

}
