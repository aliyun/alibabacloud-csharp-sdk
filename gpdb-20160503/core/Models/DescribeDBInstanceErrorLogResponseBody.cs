// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceErrorLogResponseBody : TeaModel {
        /// <summary>
        /// The content of the error log.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceErrorLogResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceErrorLogResponseBodyItems : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// This parameter is not supported.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The content of the error log.
            /// </summary>
            [NameInMap("LogContext")]
            [Validation(Required=false)]
            public string LogContext { get; set; }

            /// <summary>
            /// The level of the queried log.
            /// </summary>
            [NameInMap("LogLevel")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

            /// <summary>
            /// The time when the log was generated. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// The name of the database account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
