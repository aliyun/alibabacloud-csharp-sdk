// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeSandboxRecoveryTimeRequest : TeaModel {
        /// <summary>
        /// The ID of the backup schedule. You can call the [DescribeBackupPlanList](https://help.aliyun.com/document_detail/437215.html) operation to obtain the ID of the backup schedule. If you set this parameter to the backup schedule ID obtained by calling the DescribeBackupPlanList operation, the dbs prefix must be removed. Otherwise, the call fails.
        /// 
        /// > If your instance is an ApsaraDB RDS for MySQL instance, you can [configure automatic access to a data source](https://help.aliyun.com/document_detail/193091.html) to automatically add the instance to DBS and obtain the ID of the backup schedule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

    }

}
