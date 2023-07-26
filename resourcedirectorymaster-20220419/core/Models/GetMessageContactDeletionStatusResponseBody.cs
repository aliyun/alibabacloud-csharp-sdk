// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetMessageContactDeletionStatusResponseBody : TeaModel {
        /// <summary>
        /// The deletion information of the contact.
        /// </summary>
        [NameInMap("ContactDeletionStatus")]
        [Validation(Required=false)]
        public GetMessageContactDeletionStatusResponseBodyContactDeletionStatus ContactDeletionStatus { get; set; }
        public class GetMessageContactDeletionStatusResponseBodyContactDeletionStatus : TeaModel {
            /// <summary>
            /// The ID of the contact.
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// The types of messages received by the contact.
            /// </summary>
            [NameInMap("FailReasonList")]
            [Validation(Required=false)]
            public List<GetMessageContactDeletionStatusResponseBodyContactDeletionStatusFailReasonList> FailReasonList { get; set; }
            public class GetMessageContactDeletionStatusResponseBodyContactDeletionStatusFailReasonList : TeaModel {
                /// <summary>
                /// The Alibaba Cloud account ID of the member.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The types of messages received by the contact.
                /// </summary>
                [NameInMap("MessageTypes")]
                [Validation(Required=false)]
                public List<string> MessageTypes { get; set; }

            }

            /// <summary>
            /// The deletion status of the contact. Valid values:
            /// 
            /// *   Deleting
            /// *   Failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
