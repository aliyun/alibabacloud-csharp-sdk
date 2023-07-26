// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetAccountDeletionCheckResultResponseBody : TeaModel {
        /// <summary>
        /// The result of the deletion check for the member.
        /// </summary>
        [NameInMap("AccountDeletionCheckResultInfo")]
        [Validation(Required=false)]
        public GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo AccountDeletionCheckResultInfo { get; set; }
        public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo : TeaModel {
            /// <summary>
            /// The check items that you can choose to ignore for the member deletion.
            /// 
            /// > This parameter may be returned if the value of AllowDelete is true.
            /// </summary>
            [NameInMap("AbandonableChecks")]
            [Validation(Required=false)]
            public List<GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoAbandonableChecks> AbandonableChecks { get; set; }
            public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoAbandonableChecks : TeaModel {
                /// <summary>
                /// The ID of the check item.
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// The name of the cloud service to which the check item belongs.
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// The description of the check item.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// Indicates whether the member can be deleted. Valid values:
            /// 
            /// *   true: The member can be deleted.
            /// *   false: The member cannot be deleted.
            /// </summary>
            [NameInMap("AllowDelete")]
            [Validation(Required=false)]
            public string AllowDelete { get; set; }

            /// <summary>
            /// The reasons why the member cannot be deleted.
            /// 
            /// > This parameter is returned only if the value of AllowDelete is false.
            /// </summary>
            [NameInMap("NotAllowReason")]
            [Validation(Required=false)]
            public List<GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoNotAllowReason> NotAllowReason { get; set; }
            public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoNotAllowReason : TeaModel {
                /// <summary>
                /// The ID of the check item.
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// The name of the cloud service to which the check item belongs.
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// The description of the check item.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// The status of the check. Valid values:
            /// 
            /// *   PreCheckComplete: The check is complete.
            /// *   PreChecking: The check is in progress.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
