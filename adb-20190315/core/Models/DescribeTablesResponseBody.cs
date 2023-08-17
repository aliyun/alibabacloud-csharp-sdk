// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTablesResponseBody : TeaModel {
        /// <summary>
        /// The list of tables.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTablesResponseBodyItems Items { get; set; }
        public class DescribeTablesResponseBodyItems : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeTablesResponseBodyItemsTable> Table { get; set; }
            public class DescribeTablesResponseBodyItemsTable : TeaModel {
                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
