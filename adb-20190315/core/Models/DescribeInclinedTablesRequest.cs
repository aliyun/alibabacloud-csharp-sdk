// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeInclinedTablesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The order in which queries are sorted in the JSON format based on the specified fields. Specify the fields used to sort the queries and the order type.
        /// 
        /// Example:
        /// 
        /// ```
        /// 
        /// [
        /// 
        ///     {
        /// 
        ///         "Field":"Name",
        /// 
        ///         "Type":"Asc"
        /// 
        ///     }
        /// 
        /// ]
        /// ```
        /// 
        /// In the preceding code, Field indicates the field used to sort queries. Set the value of Field to Name.
        /// 
        /// Type indicates the order type. Valid values of Type: Desc and Asc. A value of Desc indicates a descending order. A value of Asc indicates an ascending order.
        /// 
        /// Both fields are not case-sensitive.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the table. Valid values:
        /// 
        /// *   FactTable
        /// *   DimensionTable
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

    }

}
