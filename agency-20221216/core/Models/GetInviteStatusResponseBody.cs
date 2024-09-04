// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetInviteStatusResponseBody : TeaModel {
        /// <summary>
        /// Status Code. Error Code:
        /// 
        /// - 3057 InviteId is empty
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInviteStatusResponseBodyData Data { get; set; }
        public class GetInviteStatusResponseBodyData : TeaModel {
            [NameInMap("InviteStatus")]
            [Validation(Required=false)]
            public List<GetInviteStatusResponseBodyDataInviteStatus> InviteStatus { get; set; }
            public class GetInviteStatusResponseBodyDataInviteStatus : TeaModel {
                /// <summary>
                /// Result Code. Value Range:
                /// *   200 OK
                /// *   1109 system error
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// List of Invitation Status result
                /// </summary>
                [NameInMap("InviteStatusList")]
                [Validation(Required=false)]
                public GetInviteStatusResponseBodyDataInviteStatusInviteStatusList InviteStatusList { get; set; }
                public class GetInviteStatusResponseBodyDataInviteStatusInviteStatusList : TeaModel {
                    /// <summary>
                    /// The time that Distribution Customer successfully associated with Distributor.</br>
                    /// This value will be empty if there is no existing association.
                    /// </summary>
                    [NameInMap("AssociationSuccessTime")]
                    [Validation(Required=false)]
                    public string AssociationSuccessTime { get; set; }

                    /// <summary>
                    /// Distribution Customer\\"s CID
                    /// </summary>
                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public long? Cid { get; set; }

                    /// <summary>
                    /// The time of email been sent out.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// The parent organization ID.
                    /// </summary>
                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    /// <summary>
                    /// Invitation Status:
                    /// * 0 No visit on registration URL
                    /// * 1 Successful Registration
                    /// * 2 Unsuccessful Registration
                    /// * 3 Registration URL have been visited, but no submitted sheet/ticket.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// Account Type:
                    /// - 1 Agency\\"s End User
                    /// - 2 Reseller\\"s End User
                    /// - 5 T2 Reseller Partner
                    /// </summary>
                    [NameInMap("SubAccountType")]
                    [Validation(Required=false)]
                    public string SubAccountType { get; set; }

                    /// <summary>
                    /// Distribution Customer\\"s UID
                    /// </summary>
                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

                /// <summary>
                /// The message returned.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Request ID, Alibaba Cloud will track errors with this.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
