// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQuotaReviewTasksResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the tickets. For more information, see [QuotaReviewTask](https://help.aliyun.com/document_detail/173609.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListQuotaReviewTasksResponseBodyResult> Result { get; set; }
        public class ListQuotaReviewTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// The application ID.
            /// </summary>
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public int? AppGroupId { get; set; }

            /// <summary>
            /// The application name.
            /// </summary>
            [NameInMap("appGroupName")]
            [Validation(Required=false)]
            public string AppGroupName { get; set; }

            /// <summary>
            /// The application type.
            /// </summary>
            [NameInMap("appGroupType")]
            [Validation(Required=false)]
            public string AppGroupType { get; set; }

            /// <summary>
            /// Indicates whether the ticket is approved.
            /// </summary>
            [NameInMap("approved")]
            [Validation(Required=false)]
            public bool? Approved { get; set; }

            /// <summary>
            /// Indicates whether the application is available.
            /// </summary>
            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            /// <summary>
            /// The time when the ticket was created.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the ticket was last updated.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ticket ID.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// The computing resource quota that is applied for.
            /// </summary>
            [NameInMap("newComputeResource")]
            [Validation(Required=false)]
            public int? NewComputeResource { get; set; }

            /// <summary>
            /// The storage capacity quota that is applied for.
            /// </summary>
            [NameInMap("newSocSize")]
            [Validation(Required=false)]
            public int? NewSocSize { get; set; }

            /// <summary>
            /// The application specifications that are applied for.
            /// </summary>
            [NameInMap("newSpec")]
            [Validation(Required=false)]
            public string NewSpec { get; set; }

            /// <summary>
            /// The original quota of computing resources.
            /// </summary>
            [NameInMap("oldComputeResource")]
            [Validation(Required=false)]
            public int? OldComputeResource { get; set; }

            /// <summary>
            /// The original quota of storage capacity.
            /// </summary>
            [NameInMap("oldDocSize")]
            [Validation(Required=false)]
            public int? OldDocSize { get; set; }

            /// <summary>
            /// The original specifications of the application.
            /// </summary>
            [NameInMap("oldSpec")]
            [Validation(Required=false)]
            public string OldSpec { get; set; }

            /// <summary>
            /// Indicates whether the ticket is pending.
            /// </summary>
            [NameInMap("pending")]
            [Validation(Required=false)]
            public bool? Pending { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
