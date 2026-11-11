// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeStreamingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The destination database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-account</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The delivery guarantee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATLEAST / EXACTLY</para>
        /// </summary>
        [NameInMap("Consistency")]
        [Validation(Required=false)]
        public string Consistency { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_kafka</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The list of mapped columns in the destination table.</para>
        /// </summary>
        [NameInMap("DestColumns")]
        [Validation(Required=false)]
        public List<string> DestColumns { get; set; }

        /// <summary>
        /// <para>The destination database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-db</para>
        /// </summary>
        [NameInMap("DestDatabase")]
        [Validation(Required=false)]
        public string DestDatabase { get; set; }

        /// <summary>
        /// <para>The destination namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-schema</para>
        /// </summary>
        [NameInMap("DestSchema")]
        [Validation(Required=false)]
        public string DestSchema { get; set; }

        /// <summary>
        /// <para>The destination table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-table</para>
        /// </summary>
        [NameInMap("DestTable")]
        [Validation(Required=false)]
        public string DestTable { get; set; }

        /// <summary>
        /// <para>The maximum number of allowed error rows. If data in Kafka does not match the destination AnalyticDB for PostgreSQL table, a write failure occurs. If the number of error rows exceeds this value, the job fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ErrorLimitCount")]
        [Validation(Required=false)]
        public int? ErrorLimitCount { get; set; }

        /// <summary>
        /// <para>The service status message. For example, if an exception occurs, the cause of the exception is displayed. This parameter is empty when the service is in the Running state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The fallback offset.</para>
        /// <list type="bullet">
        /// <item><description>The FallbackOffset parameter defines the behavior when a consumer does not request a specific offset to consume, or when the requested offset exceeds the offset range recorded in the current Kafka cluster. You can choose to start consuming from the earliest or latest offset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EARLIEST /  LATEST</para>
        /// </summary>
        [NameInMap("FallbackOffset")]
        [Validation(Required=false)]
        public string FallbackOffset { get; set; }

        /// <summary>
        /// <para>The Kafka group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The job configuration file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATABASE: adbpgss_test
        /// USER: adbpgss_test
        /// PASSWORD: adbpgssTest
        /// HOST: gp-xxx-master.gpdb.rds-aliyun-pre.rds.aliyuncs.com
        /// PORT: 5432
        /// KAFKA:
        ///   INPUT:
        ///     SOURCE:
        ///       BROKERS: broker1:9092,broker2:9092,broker3:9092
        ///       TOPIC: testtopic
        ///       FALLBACK_OFFSET: earliest
        ///     KEY:
        ///       COLUMNS:
        ///       - NAME: customer_id
        ///         TYPE: int
        ///       FORMAT: delimited
        ///       DELIMITED_OPTION:
        ///         DELIMITER: \&quot;|\&quot;
        ///     VALUE:
        ///       COLUMNS:
        ///       - TYPE: integer
        ///         NAME: l_orderkey
        ///       - TYPE: integer
        ///         NAME: l_partkey
        ///       - TYPE: integer
        ///         NAME: l_suppkey
        ///       - TYPE: integer
        ///         NAME: l_linenumber
        ///       - TYPE: decimal
        ///         NAME: l_quantity
        ///       - TYPE: decimal
        ///         NAME: l_extendedprice
        ///       - TYPE: decimal
        ///         NAME: l_discount
        ///       - TYPE: decimal
        ///         NAME: l_tax
        ///       - TYPE: char
        ///         NAME: l_returnflag
        ///       - TYPE: char
        ///         NAME: l_linestatus
        ///       - TYPE: date
        ///         NAME: l_shipdate
        ///       - TYPE: date
        ///         NAME: l_commitdate
        ///       - TYPE: date
        ///         NAME: l_receiptdate
        ///       - TYPE: text
        ///         NAME: l_shipinstruct
        ///       - TYPE: text
        ///         NAME: l_shipmode
        ///       - TYPE: text
        ///         NAME: l_comment
        ///       FORMAT: delimited
        ///       DELIMITED_OPTION:
        ///         DELIMITER: \&quot;|\&quot;
        ///     ERROR_LIMIT: 10
        ///   OUTPUT:
        ///     SCHEMA: adbpgss_test
        ///     TABLE: write_with_insert_plaintext
        ///     MODE: MERGE
        ///     MATCH_COLUMNS:
        ///     - l_orderkey
        ///     - l_partkey
        ///     - l_suppkey
        ///     UPDATE_COLUMNS:
        ///     - l_linenumber
        ///     - l_quantity
        ///     - l_extendedprice
        ///     - l_discount
        ///     - l_tax
        ///     - l_returnflag
        ///     - l_linestatus
        ///     - l_shipdate
        ///     - l_commitdate
        ///     - l_receiptdate
        ///     - l_shipinstruct
        ///     - l_shipmode
        ///     - l_comment
        ///     MAPPING:
        ///     - EXPRESSION: l_orderkey
        ///       NAME: l_orderkey
        ///     - EXPRESSION: l_partkey
        ///       NAME: l_partkey
        ///     - EXPRESSION: l_suppkey
        ///       NAME: l_suppkey
        ///     - EXPRESSION: l_linenumber
        ///       NAME: l_linenumber
        ///     - EXPRESSION: l_quantity
        ///       NAME: l_quantity
        ///     - EXPRESSION: l_extendedprice
        ///       NAME: l_extendedprice
        ///     - EXPRESSION: l_discount
        ///       NAME: l_discount
        ///     - EXPRESSION: l_tax
        ///       NAME: l_tax
        ///     - EXPRESSION: l_returnflag
        ///       NAME: l_returnflag
        ///     - EXPRESSION: l_linestatus
        ///       NAME: l_linestatus
        ///     - EXPRESSION: l_shipdate
        ///       NAME: l_shipdate
        ///     - EXPRESSION: l_commitdate
        ///       NAME: l_commitdate
        ///     - EXPRESSION: l_receiptdate
        ///       NAME: l_receiptdate
        ///     - EXPRESSION: l_shipinstruct
        ///       NAME: l_shipinstruct
        ///     - EXPRESSION: l_shipmode
        ///       NAME: l_shipmode
        ///     - EXPRESSION: l_comment
        ///       NAME: l_comment
        ///   COMMIT:
        ///     MAX_ROW: 1000
        ///     MINIMAL_INTERVAL: 1000
        ///     CONSISTENCY: ATLEAST
        ///   POLL:
        ///     BATCHSIZE: 1000
        ///     TIMEOUT: 1000
        ///   PROPERTIES:
        ///     group.id: testgroup</para>
        /// </summary>
        [NameInMap("JobConfig")]
        [Validation(Required=false)]
        public string JobConfig { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_job</para>
        /// </summary>
        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-job</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The match columns. Typically, these are all primary key columns of the destination table. If the values of all columns in this configuration are the same, the two rows of data are considered duplicate.</para>
        /// </summary>
        [NameInMap("MatchColumns")]
        [Validation(Required=false)]
        public List<string> MatchColumns { get; set; }

        /// <summary>
        /// <para>The configuration mode.</para>
        /// <ol>
        /// <item><description>basic: requires specific configuration fields.</description></item>
        /// <item><description>professional: supports submitting YAML files.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>basic/professional</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T17:00:00Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The destination database password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pwd123</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of source columns.</para>
        /// </summary>
        [NameInMap("SrcColumns")]
        [Validation(Required=false)]
        public List<string> SrcColumns { get; set; }

        /// <summary>
        /// <para>The service status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Init: initializing.</para>
        /// </description></item>
        /// <item><description><para>Running: running.</para>
        /// </description></item>
        /// <item><description><para>Exception: an exception occurred.</para>
        /// </description></item>
        /// <item><description><para>Paused: paused.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update columns. Typically, these are all non-primary key columns of the destination table. When duplicate data is identified based on the match columns, the values of the update columns are updated so that the new data overwrites the old data.</para>
        /// </summary>
        [NameInMap("UpdateColumns")]
        [Validation(Required=false)]
        public List<string> UpdateColumns { get; set; }

        /// <summary>
        /// <para>The write mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSERT/UPDATE/MERGE</para>
        /// </summary>
        [NameInMap("WriteMode")]
        [Validation(Required=false)]
        public string WriteMode { get; set; }

    }

}
