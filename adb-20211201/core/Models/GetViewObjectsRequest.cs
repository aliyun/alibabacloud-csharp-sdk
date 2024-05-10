// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetViewObjectsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The owner of the view.
        /// </summary>
        [NameInMap("FilterOwner")]
        [Validation(Required=false)]
        public string FilterOwner { get; set; }

        /// <summary>
        /// The name of the view.
        /// </summary>
        [NameInMap("FilterViewName")]
        [Validation(Required=false)]
        public string FilterViewName { get; set; }

        /// <summary>
        /// The type of the view.
        /// 
        /// Valid values:
        /// 
        /// \\-VIRTUAL_VIEW
        /// 
        /// \\-MATERIALIZED_VIEW
        /// 
        /// Default value: null.
        /// </summary>
        [NameInMap("FilterViewType")]
        [Validation(Required=false)]
        public string FilterViewType { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results. Valid values for Type:
        /// 
        /// *   Asc
        /// *   Desc
        /// 
        /// Valid values for Field: -ViewName
        /// 
        /// \\-CreateTime
        /// 
        /// \\-UpdateTime
        /// 
        /// Default value: {"Type": "Desc","Field": "ViewName"}.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// This parameter is required.
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
