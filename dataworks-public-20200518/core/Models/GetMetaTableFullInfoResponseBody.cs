// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableFullInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableFullInfoResponseBodyData Data { get; set; }
        public class GetMetaTableFullInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The EMR cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C-010A704DA760****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The fields in the table.</para>
            /// </summary>
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<GetMetaTableFullInfoResponseBodyDataColumnList> ColumnList { get; set; }
            public class GetMetaTableFullInfoResponseBodyDataColumnList : TeaModel {
                /// <summary>
                /// <para>The description of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data comment</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The unique identifier of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.engine_name.table_name.1</para>
                /// </summary>
                [NameInMap("ColumnGuid")]
                [Validation(Required=false)]
                public string ColumnGuid { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The data type of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// <para>The remarks of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>comment</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is a foreign key. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsForeignKey")]
                [Validation(Required=false)]
                public bool? IsForeignKey { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is a partition field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsPartitionColumn")]
                [Validation(Required=false)]
                public bool? IsPartitionColumn { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is a primary key. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsPrimaryKey")]
                [Validation(Required=false)]
                public bool? IsPrimaryKey { get; set; }

                /// <summary>
                /// <para>The sequence number of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

            }

            /// <summary>
            /// <para>The comment on the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the table was created. A timestamp is returned for this parameter. You can convert the timestamp to the related date based on the time zone that you use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589870293000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The size of the storage space that is consumed by the table. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The type of the environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: indicates that the table resides in the development environment.</description></item>
            /// <item><description>1: indicates that the table resides in the production environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public int? EnvType { get; set; }

            /// <summary>
            /// <para>The scope in which the table is visible. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: indicates that the table is visible to workspace members.</description></item>
            /// <item><description>1: indicates that the table is visible to users within a tenant.</description></item>
            /// <item><description>2: indicates that the table is visible to all tenants.</description></item>
            /// <item><description>3: indicates that the table is visible only to the table owner.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsVisible")]
            [Validation(Required=false)]
            public int? IsVisible { get; set; }

            /// <summary>
            /// <para>The time when the table was last accessed. A timestamp is returned for this parameter. You can convert the timestamp to the related date based on the time zone that you use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589870294000</para>
            /// </summary>
            [NameInMap("LastAccessTime")]
            [Validation(Required=false)]
            public long? LastAccessTime { get; set; }

            /// <summary>
            /// <para>The time when the schema of the table was last changed. A timestamp is returned for this parameter. You can convert the timestamp to the related date based on the time zone that you use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589870294000</para>
            /// </summary>
            [NameInMap("LastDdlTime")]
            [Validation(Required=false)]
            public long? LastDdlTime { get; set; }

            /// <summary>
            /// <para>The time when the table was last updated. A timestamp is returned for this parameter. You can convert the timestamp to the related date based on the time zone that you use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589870294000</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>The lifecycle of the table. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public int? LifeCycle { get; set; }

            /// <summary>
            /// <para>The storage path of the Hive table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdfs://localhost:777/user/hadoop/test.txt</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The ID of the table owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The partition key column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("PartitionKeys")]
            [Validation(Required=false)]
            public string PartitionKeys { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the workspace to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The schema information of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The unique identifier of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps.engine_name.table_name</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_name</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The total number of fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("TotalColumnCount")]
            [Validation(Required=false)]
            public long? TotalColumnCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
