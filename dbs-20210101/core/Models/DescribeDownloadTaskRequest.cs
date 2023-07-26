// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeDownloadTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set generated when you create a download task. You can call the [DescribeBackups](~~26273~~) operation to query the ID.
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The ID of the Database Backup (DBS) data source. Specify the parameter in the format of *ds-${Instance ID}\_${regionId}*.
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public string DatasourceId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify this parameter as a timestamp of the LONG type. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > This parameter is required.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The column based on which the entries are sorted. By default, the entries are sorted by the time when the download task was created. Set the value to **gmt_create**.
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// The order in which you want to sort the entries. Valid values:
        /// 
        /// *   **asc**: the ascending order.
        /// *   **desc**: the descending order. This is the default value.
        /// </summary>
        [NameInMap("OrderDirect")]
        [Validation(Required=false)]
        public string OrderDirect { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides. You can call the [DescribeDBInstanceAttribute](~~26231~~) operation to query the region ID of the instance.
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify this parameter as a timestamp of the LONG type. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The state of the download task. Valid values:
        /// 
        /// *   **Initializing**: The download task is being initialized.
        /// *   **queuing**: The download task is queuing.
        /// *   **running**: The download task is running.
        /// *   **failed**: The download task fails.
        /// *   **finished**: The download task is complete.
        /// *   **expired**: The download task expires.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The type of the download task. Valid values:
        /// 
        /// *   **full**: downloads a full backup set.
        /// *   **pitr**: downloads a backup set at a specific point in time.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
