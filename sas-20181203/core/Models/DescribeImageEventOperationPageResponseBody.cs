// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageEventOperationPageResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageEventOperationPageResponseBodyData Data { get; set; }
        public class DescribeImageEventOperationPageResponseBodyData : TeaModel {
            /// <summary>
            /// The alert handling rules.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageEventOperationPageResponseBodyDataList> List { get; set; }
            public class DescribeImageEventOperationPageResponseBodyDataList : TeaModel {
                /// <summary>
                /// The rule conditions. The value is in the JSON format. Valid values of keys:
                /// 
                /// *   **condition**: the matching condition.
                /// *   **type**: the matching type.
                /// *   **value**: the matching value.
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public string Conditions { get; set; }

                /// <summary>
                /// The keyword of the alert item.
                /// </summary>
                [NameInMap("EventKey")]
                [Validation(Required=false)]
                public string EventKey { get; set; }

                /// <summary>
                /// The name of the alert item.
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// The alert type.
                /// 
                /// *   Only **sensitiveFile** may be returned.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The primary key of the alert handling rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The operation code.
                /// 
                /// *   Only **whitelist** may be returned, which means that the alert item is added to the whitelist.
                /// </summary>
                [NameInMap("OperationCode")]
                [Validation(Required=false)]
                public string OperationCode { get; set; }

                /// <summary>
                /// The application scope of the rule. The value is in the JSON format. Valid values of keys:
                /// 
                /// *   **type**
                /// *   **value**
                /// </summary>
                [NameInMap("Scenarios")]
                [Validation(Required=false)]
                public string Scenarios { get; set; }

            }

            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageEventOperationPageResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageEventOperationPageResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The page number.
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
                public int? TotalCount { get; set; }

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
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
