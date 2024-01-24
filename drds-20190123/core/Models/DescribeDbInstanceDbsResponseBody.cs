// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDbInstanceDbsResponseBody : TeaModel {
        /// <summary>
        /// Indicates the information about the storage-layer databases.
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDbInstanceDbsResponseBodyDatabases Databases { get; set; }
        public class DescribeDbInstanceDbsResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDbInstanceDbsResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDbInstanceDbsResponseBodyDatabasesDatabase : TeaModel {
                /// <summary>
                /// Indicates the name of a storage-layer database.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// Indicates the description of the storage-layer database.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates the state of the storage-layer database. Valid values:
                /// 
                /// *   **0**: The database is being created.
                /// *   **1**: The database is available.
                /// *   **3**: The database is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Indicates the total number of storage-layer databases.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
