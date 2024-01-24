// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBsResponseBody : TeaModel {
        /// <summary>
        /// The list of returned databases.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDBsResponseBodyData Data { get; set; }
        public class DescribeDrdsDBsResponseBodyData : TeaModel {
            [NameInMap("Db")]
            [Validation(Required=false)]
            public List<DescribeDrdsDBsResponseBodyDataDb> Db { get; set; }
            public class DescribeDrdsDBsResponseBodyDataDb : TeaModel {
                /// <summary>
                /// The time when the database is created. The value of this parameter is a UNIX timestamp. Unit: ms.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The type of the database. Valid values: **RDS** and **POLARDB**.
                /// </summary>
                [NameInMap("DbInstType")]
                [Validation(Required=false)]
                public string DbInstType { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// The partitioning mode of the database. Valid values:
                /// 
                /// *   **HORIZONTAL**: The database is horizontally partitioned.
                /// *   **VERTICAL**: The database is vertically partitioned.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The schema ID that is assigned to the partitioned database.
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// The state of the database.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of databases returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        /// The number of returned databases.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
