// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListOrdersResponseBody : TeaModel {
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
        /// The details about the tickets.
        /// </summary>
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public ListOrdersResponseBodyOrders Orders { get; set; }
        public class ListOrdersResponseBodyOrders : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public List<ListOrdersResponseBodyOrdersOrder> Order { get; set; }
            public class ListOrdersResponseBodyOrdersOrder : TeaModel {
                /// <summary>
                /// The remarks of the ticket.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The user who submitted the ticket.
                /// </summary>
                [NameInMap("Committer")]
                [Validation(Required=false)]
                public string Committer { get; set; }

                /// <summary>
                /// The ID of the user who submitted the ticket.
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
                /// The type of the ticket.
                /// </summary>
                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                /// <summary>
                /// The status code of the ticket. Valid values:
                /// 
                /// *   **fail**: The ticket fails to be executed.
                /// *   **toaudit**: The ticket is waiting for approval.
                /// *   **cancel**: The ticket is cancelled.
                /// *   **processing**: The ticket is being executed.
                /// *   **approved**: The ticket is approved.
                /// *   **reject**: The ticket is rejected.
                /// *   **success**: The ticket is executed.
                /// *   **closed**: The ticket is closed.
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// The status description of the ticket.
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// - **true**: The request was successful.
        /// - **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
