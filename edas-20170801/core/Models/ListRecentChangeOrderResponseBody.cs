// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRecentChangeOrderResponseBody : TeaModel {
        /// <summary>
        /// The information about change processes.
        /// </summary>
        [NameInMap("ChangeOrderList")]
        [Validation(Required=false)]
        public ListRecentChangeOrderResponseBodyChangeOrderList ChangeOrderList { get; set; }
        public class ListRecentChangeOrderResponseBodyChangeOrderList : TeaModel {
            [NameInMap("ChangeOrder")]
            [Validation(Required=false)]
            public List<ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder> ChangeOrder { get; set; }
            public class ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The number of batches for the change. Valid values: 1 to 5.
                /// </summary>
                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                /// <summary>
                /// The way in which the next batch is triggered during a phased release. Valid values:
                /// 
                /// *   Automatic
                /// *   Manual
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// The description of the change process.
                /// </summary>
                [NameInMap("ChangeOrderDescription")]
                [Validation(Required=false)]
                public string ChangeOrderDescription { get; set; }

                /// <summary>
                /// The unique ID of the change process.
                /// </summary>
                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// The type of the change process.
                /// </summary>
                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                /// <summary>
                /// The type of the change process.
                /// </summary>
                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                /// <summary>
                /// The time when the change process was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The user who created the change process.
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// The time when the change process ended.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The ID of the application instance group on which the change was performed.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The source of the change. Valid values:
                /// 
                /// *   console: the Enterprise Distributed Application Service (EDAS) console
                /// *   pop: the POP API or tool
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The state of the change process. Valid values:
                /// 
                /// *   0: ready to start execution
                /// *   1: in progress
                /// *   2: successful
                /// *   3: failed
                /// *   6: terminated
                /// *   8: waiting for manual confirmation (You can see the state when you manually confirm the execution of the next batch of the change.)
                /// *   9: waiting for automatic execution
                /// *   10: failed due to a system error
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The ID of the user who created the change process.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
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

    }

}
