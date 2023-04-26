// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAuditHistoryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Histories")]
        [Validation(Required=false)]
        public List<GetAuditHistoryResponseBodyHistories> Histories { get; set; }
        public class GetAuditHistoryResponseBodyHistories : TeaModel {
            [NameInMap("Auditor")]
            [Validation(Required=false)]
            public string Auditor { get; set; }

            /// <summary>
            /// Queries the manual review history.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The manual review result. Valid values:
            /// 
            /// - **Normal**: The video can be played.
            /// - **Blocked**: The video is blocked.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The time when the review record was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The review comments, which are provided by the reviewer.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The reviewer.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The sorting rule of the results. Valid values:
        /// 
        /// *   **CreationTime:Desc**: sorts the results based on the creation time in descending order. This is the default value.
        /// *   **CreationTime:Asc**: sorts the results based on the creation time in ascending order.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
