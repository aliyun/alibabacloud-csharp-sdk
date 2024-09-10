// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBaselineCheckWhiteRecordResponseBody : TeaModel {
        /// <summary>
        /// The whitelist rules.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListBaselineCheckWhiteRecordResponseBodyList> List { get; set; }
        public class ListBaselineCheckWhiteRecordResponseBodyList : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The description of the check item.
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// The type of the check item.
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// The display name of the check item type.
            /// </summary>
            [NameInMap("CheckTypeDisName")]
            [Validation(Required=false)]
            public string CheckTypeDisName { get; set; }

            /// <summary>
            /// The language of the content within the request and response. Default value: **zh**. Valid values:
            /// 
            /// *   **zh**: Chinese
            /// *   **en**: English
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// The reason why the check item is added to the whitelist.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The ID of the whitelist rule.
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// The data source. Valid values:
            /// 
            /// *   **default**: server
            /// *   **agentless**: agentless detection
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The object that is added to the whitelist.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The type of the assets on which the whitelist rule takes effect. Valid values:
            /// 
            /// *   **all_instance**: all servers
            /// *   **instance**: specific servers
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListBaselineCheckWhiteRecordResponseBodyPageInfo PageInfo { get; set; }
        public class ListBaselineCheckWhiteRecordResponseBodyPageInfo : TeaModel {
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

    }

}
