// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetAccountDeletionStatusResponseBody : TeaModel {
        /// <summary>
        /// The deletion status of the member.
        /// </summary>
        [NameInMap("RdAccountDeletionStatus")]
        [Validation(Required=false)]
        public GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus RdAccountDeletionStatus { get; set; }
        public class GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account ID of the member.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The start time of the deletion.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The end time of the deletion.
            /// </summary>
            [NameInMap("DeletionTime")]
            [Validation(Required=false)]
            public string DeletionTime { get; set; }

            /// <summary>
            /// The type of the deletion. Valid values:
            /// 
            /// *   0: direct deletion. If the member does not have pay-as-you-go resources that are purchased within the previous 30 days, the system directly deletes the member.
            /// *   1: deletion with a silence period. If the member has pay-as-you-go resources that are purchased within the previous 30 days, the member enters a silence period of 45 days. The system starts to delete the member until the silence period ends. For more information about the silence period, see [What is the silence period for member deletion?](~~446079~~)
            /// </summary>
            [NameInMap("DeletionType")]
            [Validation(Required=false)]
            public string DeletionType { get; set; }

            /// <summary>
            /// The reasons why the member fails to be deleted.
            /// </summary>
            [NameInMap("FailReasonList")]
            [Validation(Required=false)]
            public List<GetAccountDeletionStatusResponseBodyRdAccountDeletionStatusFailReasonList> FailReasonList { get; set; }
            public class GetAccountDeletionStatusResponseBodyRdAccountDeletionStatusFailReasonList : TeaModel {
                /// <summary>
                /// The description of the check item.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the cloud service to which the check item belongs.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The status. Valid values:
            /// 
            /// *   Success: The member is deleted.
            /// *   Checking: A deletion check is being performed for the member.
            /// *   Deleting: The member is being deleted.
            /// *   CheckFailed: The deletion check for the member fails.
            /// *   DeleteFailed: The member fails to be deleted.
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
