// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AllocateInstancePublicConnectionRequest : TeaModel {
        /// <summary>
        /// The Tabular Data Stream (TDS) port of the instance for which Babelfish is enabled.
        /// 
        /// > This parameter applies only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see [Introduction to Babelfish](~~428613~~).
        /// </summary>
        [NameInMap("BabelfishPort")]
        [Validation(Required=false)]
        public string BabelfishPort { get; set; }

        /// <summary>
        /// The prefix of the public endpoint. A valid public endpoint is in the following format: `Prefix.Database engine.rds.aliyuncs.com`. Example: `test1234.mysql.rds.aliyuncs.com`.
        /// 
        /// > The value can be 5 to 40 characters in length and can contain letters, digits, and hyphens (-). The value cannot contain any of the following characters: ~ ! # % ^ & \* = + | {} ; : \" " , <> / ?
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the dedicated cluster to which the instance belongs. This parameter is available only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.
        /// </summary>
        [NameInMap("GeneralGroupName")]
        [Validation(Required=false)]
        public string GeneralGroupName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The PgBouncer port.
        /// 
        /// > This parameter is available only for instances that run PostgreSQL.
        /// </summary>
        [NameInMap("PGBouncerPort")]
        [Validation(Required=false)]
        public string PGBouncerPort { get; set; }

        /// <summary>
        /// The public port of the instance. Valid values: **1000 to 5999**.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
