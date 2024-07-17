// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListLogsResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// ListResult
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListLogsResponseBodyResult Result { get; set; }
        public class ListLogsResponseBodyResult : TeaModel {
            /// <summary>
            /// The result.
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<object> Result { get; set; }

            /// <summary>
            /// The total number of entries returned
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
