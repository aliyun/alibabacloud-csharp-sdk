// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableAccessCountResponseBody : TeaModel {
        /// <summary>
        /// Details about the table usage.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTableAccessCountResponseBodyItems> Items { get; set; }
        public class DescribeTableAccessCountResponseBodyItems : TeaModel {
            /// <summary>
            /// The number of accesses to the table.
            /// </summary>
            [NameInMap("AccessCount")]
            [Validation(Required=false)]
            public string AccessCount { get; set; }

            /// <summary>
            /// The ID of the cluster to which the table belongs.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The date when the table was used.
            /// </summary>
            [NameInMap("ReportDate")]
            [Validation(Required=false)]
            public string ReportDate { get; set; }

            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The database to which the table belongs.
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public string TableSchema { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
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
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
