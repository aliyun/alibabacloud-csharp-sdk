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
        /// Set this parameter if the Download Destination parameter is set to URL.
        /// 
        /// *   By default, a URL is valid for 2 hours, which is equal to 7,200 seconds.
        /// *   The valid duration is 5 minutes (300 seconds) to 1 day (86,400 seconds).
        /// *   Before you set this parameter, convert the time to seconds. For example, if you want to set the validity period of the link to 5 minutes, enter 300.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  The **BackupSetId** parameter is required if you specify the **InstanceName** parameter.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeDBInstanceAttribute](~~26231~~) operation to query the region ID of the instance.
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// The ID of the download task.
        /// 
        /// *   The **BackupSetId** and **InstanceName** parameters are required if you do not specify the **TaskId** parameter.
        /// *   You can find the instance and click **Backup and Restoration**. On the **Backup Download** tab, view the **task ID**.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
