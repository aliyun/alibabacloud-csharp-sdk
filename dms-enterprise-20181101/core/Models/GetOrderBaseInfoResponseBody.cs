// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOrderBaseInfoResponseBody : TeaModel {
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
        /// The basic information about the ticket.
        /// </summary>
        [NameInMap("OrderBaseInfo")]
        [Validation(Required=false)]
        public GetOrderBaseInfoResponseBodyOrderBaseInfo OrderBaseInfo { get; set; }
        public class GetOrderBaseInfoResponseBodyOrderBaseInfo : TeaModel {
            /// <summary>
            /// The Key of the ticket attachment. This information is returned only when an attachment is uploaded when a ticket is created.
            /// </summary>
            [NameInMap("AttachmentKey")]
            [Validation(Required=false)]
            public string AttachmentKey { get; set; }

            /// <summary>
            /// The remarks of the ticket.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The applicant.
            /// </summary>
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            /// <summary>
            /// The ID of the applicant. Note: The ID is different from the Alibaba Cloud account ID of the applicant.
            /// </summary>
            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public long? CommitterId { get; set; }

            /// <summary>
            /// The time when the ticket was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the ticket was last modified.
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            /// <summary>
            /// The ID of the ticket.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// The original file name of the ticket attachment. This information is returned only when an attachment is uploaded when a ticket is created.
            /// </summary>
            [NameInMap("OriginAttachmentName")]
            [Validation(Required=false)]
            public string OriginAttachmentName { get; set; }

            /// <summary>
            /// The type of the ticket. For more information about the value of this parameter, see the request parameters of the [CreateOrder](~~465865~~) operation.
            /// </summary>
            [NameInMap("PluginType")]
            [Validation(Required=false)]
            public string PluginType { get; set; }

            /// <summary>
            /// The IDs of the operators that are related to the ticket.
            /// </summary>
            [NameInMap("RelatedUserList")]
            [Validation(Required=false)]
            public GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserList RelatedUserList { get; set; }
            public class GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserList : TeaModel {
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

            /// <summary>
            /// The nicknames of the operators that are related to the ticket.
            /// </summary>
            [NameInMap("RelatedUserNickList")]
            [Validation(Required=false)]
            public GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserNickList RelatedUserNickList { get; set; }
            public class GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserNickList : TeaModel {
                [NameInMap("UserNicks")]
                [Validation(Required=false)]
                public List<string> UserNicks { get; set; }

            }

            /// <summary>
            /// The status code of the ticket. Valid values:
            /// 
            /// *   **new**: The ticket is created.
            /// *   **toaudit**: The ticket is being reviewed.
            /// *   **Approved**: The ticket is approved.
            /// *   **reject**: The ticket is rejected.
            /// *   **processing**: The ticket is being executed.
            /// *   **success**: The ticket is executed.
            /// *   **closed**: The ticket is closed.
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// The description of the status.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The ID of the approval process.
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

            /// <summary>
            /// The description of the approval process.
            /// </summary>
            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

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
