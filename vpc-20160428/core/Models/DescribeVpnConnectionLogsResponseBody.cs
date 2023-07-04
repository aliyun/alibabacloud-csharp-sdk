// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnConnectionLogsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// An array of strings.
        /// 
        /// Each item in the array is a log entry.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVpnConnectionLogsResponseBodyData Data { get; set; }
        public class DescribeVpnConnectionLogsResponseBodyData : TeaModel {
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }

        }

        /// <summary>
        /// Indicates whether the log is accurate. Valid values:
        /// 
        /// *   **true**: accurate
        /// *   **false**: inaccurate
        /// </summary>
        [NameInMap("IsCompleted")]
        [Validation(Required=false)]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
