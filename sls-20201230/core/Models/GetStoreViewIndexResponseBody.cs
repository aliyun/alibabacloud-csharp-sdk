// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetStoreViewIndexResponseBody : TeaModel {
        /// <summary>
        /// The index configurations.
        /// </summary>
        [NameInMap("indexes")]
        [Validation(Required=false)]
        public List<GetStoreViewIndexResponseBodyIndexes> Indexes { get; set; }
        public class GetStoreViewIndexResponseBodyIndexes : TeaModel {
            /// <summary>
            /// The index configurations of the Logstore.
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public Index Index { get; set; }

            /// <summary>
            /// The name of the Logstore.
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// The name of the project to which the Logstore belongs.
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

        }

    }

}
