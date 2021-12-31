// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GenerateMergedTableResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GenerateMergedTableResponseBodyResult Result { get; set; }
        public class GenerateMergedTableResponseBodyResult : TeaModel {
            [NameInMap("fromTable")]
            [Validation(Required=false)]
            public Dictionary<string, string> FromTable { get; set; }
            [NameInMap("mergeTable")]
            [Validation(Required=false)]
            public Dictionary<string, string> MergeTable { get; set; }
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }
        };

    }

}
