// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStorageTablesInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListStorageTablesInfoResponseBodyData Data { get; set; }
        public class ListStorageTablesInfoResponseBodyData : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("storageTableInfoList")]
            [Validation(Required=false)]
            public List<ListStorageTablesInfoResponseBodyDataStorageTableInfoList> StorageTableInfoList { get; set; }
            public class ListStorageTablesInfoResponseBodyDataStorageTableInfoList : TeaModel {
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("isPartitioned")]
                [Validation(Required=false)]
                public bool? IsPartitioned { get; set; }

                [NameInMap("lastAccessTime")]
                [Validation(Required=false)]
                public long? LastAccessTime { get; set; }

                [NameInMap("longTermStorage")]
                [Validation(Required=false)]
                public double? LongTermStorage { get; set; }

                [NameInMap("longTermStorageFileCount")]
                [Validation(Required=false)]
                public long? LongTermStorageFileCount { get; set; }

                [NameInMap("longTermStorageUnit")]
                [Validation(Required=false)]
                public string LongTermStorageUnit { get; set; }

                [NameInMap("lowFreqStorage")]
                [Validation(Required=false)]
                public double? LowFreqStorage { get; set; }

                [NameInMap("lowFreqStorageFileCount")]
                [Validation(Required=false)]
                public long? LowFreqStorageFileCount { get; set; }

                [NameInMap("lowFreqStorageUnit")]
                [Validation(Required=false)]
                public string LowFreqStorageUnit { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("standardStorage")]
                [Validation(Required=false)]
                public double? StandardStorage { get; set; }

                [NameInMap("standardStorageFileCount")]
                [Validation(Required=false)]
                public long? StandardStorageFileCount { get; set; }

                [NameInMap("standardStorageUnit")]
                [Validation(Required=false)]
                public string StandardStorageUnit { get; set; }

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

                [NameInMap("totalStorage")]
                [Validation(Required=false)]
                public double? TotalStorage { get; set; }

                [NameInMap("totalStorageFileCount")]
                [Validation(Required=false)]
                public long? TotalStorageFileCount { get; set; }

                [NameInMap("totalStorageUnit")]
                [Validation(Required=false)]
                public string TotalStorageUnit { get; set; }

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
