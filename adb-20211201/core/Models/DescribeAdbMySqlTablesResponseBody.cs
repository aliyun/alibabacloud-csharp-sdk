// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAdbMySqlTablesResponseBody : TeaModel {
        /// <summary>
        /// The message returned for the operation. Valid values:
        /// 
        /// *   **Success** is returned if the operation is successful.
        /// *   An error message is returned if the operation fails.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// Indicates whether the operation is successful. Valid values:
        /// 
        /// *   **true**: The operation is successful.
        /// *   **false**: The operation fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The names of tables.
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<string> Tables { get; set; }

    }

}
