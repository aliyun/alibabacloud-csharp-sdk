// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityArchiveTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of querying the anomaly archived table list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityArchiveTablesResponseBodyData Data { get; set; }
        public class ListQualityArchiveTablesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of anomaly archived tables.</para>
            /// </summary>
            [NameInMap("ArchiveTableList")]
            [Validation(Required=false)]
            public List<ListQualityArchiveTablesResponseBodyDataArchiveTableList> ArchiveTableList { get; set; }
            public class ListQualityArchiveTablesResponseBodyDataArchiveTableList : TeaModel {
                /// <summary>
                /// <para>The ID of the archived table. This ID is used when you update, switch to active, or delete the archived table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7673533</para>
                /// </summary>
                [NameInMap("ArchiveTableId")]
                [Validation(Required=false)]
                public long? ArchiveTableId { get; set; }

                /// <summary>
                /// <para>The full table name in the format of project_name.table_name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Train.a01_reanme_exception_data</para>
                /// </summary>
                [NameInMap("ArchiveTableName")]
                [Validation(Required=false)]
                public string ArchiveTableName { get; set; }

                /// <summary>
                /// <para>The DDL statement for creating the archived table, which includes dataphin_quality_* system fields and the dataphin_quality_validate_date partition field definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create table mfg_fin_cdm.a_shixin_b_exception_data\n         (  \n            dataphin_quality_tenant_id varchar(64) comment \&quot;Tenant ID\&quot;\n         , \n            dataphin_quality_rule_id varchar(64) comment \&quot;Quality rule ID\&quot;\n         , \n            dataphin_quality_rule_name string comment \&quot;Quality rule name\&quot;\n         , \n            dataphin_quality_column_name varchar(1024) comment \&quot;Validation field name\&quot;\n         , \n            dataphin_quality_watch_task_id varchar(128) comment \&quot;Monitored object task ID\&quot;\n         , \n            dataphin_quality_rule_task_id varchar(64) comment \&quot;Rule task ID\&quot;\n         , \n            dataphin_quality_validate_time varchar(64) comment \&quot;Quality validation time\&quot;\n         , \n            dataphin_quality_archive_mode varchar(32) comment \&quot;Anomaly archiving mode, ONLY_ERROR_FIELD/FULL_RECORD\&quot;\n         , \n            dataphin_quality_error_data string comment \&quot;Anomaly data\&quot;\n         , \n            执行依据文号 string comment \&quot;\&quot;\n         , \n            立案时间 string comment \&quot;\&quot;\n         , \n            案号 string comment \&quot;\&quot;\n         , \n            执行法院 string comment \&quot;\&quot;\n         , \n            性别 string comment \&quot;\&quot;\n         , \n            省份 string comment \&quot;\&quot;\n         , \n            被执行人的履行情况 string comment \&quot;\&quot;\n         , \n            发布时间 string comment \&quot;\&quot;\n         , \n            姓名 string comment \&quot;\&quot;\n         , \n            身份证号 string comment \&quot;\&quot;\n         , \n            失信被执行人行为具体情形 string comment \&quot;\&quot;\n         ) \n        partitioned by (dataphin_quality_validate_date string comment \&quot;Validation date (partition field)\&quot;)</para>
                /// </summary>
                [NameInMap("Ddl")]
                [Validation(Required=false)]
                public string Ddl { get; set; }

                /// <summary>
                /// <para>Indicates whether this is the active archived table. At least one active archived table must exist under the same monitored object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The lifecycle in days. An empty value indicates no lifecycle is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public int? Lifecycle { get; set; }

                /// <summary>
                /// <para>The maximum number of records to archive per validation. A value of -1 indicates full archiving.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("MaxArchiveCount")]
                [Validation(Required=false)]
                public long? MaxArchiveCount { get; set; }

            }

            /// <summary>
            /// <para>The number of custom anomaly archived tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

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
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
