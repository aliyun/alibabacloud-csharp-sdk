// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAliasesResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// List
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAliasesResponseBodyResult> Result { get; set; }
        public class ListAliasesResponseBodyResult : TeaModel {
            /// <summary>
            /// alias name
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// index name
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public string Index { get; set; }

        }

    }

}
