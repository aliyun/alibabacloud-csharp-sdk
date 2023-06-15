// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceMajorVersionPrecheckRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// The instance must meet the following requirements:
        /// 
        /// *   The instance runs PostgreSQL 12, PostgreSQL 11, PostgreSQL 10, or PostgreSQL 9.4.
        /// *   The instance runs RDS High-availability Edition or RDS Basic Edition.
        /// *   The instance resides in a virtual private cloud (VPC). If the instance resides in the classic network, you must migrate the instance to a VPC before you call this operation. For more information about how to view or change the network type of an instance, see [Change the network type of an ApsaraDB RDS for PostgreSQL instance](~~96761~~).
        /// *   The instance cannot be a read-only instance and cannot be created in a dedicated cluster.
        /// *   The ID of the instance does not start with `pg-cn`.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The new major engine version of the instance. The new major engine version must be later than the original major engine version.
        /// 
        /// For example, if the original major engine version is PostgreSQL 9.4, the new major engine version can be PostgreSQL 10, PostgreSQL 11, PostgreSQL 12, or PostgreSQL 13.
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

    }

}
