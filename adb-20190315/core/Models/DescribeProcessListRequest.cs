// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeProcessListRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The keyword in an SQL statement, which is used to filter queries. Set the value to **SELECT**.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The order in which queries are sorted based on the specified fields. Specify this parameter as an ordered JSON array in the `[{"Field":"Time","Type":"Desc" },{ "Field":"User", "Type":"Asc" }]` format.
        /// 
        /// *   **Field** specifies the field used to sort queries. Valid values: Time, User, Host, and DB.
        /// *   **Type** specifies the sorting sequence. Valid values: **Desc** and **Asc**.
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
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 30. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
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
        /// The execution duration used to filter queries. Queries that take a longer time than the specified execution duration are displayed. Unit: seconds.
        /// </summary>
        [NameInMap("RunningTime")]
        [Validation(Required=false)]
        public int? RunningTime { get; set; }

        /// <summary>
        /// Specifies whether to show a complete SQL statement. Valid values:
        /// 
        /// *   **True**: shows a complete SQL statement.
        /// *   **False**: shows only the first 100 characters of an SQL statement.
        /// 
        /// >  The default value is False.
        /// </summary>
        [NameInMap("ShowFull")]
        [Validation(Required=false)]
        public bool? ShowFull { get; set; }

        /// <summary>
        /// The name of the user used to filter queries.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
