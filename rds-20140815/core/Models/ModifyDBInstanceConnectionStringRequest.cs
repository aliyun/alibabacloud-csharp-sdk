// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// The Tabular Data Stream (TDS) port of the instance for which Babelfish is enabled.
        /// 
        /// > This parameter applies only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see [Introduction to Babelfish](https://help.aliyun.com/document_detail/428613.html).
        /// </summary>
        [NameInMap("BabelfishPort")]
        [Validation(Required=false)]
        public string BabelfishPort { get; set; }

        /// <summary>
        /// The prefix of the endpoint after the change. Only the prefix of the value of **CurrentConnectionString** can be changed.
        /// 
        /// > The value must be 8 to 64 characters in length and can contain letters, digits, and hyphens (-). The value cannot contain any of the following special characters: ! # % ^ & \\* = + | {} ; : \\" " ,<> / ?
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The endpoint of the instance. It can be an internal endpoint, a public endpoint, or a classic network endpoint in hybrid access mode.
        /// 
        /// > The read/write splitting endpoint cannot be changed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentConnectionString")]
        [Validation(Required=false)]
        public string CurrentConnectionString { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the dedicated cluster to which the instance belongs. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.
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
        /// > This parameter is suitable only for ApsaraDB RDS for PostgreSQL instances. If you enable PgBouncer for your instance, you can change the PgBouncer port of the instance.
        /// </summary>
        [NameInMap("PGBouncerPort")]
        [Validation(Required=false)]
        public string PGBouncerPort { get; set; }

        /// <summary>
        /// The port number after the change.
        /// 
        /// This parameter is required.
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
