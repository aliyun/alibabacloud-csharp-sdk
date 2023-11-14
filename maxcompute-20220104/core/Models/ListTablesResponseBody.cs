// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListTablesResponseBodyData Data { get; set; }
        public class ListTablesResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates the marker after which the returned list begins.
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// The maximum number of entries returned per page.
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            /// <summary>
            /// The information about tables.
            /// </summary>
            [NameInMap("tables")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyDataTables> Tables { get; set; }
            public class ListTablesResponseBodyDataTables : TeaModel {
                [NameInMap("autoRefreshEnabled")]
                [Validation(Required=false)]
                public bool? AutoRefreshEnabled { get; set; }

                [NameInMap("createTableDDL")]
                [Validation(Required=false)]
                public string CreateTableDDL { get; set; }

                /// <summary>
                /// The time when the table was created.
                /// </summary>
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

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nativeColumns")]
                [Validation(Required=false)]
                public List<ListTablesResponseBodyDataTablesNativeColumns> NativeColumns { get; set; }
                public class ListTablesResponseBodyDataTablesNativeColumns : TeaModel {
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

                /// <summary>
                /// The owner of the table.
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("partitionColumns")]
                [Validation(Required=false)]
                public List<ListTablesResponseBodyDataTablesPartitionColumns> PartitionColumns { get; set; }
                public class ListTablesResponseBodyDataTablesPartitionColumns : TeaModel {
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

                /// <summary>
                /// The schema of the table.
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("storageHandler")]
                [Validation(Required=false)]
                public string StorageHandler { get; set; }

                [NameInMap("tableComment")]
                [Validation(Required=false)]
                public string TableComment { get; set; }

                [NameInMap("tableLabel")]
                [Validation(Required=false)]
                public string TableLabel { get; set; }

                [NameInMap("tablesotreTableName")]
                [Validation(Required=false)]
                public string TablesotreTableName { get; set; }

                [NameInMap("tablestoreColumnsMapping")]
                [Validation(Required=false)]
                public string TablestoreColumnsMapping { get; set; }

                /// <summary>
                /// The type of the table.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("viewText")]
                [Validation(Required=false)]
                public string ViewText { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
