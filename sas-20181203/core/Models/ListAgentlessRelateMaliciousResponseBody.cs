// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessRelateMaliciousResponseBody : TeaModel {
        /// <summary>
        /// The list of hosts that are associated with the risk.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAgentlessRelateMaliciousResponseBodyList> List { get; set; }
        public class ListAgentlessRelateMaliciousResponseBodyList : TeaModel {
            /// <summary>
            /// The file path.
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// The timestamp when the first scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstScanTimestamp")]
            [Validation(Required=false)]
            public long? FirstScanTimestamp { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The timestamp when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LatestScanTimestamp")]
            [Validation(Required=false)]
            public long? LatestScanTimestamp { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAgentlessRelateMaliciousResponseBodyPageInfo PageInfo { get; set; }
        public class ListAgentlessRelateMaliciousResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
