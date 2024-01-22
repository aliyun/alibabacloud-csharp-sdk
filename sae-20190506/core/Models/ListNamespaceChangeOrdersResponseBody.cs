// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespaceChangeOrdersResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespaceChangeOrdersResponseBodyData Data { get; set; }
        public class ListNamespaceChangeOrdersResponseBodyData : TeaModel {
            /// <summary>
            /// The list of change orders.
            /// </summary>
            [NameInMap("ChangeOrderList")]
            [Validation(Required=false)]
            public List<ListNamespaceChangeOrdersResponseBodyDataChangeOrderList> ChangeOrderList { get; set; }
            public class ListNamespaceChangeOrdersResponseBodyDataChangeOrderList : TeaModel {
                /// <summary>
                /// The number of release batches.
                /// </summary>
                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                /// <summary>
                /// The mode in which the release batches are determined. Valid values:
                /// 
                /// *   **auto**: SAE automatically determines the release batches.
                /// *   **manual**: You must manually determine the release batches.
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// The ID of the change order.
                /// </summary>
                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// The type of the change order, which corresponds the **CoTypeCode** parameter.
                /// </summary>
                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                /// <summary>
                /// The code of the change order type. Valid values:
                /// 
                /// *   **CoBatchStartApplication**: starts multiple applications concurrently.
                /// *   **CoBatchStopApplication**: stops multiple applications concurrently.
                /// </summary>
                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                /// <summary>
                /// The time when the change order was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The ID of the user who created the change order.
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// The description of the change order.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the change order was completed.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the namespace.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The information about release batches.
                /// </summary>
                [NameInMap("Pipelines")]
                [Validation(Required=false)]
                public string Pipelines { get; set; }

                /// <summary>
                /// The source of the change order.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The status of the change order. Valid values:
                /// 
                /// *   **0**: The change order is being prepared.
                /// *   **1**: The change order is being executed.
                /// *   **2**: The change order was executed.
                /// *   **3**: The change order could not be executed.
                /// *   **6**: The change order was terminated.
                /// *   **10**: The change order could not be executed due to a system exception.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of change orders.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The error code.
        /// 
        /// *   The **ErrorCode** parameter is not returned when the request succeeds.
        /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
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
        /// Indicates whether the list of change orders was obtained. Valid values:
        /// 
        /// *   **true**: indicates that the list was obtained.
        /// *   **false**: indicates that the list could not be obtained.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
