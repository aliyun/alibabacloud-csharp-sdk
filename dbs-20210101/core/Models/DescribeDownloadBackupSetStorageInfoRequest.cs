// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeDownloadBackupSetStorageInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set.
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The validity period of the URL that is used as the download destination. Take note of the following items:
        /// 
        /// *   Default value: 7200. This means that the URL is valid for 2 hours by default.
        /// *   Valid values: 300 to 86400. Unit: seconds. This means that you can specify a validity period in the range of 5 minutes to 1 day.
        /// *   Before you specify this parameter, convert the validity period to seconds. For example, if you want to set the validity period of the URL to 5 minutes, enter 300.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > The **BackupSetId** parameter is required if you specify the **InstanceName** parameter.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides. You can call the [DescribeDBInstanceAttribute](https://help.aliyun.com/document_detail/26231.html) operation to query the region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// The download task ID.
        /// 
        /// *   The **BackupSetId** and **InstanceName** parameters are required if you do not specify the **TaskId** parameter.
        /// *   To view the download task ID, go to the instance details page in the console and click **Backup and Restoration** in the left-side navigation pane. On the **Backup Download** tab, view the task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
