// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeSandboxBackupSetsRequest : TeaModel {
        /// <summary>
        /// The ID of the backup schedule. You can call the [DescribeBackupPlanList](https://help.aliyun.com/document_detail/437215.html) operation to query the ID of the backup schedule.
        /// 
        /// > If your instance is an ApsaraDB RDS for MySQL instance, you can [configure automatic access to a data source](https://help.aliyun.com/document_detail/193091.html) to automatically add the instance to DBS and obtain the ID of the backup schedule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// The ID of the backup set. If this parameter is specified, only the snapshot of the specified backup set is returned. If this parameter is not specified, all the snapshots of the backup schedule are returned.
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
        /// 
        /// *   30: This is the default value.
        /// *   50\\.
        /// *   100\\.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
