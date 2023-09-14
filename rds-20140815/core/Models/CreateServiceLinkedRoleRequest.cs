// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~610399~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The name of the service-linked role.
        /// 
        /// *   **AliyunServiceRoleForRdsPgsqlOnEcs**: the service-linked role for ApsaraDB RDS for PostgreSQL.
        /// *   **AliyunServiceRoleForRDSProxyOnEcs**: the service-linked role for the database proxy feature of ApsaraDB RDS for PostgreSQL.
        /// </summary>
        [NameInMap("ServiceLinkedRole")]
        [Validation(Required=false)]
        public string ServiceLinkedRole { get; set; }

    }

}
