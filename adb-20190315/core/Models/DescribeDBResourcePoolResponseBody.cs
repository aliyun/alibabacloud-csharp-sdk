// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBResourcePoolResponseBody : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Details of the resource group.
        /// </summary>
        [NameInMap("PoolsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourcePoolResponseBodyPoolsInfo> PoolsInfo { get; set; }
        public class DescribeDBResourcePoolResponseBodyPoolsInfo : TeaModel {
            /// <summary>
            /// The time when the resource group was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The number of nodes.
            /// 
            /// >  Each node consumes 16 cores and 64 GB memory.
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public string PoolName { get; set; }

            /// <summary>
            /// The database accounts that are associated with the resource group.
            /// </summary>
            [NameInMap("PoolUsers")]
            [Validation(Required=false)]
            public string PoolUsers { get; set; }

            /// <summary>
            /// The mode in which SQL statements are executed.
            /// 
            /// *   **batch**
            /// *   **interactive**
            /// 
            /// >  For more information, see [Query execution modes](~~189502~~).
            /// </summary>
            [NameInMap("QueryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            /// <summary>
            /// The time when the resource group was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
