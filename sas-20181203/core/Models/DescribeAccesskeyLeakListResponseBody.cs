// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccesskeyLeakListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about AccessKey pair leaks.
        /// </summary>
        [NameInMap("AccessKeyLeakList")]
        [Validation(Required=false)]
        public List<DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList> AccessKeyLeakList { get; set; }
        public class DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList : TeaModel {
            /// <summary>
            /// The ID of the AccessKey pair that is leaked.
            /// </summary>
            [NameInMap("AccesskeyId")]
            [Validation(Required=false)]
            public string AccesskeyId { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud account that is affected.
            /// </summary>
            [NameInMap("AliUserName")]
            [Validation(Required=false)]
            public string AliUserName { get; set; }

            /// <summary>
            /// The platform to which the asset belongs. The value is fixed as **Cloud platform**.
            /// </summary>
            [NameInMap("Asset")]
            [Validation(Required=false)]
            public string Asset { get; set; }

            /// <summary>
            /// The time when the AccessKey pair leak is handled.
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public string DealTime { get; set; }

            /// <summary>
            /// The method to handle the AccessKey pair leak. Valid values:
            /// 
            /// *   **pending**: The AccessKey pair leak is unhandled.
            /// *   **manual**: The AccessKey pair leak is manually handled.
            /// *   **disable**: The AccessKey pair leak is disabled.
            /// *   **add-whitelist**: The AccessKey pair leak is added to the whitelist.
            /// </summary>
            [NameInMap("DealType")]
            [Validation(Required=false)]
            public string DealType { get; set; }

            /// <summary>
            /// The time when the AccessKey pair leak is first detected. The value of this parameter is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The primary key ID of the database.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether the AccessKey pair leak is handled. Valid values:
            /// 
            /// *   **pending**: unhandled
            /// *   **dealed**: handled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the leak. The value is fixed as **AccessKey**.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The URL of the platform on which the AccessKey pair leak is detected.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// The type of the account to which the leaked AccessKey pair belongs. Valid values:
            /// 
            /// *   **master**: Alibaba Cloud account
            /// *   **ram**: RAM user
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// The number of AccessKey pair leaks that are unhandled.
        /// </summary>
        [NameInMap("AkLeakCount")]
        [Validation(Required=false)]
        public int? AkLeakCount { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("GmtLast")]
        [Validation(Required=false)]
        public long? GmtLast { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of AccessKey pair leaks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
