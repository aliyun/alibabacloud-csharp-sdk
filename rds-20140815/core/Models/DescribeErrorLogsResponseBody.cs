// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeErrorLogsResponseBody : TeaModel {
        /// <summary>
        /// The list of items in an error log.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeErrorLogsResponseBodyItems Items { get; set; }
        public class DescribeErrorLogsResponseBodyItems : TeaModel {
            [NameInMap("ErrorLog")]
            [Validation(Required=false)]
            public List<DescribeErrorLogsResponseBodyItemsErrorLog> ErrorLog { get; set; }
            public class DescribeErrorLogsResponseBodyItemsErrorLog : TeaModel {
                /// <summary>
                /// The time when the error log was generated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The error log information.
                /// </summary>
                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public string ErrorInfo { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of error logs on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of error logs.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
