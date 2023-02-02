// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeRecommendIndexResponseBody : TeaModel {
        /// <summary>
        /// The information about the recommended index.
        /// </summary>
        [NameInMap("RecommendIndex")]
        [Validation(Required=false)]
        public DescribeRecommendIndexResponseBodyRecommendIndex RecommendIndex { get; set; }
        public class DescribeRecommendIndexResponseBodyRecommendIndex : TeaModel {
            /// <summary>
            /// The index recommended for the SQL statement after calculation by the diagnostic system.   
            /// - If the recommended index is the primary key, PRIMARY is returned.  
            /// - If an index created by the user is recommended, the index name is returned.   
            /// The system recommends only one index for an SQL statement. You can call the DescribeIndexes operation to view the indexes of a table.
            /// </summary>
            [NameInMap("SuggestIndex")]
            [Validation(Required=false)]
            public string SuggestIndex { get; set; }

            /// <summary>
            /// The tables.   
            /// The data tables involved in the SQL statement corresponding to the SQL ID are returned. For a single-table query, the data table accessed is returned. For a join query, all data tables accessed by the SQL statement are returned and separated with vertical bars (|), for example, "Table1|Table2".
            /// </summary>
            [NameInMap("TableList")]
            [Validation(Required=false)]
            public string TableList { get; set; }

            /// <summary>
            /// The tenant mode.   Valid values:  
            /// Oracle   
            /// MySQL
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
