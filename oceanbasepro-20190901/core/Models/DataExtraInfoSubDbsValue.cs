// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DataExtraInfoSubDbsValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cluster_name</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tenant_name</para>
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>db_name</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mapped_db</para>
        /// </summary>
        [NameInMap("MappingDatabaseName")]
        [Validation(Required=false)]
        public string MappingDatabaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SourceClientId")]
        [Validation(Required=false)]
        public string SourceClientId { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DataExtraInfoSubDbsValueTables> Tables { get; set; }
        public class DataExtraInfoSubDbsValueTables : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>fexg***</para>
            /// </summary>
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>db_name</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table_name</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mapped_table</para>
            /// </summary>
            [NameInMap("MappingTableName")]
            [Validation(Required=false)]
            public string MappingTableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>g_i4kat***</para>
            /// </summary>
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<DataExtraInfoSubDbsValueTablesColumns> Columns { get; set; }
            public class DataExtraInfoSubDbsValueTablesColumns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RecordFieldType")]
                [Validation(Required=false)]
                public string RecordFieldType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RawColumnType")]
                [Validation(Required=false)]
                public string RawColumnType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ColumnKey")]
                [Validation(Required=false)]
                public string ColumnKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("DataLength")]
                [Validation(Required=false)]
                public long? DataLength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("DataPrecision")]
                [Validation(Required=false)]
                public int? DataPrecision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("DataScale")]
                [Validation(Required=false)]
                public int? DataScale { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>comments</para>
                /// </summary>
                [NameInMap("ColumnComment")]
                [Validation(Required=false)]
                public string ColumnComment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsGenerateField")]
                [Validation(Required=false)]
                public bool? IsGenerateField { get; set; }

            }

        }

    }

}
