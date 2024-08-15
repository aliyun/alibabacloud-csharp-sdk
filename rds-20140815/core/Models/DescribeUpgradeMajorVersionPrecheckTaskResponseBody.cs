// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionPrecheckTaskResponseBody : TeaModel {
        /// <summary>
        /// The information about the upgrade check report.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems : TeaModel {
            /// <summary>
            /// The time at which the upgrade check was performed.
            /// 
            /// The value of this parameter is a timestamp that follows the UNIX time format. Unit: milliseconds.
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// The content of the upgrade check report.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The expiration time of the upgrade check report.
            /// 
            /// The value of this parameter is a timestamp that follows the UNIX time format. Unit: milliseconds.
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The result of the upgrade check.
            /// 
            /// Valid values:
            /// 
            /// *   Success
            /// *   Fail
            /// 
            /// >  If the check result is **Fail**, you must check the value of the **Detail** parameter to obtain the information about the errors that occurred, resolve the errors, and then try again. For more information about how to resolve common errors, see [Introduction to the check report for a major engine version upgrade to an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/218391.html).
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The original major engine version of the instance.
            /// </summary>
            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            /// <summary>
            /// The new major engine version of the instance.
            /// </summary>
            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            /// <summary>
            /// The ID of the upgrade check task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries in the upgrade check report.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
