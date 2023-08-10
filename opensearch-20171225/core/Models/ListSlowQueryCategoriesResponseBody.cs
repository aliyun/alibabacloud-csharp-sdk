// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSlowQueryCategoriesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSlowQueryCategoriesResponseBodyResult Result { get; set; }
        public class ListSlowQueryCategoriesResponseBodyResult : TeaModel {
            /// <summary>
            /// The status of the analysis. Valid values:
            /// 
            /// *   PENDING: preparing
            /// *   SUCCESS: succeeded
            /// *   RUNNING: running
            /// *   FAILED: failed
            /// *   N/A: unknown
            /// </summary>
            [NameInMap("analyzeStatus")]
            [Validation(Required=false)]
            public string AnalyzeStatus { get; set; }

            /// <summary>
            /// The timestamp that indicates the end of the time range to query.
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// The timestamp that indicates the beginning of the time range to query.
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public int? Start { get; set; }

        }

    }

}
