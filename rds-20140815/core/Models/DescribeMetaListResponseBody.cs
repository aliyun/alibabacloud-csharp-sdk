// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMetaListResponseBody : TeaModel {
        /// <summary>
        /// The instance name.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// The information about the databases and tables whose data is included in the backup set.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeMetaListResponseBodyItems Items { get; set; }
        public class DescribeMetaListResponseBodyItems : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public List<DescribeMetaListResponseBodyItemsMeta> Meta { get; set; }
            public class DescribeMetaListResponseBodyItemsMeta : TeaModel {
                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The table size. Unit: KB.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// The table name.
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public string Tables { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPageCount")]
        [Validation(Required=false)]
        public int? TotalPageCount { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
