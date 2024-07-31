// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgWhiteListQueryListResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public DsgWhiteListQueryListResponseBodyPageData PageData { get; set; }
        public class DsgWhiteListQueryListResponseBodyPageData : TeaModel {
            /// <summary>
            /// A collection of whitelists.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DsgWhiteListQueryListResponseBodyPageDataData> Data { get; set; }
            public class DsgWhiteListQueryListResponseBodyPageDataData : TeaModel {
                /// <summary>
                /// The expiration time of the data masking whitelist cannot be earlier than the time when the data masking whitelist takes effect. Unit: days.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The time when the whitelist was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the whitelist was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the data masking whitelist.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ID of the data masking rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// The ID of the level-2 data masking scenario.
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public long? SceneId { get; set; }

                /// <summary>
                /// The time when the data masking whitelist takes effect cannot be earlier than the current time. Unit: days.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The sensitive field type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// A collection of user group names.
                /// </summary>
                [NameInMap("UserGroups")]
                [Validation(Required=false)]
                public List<string> UserGroups { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of data masking whitelists.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
