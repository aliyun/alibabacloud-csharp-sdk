// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetDatabaseObjectsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The owner of the database.
        /// </summary>
        [NameInMap("FilterOwner")]
        [Validation(Required=false)]
        public string FilterOwner { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("FilterSchemaName")]
        [Validation(Required=false)]
        public string FilterSchemaName { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results. Valid values:
        /// 
        /// *   Asc
        /// *   Desc
        /// 
        /// Valid values for Field: DatabaseName, CreateTime, and UpdateTime. -CreateTime; -UpdateTime;
        /// 
        /// Default value: {"Type": "Desc","Field": "DatabaseName"}.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   30
        /// *   50
        /// *   100
        /// 
        /// Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID of the database.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
