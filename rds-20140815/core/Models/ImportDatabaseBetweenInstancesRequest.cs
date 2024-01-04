// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ImportDatabaseBetweenInstancesRequest : TeaModel {
        /// <summary>
        /// The names of the source and destination databases. The value of this parameter is a JSON string.
        /// 
        /// >  If the source instance runs SQL Server, the value of this parameter consists of one or more key-value pairs. In each key-value pair, the key specifies the name of the source database, and the value specifies the name of the destination database. A source database can have a different name from the destination database. For example, `{"DBNames":{"srcdb":"destdb","srcdb2":"destmydb2"}}` indicates that srcdb is migrated to destdb and srcdb2 is migrated to destmydb2. The names of source databases cannot be the same, and the names of destination databases cannot be the same.
        /// </summary>
        [NameInMap("DBInfo")]
        [Validation(Required=false)]
        public string DBInfo { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the source instance, which cannot be the same as the ID of the destination instance.
        /// </summary>
        [NameInMap("SourceDBInstanceId")]
        [Validation(Required=false)]
        public string SourceDBInstanceId { get; set; }

    }

}
