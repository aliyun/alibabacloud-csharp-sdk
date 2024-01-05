// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaDatabasesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about SAP HANA databases.
        /// </summary>
        [NameInMap("HanaDatabases")]
        [Validation(Required=false)]
        public DescribeHanaDatabasesResponseBodyHanaDatabases HanaDatabases { get; set; }
        public class DescribeHanaDatabasesResponseBodyHanaDatabases : TeaModel {
            [NameInMap("HanaDatabase")]
            [Validation(Required=false)]
            public List<DescribeHanaDatabasesResponseBodyHanaDatabasesHanaDatabase> HanaDatabase { get; set; }
            public class DescribeHanaDatabasesResponseBodyHanaDatabasesHanaDatabase : TeaModel {
                /// <summary>
                /// Indicates whether the database is started. Valid values:
                /// 
                /// *   **YES**: The database is started.
                /// *   **NO**: The database is not started.
                /// </summary>
                [NameInMap("ActiveStatus")]
                [Validation(Required=false)]
                public string ActiveStatus { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// The detailed information.
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// The hostname.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The name of the service.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("SqlPort")]
                [Validation(Required=false)]
                public int? SqlPort { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
