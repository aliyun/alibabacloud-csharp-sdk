// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Table : TeaModel {
        [NameInMap("BusinessMetadata")]
        [Validation(Required=false)]
        public TableBusinessMetadata BusinessMetadata { get; set; }
        public class TableBusinessMetadata : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<List<TableBusinessMetadataCategories>> Categories { get; set; }
            public class TableBusinessMetadataCategories : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CATEGORY.456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试类目</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CATEGORY.123</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

            }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public TableBusinessMetadataExtension Extension { get; set; }
            public class TableBusinessMetadataExtension : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FavorCount")]
                [Validation(Required=false)]
                public long? FavorCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReadCount")]
                [Validation(Required=false)]
                public long? ReadCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ViewCount")]
                [Validation(Required=false)]
                public long? ViewCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <h2>使用说明</h2>
            /// </summary>
            [NameInMap("Readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<TableBusinessMetadataTags> Tags { get; set; }
            public class TableBusinessMetadataTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tag_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag_value</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("UpstreamTasks")]
            [Validation(Required=false)]
            public List<TableBusinessMetadataUpstreamTasks> UpstreamTasks { get; set; }
            public class TableBusinessMetadataUpstreamTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_task</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试表</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456::test_project::test_tbl</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_tbl</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-project:123456::test_project</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<string> PartitionKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("TechnicalMetadata")]
        [Validation(Required=false)]
        public TableTechnicalMetadata TechnicalMetadata { get; set; }
        public class TableTechnicalMetadata : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Compressed")]
            [Validation(Required=false)]
            public bool? Compressed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetInputFormat</para>
            /// </summary>
            [NameInMap("InputFormat")]
            [Validation(Required=false)]
            public string InputFormat { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test_tbl</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetOutputFormat</para>
            /// </summary>
            [NameInMap("OutputFormat")]
            [Validation(Required=false)]
            public string OutputFormat { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.serde.ParquetHiveSerDe</para>
            /// </summary>
            [NameInMap("SerializationLibrary")]
            [Validation(Required=false)]
            public string SerializationLibrary { get; set; }

        }

    }

}
