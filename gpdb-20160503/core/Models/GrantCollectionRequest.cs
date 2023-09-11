// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GrantCollectionRequest : TeaModel {
        /// <summary>
        /// The name of the collection.
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// The ID of the instance in reserved storage mode.
        /// 
        /// > You can call the [DescribeDBInstances](~~86911~~) operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the namespace to which you want to grant the vector collection permissions.
        /// </summary>
        [NameInMap("GrantToNamespace")]
        [Validation(Required=false)]
        public string GrantToNamespace { get; set; }

        /// <summary>
        /// The type of the permissions that you want to grant. Valid values:
        /// 
        /// *   rw: the read and write permissions.
        /// *   ro: the read-only permission.
        /// *   none: the delete permission.
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// The name of the manager account that has the rds_superuser permission.
        /// </summary>
        [NameInMap("ManagerAccount")]
        [Validation(Required=false)]
        public string ManagerAccount { get; set; }

        /// <summary>
        /// The password of the manager account.
        /// </summary>
        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// > You can call the [DescribeRegions](~~86912~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
