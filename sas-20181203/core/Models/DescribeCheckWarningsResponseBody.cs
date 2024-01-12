// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningsResponseBody : TeaModel {
        /// <summary>
        /// The information about the check item.
        /// </summary>
        [NameInMap("CheckWarnings")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningsResponseBodyCheckWarnings> CheckWarnings { get; set; }
        public class DescribeCheckWarningsResponseBodyCheckWarnings : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The ID of the alert that is triggered by the check item.
            /// </summary>
            [NameInMap("CheckWarningId")]
            [Validation(Required=false)]
            public long? CheckWarningId { get; set; }

            /// <summary>
            /// The ID of the container.
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// The name of the container.
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// The error message in the check result.
            /// </summary>
            [NameInMap("ExecErrorMessage")]
            [Validation(Required=false)]
            public string ExecErrorMessage { get; set; }

            /// <summary>
            /// Indicates whether the fix is supported. Valid values:
            /// 
            /// *   **0**: The fix is not supported.
            /// *   **1**: The fix is supported.
            /// </summary>
            [NameInMap("FixStatus")]
            [Validation(Required=false)]
            public int? FixStatus { get; set; }

            /// <summary>
            /// The name of the check item.
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// The timestamp of the latest processing of the check item risk of the machine. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastHandleTime")]
            [Validation(Required=false)]
            public long? LastHandleTime { get; set; }

            /// <summary>
            /// The severity level of a risk item. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The status of the check item. Valid values:
            /// 
            /// *   **1**: failed
            /// *   **2**: verifying
            /// *   **3**: passed
            /// *   **5**: expired
            /// *   **6**: ignored
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The type of the check item.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The UUID of the server on which the baseline check is performed.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
