// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOpaClusterStrategyNewResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The rules.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListOpaClusterStrategyNewResponseBodyList> List { get; set; }
        public class ListOpaClusterStrategyNewResponseBodyList : TeaModel {
            /// <summary>
            /// The action of the rule. Valid values:
            /// 
            /// *   **1**: trigger alerts
            /// *   **2**: block
            /// *   **3**: allow
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public int? Action { get; set; }

            /// <summary>
            /// The number of clusters on which the rule takes effect.
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// The clusters on which the rule takes effect.
            /// </summary>
            [NameInMap("ClusterIdList")]
            [Validation(Required=false)]
            public List<string> ClusterIdList { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The image names.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            /// <summary>
            /// The tags that are added to the container.
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            /// <summary>
            /// Indicates whether the rule supports malicious Internet images. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("MaliciousImage")]
            [Validation(Required=false)]
            public bool? MaliciousImage { get; set; }

            /// <summary>
            /// The rule ID.
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// The rule name.
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// Indicates whether the rule supports unscanned images. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("UnScanedImage")]
            [Validation(Required=false)]
            public bool? UnScanedImage { get; set; }

        }

        /// <summary>
        /// The message that shows the export task result. The value is fixed as **success**, which indicates that the export task is successful.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOpaClusterStrategyNewResponseBodyPageInfo PageInfo { get; set; }
        public class ListOpaClusterStrategyNewResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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
