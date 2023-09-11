// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListNamespacesRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](~~86911~~) operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
