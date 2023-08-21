// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DeleteSandboxInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the backup schedule. You can call the [DescribeBackupPlanList](~~437215~~) operation to query the ID of the backup schedule.
        /// 
        /// > If your instance is an ApsaraDB RDS for MySQL instance, you can [configure automatic access to a data source](~~193091~~) to automatically add the instance to DBS and obtain the ID of the backup schedule.
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// The ID of the sandbox instance. You can call the [DescribeSandboxInstances](~~437257~~) operation to query the ID of the sandbox instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
