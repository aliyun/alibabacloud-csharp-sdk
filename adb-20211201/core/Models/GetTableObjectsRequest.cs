// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetTableObjectsRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The description of the table.
        /// </summary>
        [NameInMap("FilterDescription")]
        [Validation(Required=false)]
        public string FilterDescription { get; set; }

        /// <summary>
        /// The owner of the table.
        /// </summary>
        [NameInMap("FilterOwner")]
        [Validation(Required=false)]
        public string FilterOwner { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("FilterTblName")]
        [Validation(Required=false)]
        public string FilterTblName { get; set; }

        /// <summary>
        /// The type of the table.
        /// 
        /// Valid values:
        /// 
        /// DIMENSION_TABLE
        /// 
        /// FACT_TABLE
        /// 
        /// EXTERNAL_TABLE
        /// 
        /// Default value: null.
        /// </summary>
        [NameInMap("FilterTblType")]
        [Validation(Required=false)]
        public string FilterTblType { get; set; }

        /// <summary>
        /// The order in which the fields to be returned are sorted.
        /// 
        /// Valid values:
        /// 
        /// *   Asc
        /// *   Desc
        /// 
        /// Values for fields:
        /// 
        /// TableName
        /// 
        /// TableSize
        /// 
        /// CreateTime
        /// 
        /// UpdateTime
        /// 
        /// Default value: {"Type": "Desc","Field": "TableName"};
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The number of the page to return. The value is an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
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
        /// The ID of the region in which the cluster resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

    }

}
