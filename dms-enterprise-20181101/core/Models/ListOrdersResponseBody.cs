// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListOrdersResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The time when the ticket was last modified.
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
                /// The status description of the ticket.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The type of the ticket.
                /// </summary>
                [NameInMap("Committer")]
                [Validation(Required=false)]
                public string Committer { get; set; }

                /// <summary>
                /// The ID of the ticket.
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
                /// The number of entries to return on each page.
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                /// <summary>
                /// The time condition based on which you want to query tickets. Valid values:
                /// 
                /// *   **CREATE_TIME**: the time when a ticket was created.
                /// *   **MODIFY_TIME**: the time when a ticket was last modified.
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// Queries tickets in Data Management (DMS).
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
