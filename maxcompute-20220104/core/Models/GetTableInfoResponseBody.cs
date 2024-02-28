// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetTableInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTableInfoResponseBodyData Data { get; set; }
        public class GetTableInfoResponseBodyData : TeaModel {
            [NameInMap("autoRefreshEnabled")]
            [Validation(Required=false)]
            public bool? AutoRefreshEnabled { get; set; }

            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("createTableDDL")]
            [Validation(Required=false)]
            public string CreateTableDDL { get; set; }

            [NameInMap("creationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("fileNum")]
            [Validation(Required=false)]
            public long? FileNum { get; set; }

            [NameInMap("isExternalTable")]
            [Validation(Required=false)]
            public bool? IsExternalTable { get; set; }

            [NameInMap("isOutdated")]
            [Validation(Required=false)]
            public bool? IsOutdated { get; set; }

            [NameInMap("lastAccessTime")]
            [Validation(Required=false)]
            public long? LastAccessTime { get; set; }

            [NameInMap("lastDDLTime")]
            [Validation(Required=false)]
            public long? LastDDLTime { get; set; }

            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            [NameInMap("lifecycle")]
            [Validation(Required=false)]
            public string Lifecycle { get; set; }

            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("materializedView")]
            [Validation(Required=false)]
            public bool? MaterializedView { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nativeColumns")]
            [Validation(Required=false)]
            public List<GetTableInfoResponseBodyDataNativeColumns> NativeColumns { get; set; }
            public class GetTableInfoResponseBodyDataNativeColumns : TeaModel {
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("odpsPropertiesRolearn")]
            [Validation(Required=false)]
            public string OdpsPropertiesRolearn { get; set; }

            [NameInMap("odpsSqlTextOptionFlushHeader")]
            [Validation(Required=false)]
            public bool? OdpsSqlTextOptionFlushHeader { get; set; }

            [NameInMap("odpsTextOptionHeaderLinesCount")]
            [Validation(Required=false)]
            public long? OdpsTextOptionHeaderLinesCount { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("partitionColumns")]
            [Validation(Required=false)]
            public List<GetTableInfoResponseBodyDataPartitionColumns> PartitionColumns { get; set; }
            public class GetTableInfoResponseBodyDataPartitionColumns : TeaModel {
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("physicalSize")]
            [Validation(Required=false)]
            public long? PhysicalSize { get; set; }

            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("rewriteEnabled")]
            [Validation(Required=false)]
            public bool? RewriteEnabled { get; set; }

            [NameInMap("schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("storageHandler")]
            [Validation(Required=false)]
            public string StorageHandler { get; set; }

            [NameInMap("tableLabel")]
            [Validation(Required=false)]
            public string TableLabel { get; set; }

            [NameInMap("tablesotreTableName")]
            [Validation(Required=false)]
            public string TablesotreTableName { get; set; }

            [NameInMap("tablestoreColumnsMapping")]
            [Validation(Required=false)]
            public string TablestoreColumnsMapping { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("viewText")]
            [Validation(Required=false)]
            public string ViewText { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
