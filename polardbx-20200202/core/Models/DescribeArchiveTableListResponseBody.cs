// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeArchiveTableListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeArchiveTableListResponseBodyData Data { get; set; }
        public class DescribeArchiveTableListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// </summary>
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("PausedCount")]
            [Validation(Required=false)]
            public int? PausedCount { get; set; }

            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<DescribeArchiveTableListResponseBodyDataTables> Tables { get; set; }
            public class DescribeArchiveTableListResponseBodyDataTables : TeaModel {
                [NameInMap("ArchiveStatus")]
                [Validation(Required=false)]
                public string ArchiveStatus { get; set; }

                /// <summary>
                /// <para>The time when the table was created.</para>
                /// </summary>
                [NameInMap("CreatedDate")]
                [Validation(Required=false)]
                public long? CreatedDate { get; set; }

                /// <summary>
                /// <para>The number of files.</para>
                /// </summary>
                [NameInMap("FileCount")]
                [Validation(Required=false)]
                public int? FileCount { get; set; }

                [NameInMap("LastSuccessArchiveTime")]
                [Validation(Required=false)]
                public long? LastSuccessArchiveTime { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The space occupied by the table.</para>
                /// </summary>
                [NameInMap("SpaceSize")]
                [Validation(Required=false)]
                public double? SpaceSize { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("TobeArchivedConut")]
            [Validation(Required=false)]
            public int? TobeArchivedConut { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
