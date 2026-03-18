// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStoragePartitionsInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListStoragePartitionsInfoResponseBodyData Data { get; set; }
        public class ListStoragePartitionsInfoResponseBodyData : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("storagePartitionInfoList")]
            [Validation(Required=false)]
            public List<ListStoragePartitionsInfoResponseBodyDataStoragePartitionInfoList> StoragePartitionInfoList { get; set; }
            public class ListStoragePartitionsInfoResponseBodyDataStoragePartitionInfoList : TeaModel {
                [NameInMap("fileCount")]
                [Validation(Required=false)]
                public long? FileCount { get; set; }

                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public double? FileSize { get; set; }

                [NameInMap("fileSizeUnit")]
                [Validation(Required=false)]
                public string FileSizeUnit { get; set; }

                [NameInMap("isPartitioned")]
                [Validation(Required=false)]
                public bool? IsPartitioned { get; set; }

                [NameInMap("lastAccessTime")]
                [Validation(Required=false)]
                public long? LastAccessTime { get; set; }

                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("totalFrequency")]
                [Validation(Required=false)]
                public long? TotalFrequency { get; set; }

                [NameInMap("totalInputAmount")]
                [Validation(Required=false)]
                public double? TotalInputAmount { get; set; }

                [NameInMap("totalInputAmountUnit")]
                [Validation(Required=false)]
                public string TotalInputAmountUnit { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
