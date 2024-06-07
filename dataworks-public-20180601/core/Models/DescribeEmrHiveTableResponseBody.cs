// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class DescribeEmrHiveTableResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEmrHiveTableResponseBodyData Data { get; set; }
        public class DescribeEmrHiveTableResponseBodyData : TeaModel {
            [NameInMap("ClusterBizId")]
            [Validation(Required=false)]
            public string ClusterBizId { get; set; }

            [NameInMap("ClusterBizName")]
            [Validation(Required=false)]
            public string ClusterBizName { get; set; }

            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<DescribeEmrHiveTableResponseBodyDataColumns> Columns { get; set; }
            public class DescribeEmrHiveTableResponseBodyDataColumns : TeaModel {
                [NameInMap("ColumnComment")]
                [Validation(Required=false)]
                public string ColumnComment { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("ColumnPosition")]
                [Validation(Required=false)]
                public int? ColumnPosition { get; set; }

                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

            }

            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InputFormat")]
            [Validation(Required=false)]
            public string InputFormat { get; set; }

            [NameInMap("IsCompressed")]
            [Validation(Required=false)]
            public bool? IsCompressed { get; set; }

            [NameInMap("IsTemporary")]
            [Validation(Required=false)]
            public bool? IsTemporary { get; set; }

            [NameInMap("LastAccessTime")]
            [Validation(Required=false)]
            public string LastAccessTime { get; set; }

            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("OutputFormat")]
            [Validation(Required=false)]
            public string OutputFormat { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            [NameInMap("PartitionKeys")]
            [Validation(Required=false)]
            public string PartitionKeys { get; set; }

            [NameInMap("SerializationLib")]
            [Validation(Required=false)]
            public string SerializationLib { get; set; }

            [NameInMap("TableComment")]
            [Validation(Required=false)]
            public string TableComment { get; set; }

            [NameInMap("TableDesc")]
            [Validation(Required=false)]
            public string TableDesc { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("TableParameters")]
            [Validation(Required=false)]
            public string TableParameters { get; set; }

            [NameInMap("TableSize")]
            [Validation(Required=false)]
            public long? TableSize { get; set; }

            [NameInMap("TableType")]
            [Validation(Required=false)]
            public string TableType { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
