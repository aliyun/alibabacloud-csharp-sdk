// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSlowQueryQueriesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSlowQueryQueriesResponseBodyResult Result { get; set; }
        public class ListSlowQueryQueriesResponseBodyResult : TeaModel {
            /// <summary>
            /// The content of the optimization suggestion for the query.
            /// </summary>
            [NameInMap("appQuery")]
            [Validation(Required=false)]
            public string AppQuery { get; set; }

            /// <summary>
            /// The end of the time range that was queried.
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// The ID of the optimization suggestion.
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// The beginning of the time range that was queried.
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public int? Start { get; set; }

        }

    }

}
