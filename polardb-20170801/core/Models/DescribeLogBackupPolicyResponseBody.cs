// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLogBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the log backup feature is enabled. Valid values:
        /// 
        /// *   0: The log backup feature is disabled.
        /// *   1: The log backup feature is enabled. By default, the log backup feature is enabled and cannot be disabled.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// The region in which you want to store cross-region log backups. For more information about regions that support the cross-region backup feature, see [Overview](https://help.aliyun.com/document_detail/72672.html).
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRegion")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRegion { get; set; }

        /// <summary>
        /// The retention period of cross-region log backups. Valid values:
        /// 
        /// *   **0**: The cross-region backup feature is disabled.
        /// *   **30 to 7300**: Cross-region log backups are retained for 30 to 7,300 days.
        /// *   **-1**: The log backups are permanently retained.
        /// 
        /// >  When you create a cluster, the default value of this parameter is **0**.
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRetentionPeriod { get; set; }

        /// <summary>
        /// The retention period of the log backups. Valid values:
        /// 
        /// *   3 to 7300: The log backups are retained for 3 to 7,300 days.
        /// *   \\-1: The log backups are permanently retained.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
