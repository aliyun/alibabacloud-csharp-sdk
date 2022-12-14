// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class CreateSandboxInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the backup schedule. You can call the [DescribeBackupPlanList](~~437215~~) operation to obtain the ID of the backup schedule.
        /// 
        /// >  If your instance is an ApsaraDB RDS for MySQL instance, you can configure [automatic access to the instance](~~193091~~) to automatically add the instance to DBS and obtain the ID of the backup schedule.
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// The ID of the backup set to be restored, which is the point in time when a snapshot was created. You can call the [DescribeSandboxBackupSets](~~437256~~) operation to obtain the ID.
        /// 
        /// >  You need to specify only one of the **BackupSetId** and **RestoreTime** parameters.
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The point in time of the sandbox instance to be restored. You can call the [DescribeSandboxRecoveryTime](~~437258~~) operation to view the recoverable time range. Specify the time in the format of *yyyy-MM-ddTHH:mm:ssZ*. The time must be in UTC.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The name of the sandbox instance.
        /// </summary>
        [NameInMap("SandboxInstanceName")]
        [Validation(Required=false)]
        public string SandboxInstanceName { get; set; }

        /// <summary>
        /// The password of the privileged account created in the sandbox instance.
        /// </summary>
        [NameInMap("SandboxPassword")]
        [Validation(Required=false)]
        public string SandboxPassword { get; set; }

        /// <summary>
        /// The specifications of the sandbox instance. Valid values:
        /// 
        /// *   **MYSQL\_1C\_1M_SD**: 1 CPU core and 1 GB of memory.
        /// *   **MYSQL\_1C\_2M_SD**: 1 CPU core and 2 GB of memory.
        /// *   **MYSQL\_2C\_4M_SD**: 2 CPU cores and 4 GB of memory.
        /// *   **MYSQL\_2C\_8M_SD**: 2 CPU cores and 8 GB of memory.
        /// *   **MYSQL\_4C\_8M_SD**: 4 CPU cores and 8 GB of memory.
        /// *   **MYSQL\_4C\_16M_SD**: 4 CPU cores and 16 GB of memory.
        /// *   **MYSQL\_8C\_16M_SD**: 8 CPU cores and 16 GB of memory.
        /// *   **MYSQL\_8C\_32M_SD**: 8 CPU cores and 32 GB of memory.
        /// 
        /// >  Different specifications have little impact on the recovery speed. High-specification instances provide better performance after restoration. For more information, see [Sandbox instance fees](~~201466~~).
        /// </summary>
        [NameInMap("SandboxSpecification")]
        [Validation(Required=false)]
        public string SandboxSpecification { get; set; }

        /// <summary>
        /// The type of the sandbox instance. You can call this operation only to create an instance of the **Sandbox** type. After the sandbox instance is created, the MySQL endpoint of the instance is provided.
        /// </summary>
        [NameInMap("SandboxType")]
        [Validation(Required=false)]
        public string SandboxType { get; set; }

        /// <summary>
        /// The privileged account created in the sandbox instance.
        /// 
        /// *   After you specify this parameter, the system creates a privileged account in the sandbox instance. The account has the permissions on all databases in the instance.
        /// 
        /// The account of the source database is retained in the sandbox instance.
        /// 
        /// *   If you do not specify this parameter, the database account is the same as that of the source database.
        /// </summary>
        [NameInMap("SandboxUser")]
        [Validation(Required=false)]
        public string SandboxUser { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) that is used to connect to the sandbox instance. If you want to connect to the sandbox instance by using Elastic Compute Service (ECS) instances, you must set this parameter to the VPC in which the ECS instances reside.
        /// 
        /// >  You can set this parameter if you want to use it in a recovery drill scenario.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the VSwitch that is used to connect to the sandbox instance.
        /// </summary>
        [NameInMap("VpcSwitchId")]
        [Validation(Required=false)]
        public string VpcSwitchId { get; set; }

    }

}
