// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionLogBackupFilesResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The cross-region log backup files.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionLogBackupFilesResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionLogBackupFilesResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionLogBackupFilesResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionLogBackupFilesResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// The ID of the destination region within which the cross-region backup file is stored.
                /// </summary>
                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                /// <summary>
                /// The external URL from which you can download the cross-region log backup file.
                /// </summary>
                [NameInMap("CrossDownloadLink")]
                [Validation(Required=false)]
                public string CrossDownloadLink { get; set; }

                /// <summary>
                /// The internal URL from which you can download the cross-region log backup file.
                /// </summary>
                [NameInMap("CrossIntranetDownloadLink")]
                [Validation(Required=false)]
                public string CrossIntranetDownloadLink { get; set; }

                /// <summary>
                /// The ID of the cross-region log backup file.
                /// </summary>
                [NameInMap("CrossLogBackupId")]
                [Validation(Required=false)]
                public int? CrossLogBackupId { get; set; }

                /// <summary>
                /// The size of the cross-region log backup file. Unit: bytes.
                /// </summary>
                [NameInMap("CrossLogBackupSize")]
                [Validation(Required=false)]
                public long? CrossLogBackupSize { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                /// <summary>
                /// The time when the URL expires. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                /// <summary>
                /// The start time of the cross-region log backup file. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                /// <summary>
                /// The end time of the cross-region log backup file. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                /// <summary>
                /// The name of the cross-region log backup file.
                /// </summary>
                [NameInMap("LogFileName")]
                [Validation(Required=false)]
                public string LogFileName { get; set; }

            }

        }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of cross-region backup files on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
