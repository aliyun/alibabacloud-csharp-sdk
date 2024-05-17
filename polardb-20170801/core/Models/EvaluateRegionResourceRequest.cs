// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EvaluateRegionResourceRequest : TeaModel {
        /// <summary>
        /// The cluster link type. The backend randomly selects the default value. Valid values:
        /// 
        /// *   **lvs** :Linux virtual server
        /// *   **proxy**: proxy server
        /// *   **dns**: domain name system
        /// </summary>
        [NameInMap("DBInstanceConnType")]
        [Validation(Required=false)]
        public string DBInstanceConnType { get; set; }

        /// <summary>
        /// The specifications of the node. For information about node specifications, see the following topics:
        /// 
        /// *   PolarDB for MySQL: [Specifications of compute nodes](https://help.aliyun.com/document_detail/102542.html)
        /// *   PolarDB for Oracle: [Specifications of compute nodes](https://help.aliyun.com/document_detail/207921.html)
        /// *   PolarDB for PostgreSQL: [Specifications of compute nodes](https://help.aliyun.com/document_detail/209380.html)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// The type of the database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PostgreSQL**
        /// *   **Oracle**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the database engine
        /// 
        /// *   Valid values for the MySQL database engine:
        /// 
        ///     *   **5.6**
        ///     *   **5.7**
        ///     *   **8.0**
        /// 
        /// *   Valid values for the PostgreSQL database engine:
        /// 
        ///     *   **11**
        ///     *   **14**
        /// 
        /// *   Valid value for the Oracle database engine: **11**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// Specifies whether to return the zones in which the single-zone deployment method is supported. Default value: 0. Valid values:
        /// 
        /// *   **0**: no value returned
        /// *   **1**: returns the zones.
        /// </summary>
        [NameInMap("DispenseMode")]
        [Validation(Required=false)]
        public string DispenseMode { get; set; }

        /// <summary>
        /// Specifies whether Maxscale is created. Default value: true. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NeedMaxScaleLink")]
        [Validation(Required=false)]
        public string NeedMaxScaleLink { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/98041.html) operation to query available regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The subdomain. It is the child domain of the top-level domain name or parent domain. For example, if the parent domain name is cn-beijing, its child domain can be cn-beijing-i-aliyun.
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// The zone ID.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/98041.html) operation to query available zones.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
