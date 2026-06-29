// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSubmitRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. OK indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Query result.</para>
        /// </summary>
        [NameInMap("ListResult")]
        [Validation(Required=false)]
        public ListSubmitRecordsResponseBodyListResult ListResult { get; set; }
        public class ListSubmitRecordsResponseBodyListResult : TeaModel {
            /// <summary>
            /// <para>List of pending deployment records.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListSubmitRecordsResponseBodyListResultData> Data { get; set; }
            public class ListSubmitRecordsResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <para>Change type. 0: Create / 1: Update / 2: Delete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                /// <summary>
                /// <para>Creation time in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Modification time in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>Pending deployment record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1241844456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123456</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>Object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("ObjectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>Object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>对象A</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>Object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MaxCompute SQL task: MAX_COMPUTE_SQL</description></item>
                /// <item><description>MaxCompute MR task: MAX_COMPUTE_MR</description></item>
                /// <item><description>Spark JAR on MaxCompute: SPARK_JAR_ON_MAX_COMPUTE</description></item>
                /// <item><description>Shell task: SHELL</description></item>
                /// <item><description>Python task: PYTHON</description></item>
                /// <item><description>Perl script: PERL</description></item>
                /// <item><description>Check: CHECK</description></item>
                /// <item><description>Sync task: DATA_X</description></item>
                /// <item><description>Virtual node: VIRTUAL</description></item>
                /// <item><description>Resource: IDE_RESOURCE</description></item>
                /// <item><description>Function: UDF</description></item>
                /// <item><description>Hive SQL task: HIVE_SQL</description></item>
                /// <item><description>Hadoop MR task: HADOOP_MR</description></item>
                /// <item><description>Spark JAR on Hive task: SPARK_JAR_ON_HIVE</description></item>
                /// <item><description>Flink SQL task: FLINK_SQL</description></item>
                /// <item><description>Flink SQL template task: FLINK_TEMPLATE_SQL</description></item>
                /// <item><description>Stream computing template: STREAM_TEMPLATE</description></item>
                /// <item><description>Metatable: META_TABLE</description></item>
                /// <item><description>Stream computing function: STREAM_UDF</description></item>
                /// <item><description>Real-time Flink DataStream: FLINK_DATASTREAM</description></item>
                /// <item><description>Real-time custom data source: STREAM_CUSTOM_DATASOURCE</description></item>
                /// <item><description>AnalyticDB for PostgreSQL task: ADB_FOR_PG</description></item>
                /// <item><description>TDH SQL task: INCEPTOR_SQL</description></item>
                /// <item><description>Mirror table: MIRROR_TABLE</description></item>
                /// <item><description>Intermediate table: MIDDLE_TABLE</description></item>
                /// <item><description>Application table: APPLICATION_TABLE</description></item>
                /// <item><description>Impala SQL task: IMPALA_SQL</description></item>
                /// <item><description>Offline pipeline task: OFFLINE_PIPELINE</description></item>
                /// <item><description>Real-time pipeline task: REAL_TIME_PIPELINE</description></item>
                /// <item><description>Dimension logical table: DIM_LOGICAL_TABLE</description></item>
                /// <item><description>Fact logical table: FCT_LOGICAL_TABLE</description></item>
                /// <item><description>Business condition: BIZ_CONDITION</description></item>
                /// <item><description>Atomic metric: ATOM_INDEX</description></item>
                /// <item><description>Derived metric: DERIVED_INDEX</description></item>
                /// <item><description>Calculated derived metric: CALC_DERIVED_INDEX</description></item>
                /// <item><description>PAI task: PAI_DESIGNER</description></item>
                /// <item><description>ArgoDB SQL task: ARGODB_SQL</description></item>
                /// <item><description>Hologres SQL task: HOLOGRES_SQL</description></item>
                /// <item><description>Impala SQL task: IMPALA_SQL</description></item>
                /// <item><description>StarRocks SQL task: STARROCKS_SQL</description></item>
                /// <item><description>Database SQL task: DATABASE_SQL</description></item>
                /// <item><description>Spark SQL task: SPARK_SQL</description></item>
                /// <item><description>Compute template: TASK_TEMPLATE</description></item>
                /// <item><description>External trigger node: EXTERNAL_TRIGGER</description></item>
                /// <item><description>Gauss SQL task: GAUSS_SQL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>Object version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <para>Project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1241844456</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>Submission comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>提交信息</para>
                /// </summary>
                [NameInMap("SubmitComment")]
                [Validation(Required=false)]
                public string SubmitComment { get; set; }

                /// <summary>
                /// <para>Submitter ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>307999999</para>
                /// </summary>
                [NameInMap("Submitter")]
                [Validation(Required=false)]
                public string Submitter { get; set; }

                /// <summary>
                /// <para>Submitter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("SubmitterName")]
                [Validation(Required=false)]
                public string SubmitterName { get; set; }

            }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
