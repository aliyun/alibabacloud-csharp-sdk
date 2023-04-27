// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// The alias of the database instance.
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The source of the database instance. Valid values:
        /// 
        /// *   **PUBLIC_OWN**: a self-managed database instance that is deployed on the Internet
        /// *   **RDS**: an ApsaraDB RDS instance
        /// *   **ECS_OWN**: a self-managed database that is deployed on an Elastic Compute Service (ECS) instance
        /// *   **VPC_IDC**: a self-managed database instance that is deployed in a data center connected over a virtual private cloud (VPC)
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The timeout period for querying data in the database instance.
        /// </summary>
        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        /// <summary>
        /// The network type of the database instance. Valid values:
        /// 
        /// *   **CLASSIC**: classic network
        /// *   **VPC**: VPC
        /// </summary>
        [NameInMap("InstanceState")]
        [Validation(Required=false)]
        public string InstanceState { get; set; }

        /// <summary>
        /// The status of the database instance.
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Indicates whether the lock-free schema change feature is enabled for the database instance.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListInstances**.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The ID of the owner for the database instance.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
