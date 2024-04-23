// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetStoreViewIndexResponseBody : TeaModel {
        [NameInMap("indexes")]
        [Validation(Required=false)]
        public List<GetStoreViewIndexResponseBodyIndexes> Indexes { get; set; }
        public class GetStoreViewIndexResponseBodyIndexes : TeaModel {
            [NameInMap("index")]
            [Validation(Required=false)]
            public Index Index { get; set; }

            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

        }

    }

}
