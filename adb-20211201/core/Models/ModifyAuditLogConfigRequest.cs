// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// The status to which you want to change the SQL audit feature. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// 
        /// >  After you disable the SQL audit feature, all SQL audit logs are deleted. You must query and export SQL audit logs before you disable SQL audit. For more information, see [DescribeAuditLogRecords](https://help.aliyun.com/document_detail/612426.html). When you re-enable SQL audit, audit logs that are generated from the time when SQL audit was last enabled are available for queries.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuditLogStatus")]
        [Validation(Required=false)]
        public string AuditLogStatus { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/454314.html) operation to query the most recent region list.
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

    }

}
