// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBResponseBody : TeaModel {
        /// <summary>
        /// Indicates the details about the database.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDBResponseBodyData Data { get; set; }
        public class DescribeDrdsDBResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates the time when the database was created. The value is in the UNIX timestamp format. Unit: ms.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Indicates the storage type of the database.
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public string DbInstType { get; set; }

            /// <summary>
            /// Indicates the name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// Indicates the type of the instance in which the database is deployed. Valid values:
            /// 
            /// *   **MASTER**: The instance is a primary instance.
            /// *   **SLAVE**: The instance is a read-only instance.
            /// </summary>
            [NameInMap("InstRole")]
            [Validation(Required=false)]
            public string InstRole { get; set; }

            /// <summary>
            /// Indicates the database sharding method.
            /// 
            /// *   **HORIZONTAL**: The database is horizontally sharded.
            /// *   **VERTICAL**: The database is vertically sharded.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// Indicates the schema name of the database.
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// Indicates the state of the database. Valid values:
            /// 
            /// *   **TO_BE_INIT**: The database is being created.
            /// *   **NORMAL**: The database is running.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates the ID of the request.
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

    }

}
