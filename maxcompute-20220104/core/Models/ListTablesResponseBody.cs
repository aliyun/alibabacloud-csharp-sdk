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
                /// <summary>
                /// Indicates whether to enable the scheduled update feature for the materialized view.
                /// </summary>
                [NameInMap("autoRefreshEnabled")]
                [Validation(Required=false)]
                public bool? AutoRefreshEnabled { get; set; }

                /// <summary>
                /// The DDL statement that is used to create the table.
                /// </summary>
                [NameInMap("createTableDDL")]
                [Validation(Required=false)]
                public string CreateTableDDL { get; set; }

                /// <summary>
                /// The time when the table was created.
                /// </summary>
                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                /// <summary>
                /// The display name of the table.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The number of files.
                /// </summary>
                [NameInMap("fileNum")]
                [Validation(Required=false)]
                public long? FileNum { get; set; }

                /// <summary>
                /// Indicates whether the table is an external table.
                /// </summary>
                [NameInMap("isExternalTable")]
                [Validation(Required=false)]
                public bool? IsExternalTable { get; set; }

                /// <summary>
                /// Indicates whether the data in the materialized view is invalid due to data changes in the source table.
                /// </summary>
                [NameInMap("isOutdated")]
                [Validation(Required=false)]
                public bool? IsOutdated { get; set; }

                /// <summary>
                /// The time when the data was last accessed.
                /// </summary>
                [NameInMap("lastAccessTime")]
                [Validation(Required=false)]
                public long? LastAccessTime { get; set; }

                /// <summary>
                /// The last time when the DDL statement of the table was updated.
                /// </summary>
                [NameInMap("lastDDLTime")]
                [Validation(Required=false)]
                public long? LastDDLTime { get; set; }

                /// <summary>
                /// The time when the data was last updated.
                /// </summary>
                [NameInMap("lastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                /// <summary>
                /// The lifecycle of the table.
                /// </summary>
                [NameInMap("lifecycle")]
                [Validation(Required=false)]
                public string Lifecycle { get; set; }

                /// <summary>
                /// The storage location of the external table.
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// Indicates whether a materialized view is created.
                /// </summary>
                [NameInMap("materializedView")]
                [Validation(Required=false)]
                public bool? MaterializedView { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The information about columns.
                /// </summary>
                [NameInMap("nativeColumns")]
                [Validation(Required=false)]
                public List<ListTablesResponseBodyDataTablesNativeColumns> NativeColumns { get; set; }
                public class ListTablesResponseBodyDataTablesNativeColumns : TeaModel {
                    /// <summary>
                    /// The remarks.
                    /// </summary>
                    [NameInMap("comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// The security level of the column.
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The name of the column.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the column.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of AliyunODPSDefaultRole in Resource Access Management (RAM).
                /// </summary>
                [NameInMap("odpsPropertiesRolearn")]
                [Validation(Required=false)]
                public string OdpsPropertiesRolearn { get; set; }

                /// <summary>
                /// Indicates whether to ignore the table header.
                /// </summary>
                [NameInMap("odpsSqlTextOptionFlushHeader")]
                [Validation(Required=false)]
                public bool? OdpsSqlTextOptionFlushHeader { get; set; }

                /// <summary>
                /// Indicates whether to ignore the first N rows of the table header.
                /// </summary>
                [NameInMap("odpsTextOptionHeaderLinesCount")]
                [Validation(Required=false)]
                public long? OdpsTextOptionHeaderLinesCount { get; set; }

                /// <summary>
                /// The owner of the table.
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The information about the partition column.
                /// </summary>
                [NameInMap("partitionColumns")]
                [Validation(Required=false)]
                public List<ListTablesResponseBodyDataTablesPartitionColumns> PartitionColumns { get; set; }
                public class ListTablesResponseBodyDataTablesPartitionColumns : TeaModel {
                    /// <summary>
                    /// The remarks.
                    /// </summary>
                    [NameInMap("comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// The security level of the partition column.
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The name of the partition column.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the partition column.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The physical size of the table.
                /// </summary>
                [NameInMap("physicalSize")]
                [Validation(Required=false)]
                public long? PhysicalSize { get; set; }

                /// <summary>
                /// The name of the project.
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// Indicates whether to enable the query rewrite operation that is performed based on the materialized view.
                /// </summary>
                [NameInMap("rewriteEnabled")]
                [Validation(Required=false)]
                public bool? RewriteEnabled { get; set; }

                /// <summary>
                /// The schema to which the table belongs.
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// The size of the table.
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The extractor of the external table.
                /// </summary>
                [NameInMap("storageHandler")]
                [Validation(Required=false)]
                public string StorageHandler { get; set; }

                /// <summary>
                /// The description of the table.
                /// </summary>
                [NameInMap("tableComment")]
                [Validation(Required=false)]
                public string TableComment { get; set; }

                /// <summary>
                /// The security level of the table.
                /// </summary>
                [NameInMap("tableLabel")]
                [Validation(Required=false)]
                public string TableLabel { get; set; }

                /// <summary>
                /// The name of the Tablestore table that you want MaxCompute to access.
                /// </summary>
                [NameInMap("tablesotreTableName")]
                [Validation(Required=false)]
                public string TablesotreTableName { get; set; }

                /// <summary>
                /// The columns of the Tablestore table that you want MaxCompute to access. The columns include primary key columns and attribute columns.
                /// </summary>
                [NameInMap("tablestoreColumnsMapping")]
                [Validation(Required=false)]
                public string TablestoreColumnsMapping { get; set; }

                /// <summary>
                /// The type of the table.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The statement that is used to generate the view.
                /// </summary>
                [NameInMap("viewText")]
                [Validation(Required=false)]
                public string ViewText { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
