// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class CreateExecuteSqlConversionRequest : TeaModel {
        /// <summary>
        /// <para>The source dialect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("sourceDialect")]
        [Validation(Required=false)]
        public string SourceDialect { get; set; }

        /// <summary>
        /// <para>The list of source SQL scripts.</para>
        /// </summary>
        [NameInMap("sourceSqlScript")]
        [Validation(Required=false)]
        public List<CreateExecuteSqlConversionRequestSourceSqlScript> SourceSqlScript { get; set; }
        public class CreateExecuteSqlConversionRequestSourceSqlScript : TeaModel {
            /// <summary>
            /// <para>The error reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connection timeout</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the conversion is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("scriptId")]
            [Validation(Required=false)]
            public long? ScriptId { get; set; }

            /// <summary>
            /// <para>The script name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_script_demo</para>
            /// </summary>
            [NameInMap("scriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The script conversion status. In conversion job scenarios, valid values: pass (conversion succeeded), turning (conversion in progress), fail (conversion failed). In some scenarios, the following values are used: success (succeeded), failed (failed), skipped (skipped).</para>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("scriptTransformStatus")]
            [Validation(Required=false)]
            public string ScriptTransformStatus { get; set; }

            /// <summary>
            /// <para>The converted script content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("sqlResultContent")]
            [Validation(Required=false)]
            public string SqlResultContent { get; set; }

            /// <summary>
            /// <para>The original script content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("sqlSourceContent")]
            [Validation(Required=false)]
            public string SqlSourceContent { get; set; }

            /// <summary>
            /// <para>The table name mappings for conversion.</para>
            /// </summary>
            [NameInMap("tableMappingList")]
            [Validation(Required=false)]
            public List<CreateExecuteSqlConversionRequestSourceSqlScriptTableMappingList> TableMappingList { get; set; }
            public class CreateExecuteSqlConversionRequestSourceSqlScriptTableMappingList : TeaModel {
                /// <summary>
                /// <para>The primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The source type. Valid values: DB and Schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db_demo</para>
                /// </summary>
                [NameInMap("sourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                /// <summary>
                /// <para>The source table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_demo</para>
                /// </summary>
                [NameInMap("sourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// <para>The target table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_demo</para>
                /// </summary>
                [NameInMap("targetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

                /// <summary>
                /// <para>The target type. Valid values: DB and Schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hive</para>
                /// </summary>
                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The SQL conversion task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        /// <summary>
        /// <para>The target dialect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("targetDialect")]
        [Validation(Required=false)]
        public string TargetDialect { get; set; }

        /// <summary>
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data validation task description</para>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_check_task_demo</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The script type. Valid values: 0 (DDL) and 1 (DQL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
