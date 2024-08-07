// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAutomateResponseConfigsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAutomateResponseConfigsResponseBodyData Data { get; set; }
        public class ListAutomateResponseConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListAutomateResponseConfigsResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListAutomateResponseConfigsResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The current page number.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// The total number of entries returned.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The detailed data.
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListAutomateResponseConfigsResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListAutomateResponseConfigsResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The configuration of the action that is performed after the automated response rule is hit. The value is in the JSON format.
                /// </summary>
                [NameInMap("ActionConfig")]
                [Validation(Required=false)]
                public string ActionConfig { get; set; }

                /// <summary>
                /// The type of the handling action. Multiple types are separated by commas (,). Valid values:
                /// 
                /// *   **doPlaybook**: runs the playbook.
                /// *   **changeEventStatus**: changes the event status.
                /// *   **changeThreatLevel**: changes the risk level of the event.
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is associated with the rule in SIEM.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// The type of the automated response rule. Valid values:
                /// 
                /// *   **event**
                /// *   **alert**
                /// </summary>
                [NameInMap("AutoResponseType")]
                [Validation(Required=false)]
                public string AutoResponseType { get; set; }

                /// <summary>
                /// The type of the view. Valid values:
                /// 
                /// 0: the current Alibaba Cloud account
                /// 1: the global account
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public int? DataType { get; set; }

                /// <summary>
                /// The trigger condition of the automated response rule. The value is in the JSON format.
                /// </summary>
                [NameInMap("ExecutionCondition")]
                [Validation(Required=false)]
                public string ExecutionCondition { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The update time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the automated response rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the automated response rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The status of the rule. Valid values:
                /// 
                /// *   **0**: disabled.
                /// *   **100**: enabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The ID of the user who created the rule.
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
