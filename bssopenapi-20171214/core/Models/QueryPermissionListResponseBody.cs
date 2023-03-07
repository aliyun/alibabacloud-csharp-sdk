// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPermissionListResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPermissionListResponseBodyData Data { get; set; }
        public class QueryPermissionListResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the relationship expired. If no value is returned, the relationship is still valid.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The ID of the management account.
            /// </summary>
            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public long? MasterId { get; set; }

            /// <summary>
            /// The ID of the member.
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// The list of permissions.
            /// </summary>
            [NameInMap("PermissionList")]
            [Validation(Required=false)]
            public List<QueryPermissionListResponseBodyDataPermissionList> PermissionList { get; set; }
            public class QueryPermissionListResponseBodyDataPermissionList : TeaModel {
                /// <summary>
                /// The time when the permission expired. If no value is returned, the permission is still valid. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the permission expired at 20:00:00 on May 23, 2016 (UTC+8).
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The code of the permission.
                /// </summary>
                [NameInMap("PermissionCode")]
                [Validation(Required=false)]
                public string PermissionCode { get; set; }

                /// <summary>
                /// The name of the permission.
                /// </summary>
                [NameInMap("PermissionName")]
                [Validation(Required=false)]
                public string PermissionName { get; set; }

                /// <summary>
                /// The time when the permission took effect. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the permission took effect at 20:00:00 on May 23, 2016 (UTC+8).
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The type of the relationship. Valid values: FinancialManagement and FinancialTrusteeship.
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// The time when the relationship was established. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the relationship was established at 20:00:00 on May 23, 2016 (UTC+8).
            /// </summary>
            [NameInMap("SetupTime")]
            [Validation(Required=false)]
            public string SetupTime { get; set; }

            /// <summary>
            /// The time when the relationship took effect. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the relationship took effect at 20:00:00 on May 23, 2016 (UTC+8).
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the relationship. For more information about valid values of this parameter, see the enumeration values of the RelationshipStatusEnum type in the following table.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
