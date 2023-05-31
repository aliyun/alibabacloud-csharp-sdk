// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestorePlansResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeRestorePlansResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeRestorePlansResponseBodyPageInfo : TeaModel {
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
            /// The number of entries returned per page.
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
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the restoration tasks.
        /// </summary>
        [NameInMap("RestorePlans")]
        [Validation(Required=false)]
        public List<DescribeRestorePlansResponseBodyRestorePlans> RestorePlans { get; set; }
        public class DescribeRestorePlansResponseBodyRestorePlans : TeaModel {
            /// <summary>
            /// The timestamp when the restoration task was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The name of the server on which the database resides.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// The name of the anti-ransomware policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The point in time to which data is restored.
            /// </summary>
            [NameInMap("RestorePoint")]
            [Validation(Required=false)]
            public long? RestorePoint { get; set; }

            /// <summary>
            /// The status of the restoration task. Valid values:
            /// 
            /// *   **init**: initializing
            /// *   **created**: creating
            /// *   **running**: running
            /// *   **completed**: complete
            /// *   **error**: failed
            /// *   **restoring**: restoring
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the destination database.
            /// </summary>
            [NameInMap("TargetDatabaseName")]
            [Validation(Required=false)]
            public string TargetDatabaseName { get; set; }

            /// <summary>
            /// The ID of the destination server.
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// The name of the destination server.
            /// </summary>
            [NameInMap("TargetInstanceName")]
            [Validation(Required=false)]
            public string TargetInstanceName { get; set; }

            /// <summary>
            /// The timestamp when the restoration task was last updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

    }

}
