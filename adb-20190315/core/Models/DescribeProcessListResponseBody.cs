// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        /// <summary>
        /// Details of the queries.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyItems Items { get; set; }
        public class DescribeProcessListResponseBodyItems : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public List<DescribeProcessListResponseBodyItemsProcess> Process { get; set; }
            public class DescribeProcessListResponseBodyItemsProcess : TeaModel {
                /// <summary>
                /// The type of the statement. Only SELECT can be returned.
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DB")]
                [Validation(Required=false)]
                public string DB { get; set; }

                /// <summary>
                /// The IP address from which the query was initiated.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The ID of the worker thread.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The SQL statement that is being executed. By default, the first 100 characters of the SQL statement are returned. If the ShowFull parameter is set to True, the complete SQL statement is returned.
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                /// <summary>
                /// The unique ID of the query. You must specify this parameter when you use the KILL PROCESS statement.
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                /// <summary>
                /// The start time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The amount of time that has elapsed from the start time of the query. Unit: seconds.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The total number of pages returned.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
