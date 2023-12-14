// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCustomizeRuleTestResultResponseBody : TeaModel {
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
        public ListCustomizeRuleTestResultResponseBodyData Data { get; set; }
        public class ListCustomizeRuleTestResultResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListCustomizeRuleTestResultResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListCustomizeRuleTestResultResponseBodyDataPageInfo : TeaModel {
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
            public List<ListCustomizeRuleTestResultResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListCustomizeRuleTestResultResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The description of the alert.
                /// </summary>
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                /// <summary>
                /// The alert details in the JSON format.
                /// </summary>
                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                /// <summary>
                /// The source of the alert.
                /// </summary>
                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                /// <summary>
                /// The sub-module of the source.
                /// </summary>
                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                /// <summary>
                /// The tag of the ATT\&CK attack.
                /// </summary>
                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                /// <summary>
                /// The name of the alert, which corresponds to the name of the custom rule.
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// The risk type, which indicates the alert type.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The risk level. Valid values:
                /// 
                /// *   serious: high
                /// *   suspicious: medium
                /// *   remind: low
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The log source of the rule.
                /// </summary>
                [NameInMap("LogSource")]
                [Validation(Required=false)]
                public string LogSource { get; set; }

                /// <summary>
                /// The time when the alert was recorded.
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// The log type of the rule.
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is associated with the alert in SIEM.
                /// </summary>
                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public string MainUserId { get; set; }

                /// <summary>
                /// The status of the alert data. Valid values:
                /// 
                /// *   test: business test data
                /// *   online: online data
                /// </summary>
                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public string OnlineStatus { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account within which the alert is generated.
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

                /// <summary>
                /// The UUID of the alert.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

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
