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
        /// 
        /// >  You can call the [CreateCollection](https://help.aliyun.com/document_detail/2401497.html) operation to create a vector collection and call the [ListCollections](https://help.aliyun.com/document_detail/2401503.html) operation to query a list of vector collections.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// The ID of the instance in reserved storage mode.
        /// 
        /// > You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the namespace to which you want to grant the vector collection permissions.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// The name of the manager account that has the rds_superuser permission.
        /// 
        /// >  You can create an account on the Account Management page of the AnalyticDB for PostgreSQL console or by calling the [CreateAccount](https://help.aliyun.com/document_detail/2361789.html) operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ManagerAccount")]
        [Validation(Required=false)]
        public string ManagerAccount { get; set; }

        /// <summary>
        /// The password of the manager account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// >  You can call the [ListNamespaces](https://help.aliyun.com/document_detail/2401502.html) operation to query a list of namespaces.
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
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
