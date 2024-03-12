// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEnrolledAccountsResponseBody : TeaModel {
        /// <summary>
        /// The accounts.
        /// </summary>
        [NameInMap("EnrolledAccounts")]
        [Validation(Required=false)]
        public List<ListEnrolledAccountsResponseBodyEnrolledAccounts> EnrolledAccounts { get; set; }
        public class ListEnrolledAccountsResponseBodyEnrolledAccounts : TeaModel {
            /// <summary>
            /// The account ID.
            /// </summary>
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

            /// <summary>
            /// The baseline ID.
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public string BaselineId { get; set; }

            /// <summary>
            /// The time at which the account was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The display name of the account.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The ID of the parent folder.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// The ID of the billing account.
            /// </summary>
            [NameInMap("PayerAccountUid")]
            [Validation(Required=false)]
            public long? PayerAccountUid { get; set; }

            /// <summary>
            /// The creation status of the account. Valid values:
            /// 
            /// *   Pending: The account is waiting to be created.
            /// *   Running: The account is being created.
            /// *   Finished: The account is created.
            /// *   Failed: The account failed to be created.
            /// *   Scheduling: The account is being scheduled.
            /// *   ScheduleFailed: The account failed to be scheduled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the information about the account was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
