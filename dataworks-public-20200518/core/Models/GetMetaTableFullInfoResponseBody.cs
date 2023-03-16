// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableFullInfoResponseBody : TeaModel {
        /// <summary>
        /// The business data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableFullInfoResponseBodyData Data { get; set; }
        public class GetMetaTableFullInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the EMR cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The fields in the metatable.
            /// </summary>
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<GetMetaTableFullInfoResponseBodyDataColumnList> ColumnList { get; set; }
            public class GetMetaTableFullInfoResponseBodyDataColumnList : TeaModel {
                /// <summary>
                /// The description of the field.
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// The GUID of the field.
                /// </summary>
                [NameInMap("ColumnGuid")]
                [Validation(Required=false)]
                public string ColumnGuid { get; set; }

                /// <summary>
                /// The name of the field.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The data type of the field.
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// The remarks of the field.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// Indicates whether the field is a foreign key. Valid values:
                /// 
                /// *   true: The field is a foreign key.
                /// *   false: The field is not a foreign key.
                /// </summary>
                [NameInMap("IsForeignKey")]
                [Validation(Required=false)]
                public bool? IsForeignKey { get; set; }

                /// <summary>
                /// Indicates whether the field is a partition field. Valid values:
                /// 
                /// *   true: The field is a partition field.
                /// *   false: The field is not a partition field.
                /// </summary>
                [NameInMap("IsPartitionColumn")]
                [Validation(Required=false)]
                public bool? IsPartitionColumn { get; set; }

                /// <summary>
                /// Indicates whether the field is the primary key. Valid values:
                /// 
                /// *   true: The field is the primary key.
                /// *   false: The field is not the primary key.
                /// </summary>
                [NameInMap("IsPrimaryKey")]
                [Validation(Required=false)]
                public bool? IsPrimaryKey { get; set; }

                /// <summary>
                /// The ordinal number of the field.
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

            }

            /// <summary>
            /// The remarks of the metatable.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The time when the metatable was created. You can convert the timestamp to the related date based on the time zone that you use.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The amount of storage resources that are consumed by the metatable. Unit: bytes.
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The type of the environment in which the metatable resides. Valid values:
            /// 
            /// *   0: indicates that the metatable resides in the development environment.
            /// *   1: indicates that the metatable resides in the production environment.
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public int? EnvType { get; set; }

            /// <summary>
            /// The scope in which the metatable is visible. Valid values:
            /// 
            /// *   0: indicates that the metatable is visible to workspace members.
            /// *   1: indicates that the metatable is visible to users within a tenant.
            /// *   2: indicates that the metatable is visible to all tenants.
            /// *   3: indicates that the metatable is visible only to the metatable owner.
            /// </summary>
            [NameInMap("IsVisible")]
            [Validation(Required=false)]
            public int? IsVisible { get; set; }

            /// <summary>
            /// The time when the metatable was last accessed. You can convert the timestamp to the related date based on the time zone that you use.
            /// </summary>
            [NameInMap("LastAccessTime")]
            [Validation(Required=false)]
            public long? LastAccessTime { get; set; }

            /// <summary>
            /// The time when the schema of the metatable was last changed. You can convert the timestamp to the related date based on the time zone that you use.
            /// </summary>
            [NameInMap("LastDdlTime")]
            [Validation(Required=false)]
            public long? LastDdlTime { get; set; }

            /// <summary>
            /// The time when the metatable was last updated. You can convert the timestamp to the related date based on the time zone that you use.
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// The lifecycle of the metatable. Unit: days.
            /// </summary>
            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public int? LifeCycle { get; set; }

            /// <summary>
            /// The storage path of the Hive metatable.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The ID of the metatable owner.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The partition key.
            /// </summary>
            [NameInMap("PartitionKeys")]
            [Validation(Required=false)]
            public string PartitionKeys { get; set; }

            /// <summary>
            /// The ID of the workspace to which the metatable belongs.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The name of the workspace to which the metatable belongs.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// The GUID of the metatable.
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// The name of the metatable.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// The total number of fields.
            /// </summary>
            [NameInMap("TotalColumnCount")]
            [Validation(Required=false)]
            public long? TotalColumnCount { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
