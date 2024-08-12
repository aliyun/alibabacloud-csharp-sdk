// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class TransferVersionRequest : TeaModel {
        /// <summary>
        /// The ID of the source ApsaraDB for ClickHouse cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DisableWriteWindows")]
        [Validation(Required=false)]
        public string DisableWriteWindows { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/170875.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// The database account that is used to log on to the database in the source ApsaraDB for ClickHouse cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceAccount")]
        [Validation(Required=false)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// The password that corresponds to the database account for logging on to the database in the source ApsaraDB for ClickHouse cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourcePassword")]
        [Validation(Required=false)]
        public string SourcePassword { get; set; }

        /// <summary>
        /// The database account that is used to log on to the database in the destination ApsaraDB for ClickHouse cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetAccount")]
        [Validation(Required=false)]
        public string TargetAccount { get; set; }

        /// <summary>
        /// The ID of the destination ApsaraDB for ClickHouse cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetDbClusterId")]
        [Validation(Required=false)]
        public string TargetDbClusterId { get; set; }

        /// <summary>
        /// The password that corresponds to the database account for logging on to the database in the destination ApsaraDB for ClickHouse cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetPassword")]
        [Validation(Required=false)]
        public string TargetPassword { get; set; }

    }

}
