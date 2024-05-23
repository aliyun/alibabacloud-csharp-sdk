// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceConnectionModeRequest : TeaModel {
        /// <summary>
        /// The connection mode of the instance. Valid values:
        /// 
        /// *   **Standard**: standard mode
        /// *   **Safe**: database proxy mode
        /// 
        /// The system automatically assigns a connection mode to the instance.
        /// 
        /// >  SQL Server 2012, SQL Server 2016, and SQL Server 2017 support only the standard mode.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
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

    }

}
