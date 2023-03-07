// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRelationListResponseBody : TeaModel {
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
        public QueryRelationListResponseBodyData Data { get; set; }
        public class QueryRelationListResponseBodyData : TeaModel {
            /// <summary>
            /// The relationships.
            /// </summary>
            [NameInMap("FinancialRelationInfoList")]
            [Validation(Required=false)]
            public List<QueryRelationListResponseBodyDataFinancialRelationInfoList> FinancialRelationInfoList { get; set; }
            public class QueryRelationListResponseBodyDataFinancialRelationInfoList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The name of the account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The display name of the account.
                /// </summary>
                [NameInMap("AccountNickName")]
                [Validation(Required=false)]
                public string AccountNickName { get; set; }

                /// <summary>
                /// The type of the account. Valid values: MASTER and MEMBER.
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The time when the relationship became invalid. If no value is returned, the relationship is still valid.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The ID of the relationship.
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

                /// <summary>
                /// The type of the relationship. Valid values: FinancialManagement and FinancialTrusteeship.
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// The time when the relationship was established. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. Example: 2016-05-23T12:00:00Z.
                /// </summary>
                [NameInMap("SetupTime")]
                [Validation(Required=false)]
                public string SetupTime { get; set; }

                /// <summary>
                /// The time when the relationship became valid. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. Example: 2016-05-23T12:00:00Z.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The state of the relationship. One of the enumeration members of the RelationshipStatusEnum data type is returned.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
