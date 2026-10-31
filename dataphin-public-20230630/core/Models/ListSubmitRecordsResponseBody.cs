// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSubmitRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("ListResult")]
        [Validation(Required=false)]
        public ListSubmitRecordsResponseBodyListResult ListResult { get; set; }
        public class ListSubmitRecordsResponseBodyListResult : TeaModel {
            /// <summary>
            /// <para>The list of pending publish records.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListSubmitRecordsResponseBodyListResultData> Data { get; set; }
            public class ListSubmitRecordsResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <para>The change type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: create</description></item>
                /// <item><description>1: update</description></item>
                /// <item><description>2: delete</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                /// <summary>
                /// <para>The time when the record was created. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the record was updated. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The ID of the pending publish record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1241844456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123456</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The ID of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("ObjectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The name of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Object A</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MAX_COMPUTE_SQL: MaxCompute SQL node</description></item>
                /// <item><description>MAX_COMPUTE_MR: MaxCompute MR node</description></item>
                /// <item><description>SPARK_JAR_ON_MAX_COMPUTE: Spark JAR on MaxCompute node</description></item>
                /// <item><description>SHELL: Shell node</description></item>
                /// <item><description>PYTHON: Python node</description></item>
                /// <item><description>PERL: Perl script</description></item>
                /// <item><description>CHECK: Check node</description></item>
                /// <item><description>DATA_X: Data synchronization node</description></item>
                /// <item><description>VIRTUAL: Virtual node</description></item>
                /// <item><description>IDE_RESOURCE: Resource</description></item>
                /// <item><description>UDF: Function</description></item>
                /// <item><description>HIVE_SQL: Hive SQL node</description></item>
                /// <item><description>HADOOP_MR: Hadoop MR node</description></item>
                /// <item><description>SPARK_JAR_ON_HIVE: Spark JAR on Hive node</description></item>
                /// <item><description>FLINK_SQL: Flink SQL node</description></item>
                /// <item><description>FLINK_TEMPLATE_SQL: Flink SQL template node</description></item>
                /// <item><description>STREAM_TEMPLATE: Stream computing template</description></item>
                /// <item><description>META_TABLE: Metatable</description></item>
                /// <item><description>STREAM_UDF: Stream computing function</description></item>
                /// <item><description>FLINK_DATASTREAM: Real-time Flink DataStream node</description></item>
                /// <item><description>STREAM_CUSTOM_DATASOURCE: Real-time custom data source</description></item>
                /// <item><description>ADB_FOR_PG: AnalyticDB for PostgreSQL node</description></item>
                /// <item><description>INCEPTOR_SQL: Inceptor SQL node</description></item>
                /// <item><description>MIRROR_TABLE: Mirror table</description></item>
                /// <item><description>MIDDLE_TABLE: Intermediate table</description></item>
                /// <item><description>APPLICATION_TABLE: Application table</description></item>
                /// <item><description>IMPALA_SQL: Impala SQL node</description></item>
                /// <item><description>OFFLINE_PIPELINE: Offline pipeline node</description></item>
                /// <item><description>REAL_TIME_PIPELINE: Real-time pipeline node</description></item>
                /// <item><description>DIM_LOGICAL_TABLE: Logical dimension table</description></item>
                /// <item><description>FCT_LOGICAL_TABLE: Logical fact table</description></item>
                /// <item><description>BIZ_CONDITION: Business filter</description></item>
                /// <item><description>ATOM_INDEX: Atomic metric</description></item>
                /// <item><description>DERIVED_INDEX: Derived metric</description></item>
                /// <item><description>CALC_DERIVED_INDEX: Derivative metric</description></item>
                /// <item><description>PAI_DESIGNER: PAI Designer node</description></item>
                /// <item><description>ARGODB_SQL: ArgoDB SQL node</description></item>
                /// <item><description>HOLOGRES_SQL: Hologres SQL node</description></item>
                /// <item><description>IMPALA_SQL: Impala SQL node</description></item>
                /// <item><description>STARROCKS_SQL: StarRocks SQL node</description></item>
                /// <item><description>DATABASE_SQL: Database SQL node</description></item>
                /// <item><description>SPARK_SQL: Spark SQL node</description></item>
                /// <item><description>TASK_TEMPLATE: Task template</description></item>
                /// <item><description>EXTERNAL_TRIGGER: External trigger node</description></item>
                /// <item><description>GAUSS_SQL: Gauss SQL node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The version of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1241844456</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The submission comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Submission comment</para>
                /// </summary>
                [NameInMap("SubmitComment")]
                [Validation(Required=false)]
                public string SubmitComment { get; set; }

                /// <summary>
                /// <para>The ID of the submitter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>307999999</para>
                /// </summary>
                [NameInMap("Submitter")]
                [Validation(Required=false)]
                public string Submitter { get; set; }

                /// <summary>
                /// <para>The name of the submitter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("SubmitterName")]
                [Validation(Required=false)]
                public string SubmitterName { get; set; }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
