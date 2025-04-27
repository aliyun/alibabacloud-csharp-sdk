// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyStreamingJobRequest : TeaModel {
        /// <summary>
        /// <para>Account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-account</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The delivery guarantee setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATLEAST / EXACTLY</para>
        /// </summary>
        [NameInMap("Consistency")]
        [Validation(Required=false)]
        public string Consistency { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModifyStreamingJob</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Target data table mapping field list.</para>
        /// </summary>
        [NameInMap("DestColumns")]
        [Validation(Required=false)]
        public List<string> DestColumns { get; set; }

        /// <summary>
        /// <para>Target database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-db</para>
        /// </summary>
        [NameInMap("DestDatabase")]
        [Validation(Required=false)]
        public string DestDatabase { get; set; }

        /// <summary>
        /// <para>Target schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-schema</para>
        /// </summary>
        [NameInMap("DestSchema")]
        [Validation(Required=false)]
        public string DestSchema { get; set; }

        /// <summary>
        /// <para>Target table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-table</para>
        /// </summary>
        [NameInMap("DestTable")]
        [Validation(Required=false)]
        public string DestTable { get; set; }

        /// <summary>
        /// <para>When the data in Kafka does not match the ADBPG target table, it will cause a write failure. This value is the number of error rows allowed; exceeding this will cause the task to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ErrorLimitCount")]
        [Validation(Required=false)]
        public long? ErrorLimitCount { get; set; }

        /// <summary>
        /// <para>The fallback offset for data consumption.</para>
        /// <list type="bullet">
        /// <item><description>This parameter specifies the starting offset from which data consumption resumes when a consumer does not request a consumption offset or requests a consumption offset that is beyond the range of the offset information recorded in the current Kafka cluster. You can choose to start data consumption from the earliest or latest offset.</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EARLIEST</description></item>
        /// <item><description>LATEST</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EARLIEST /  LATEST</para>
        /// </summary>
        [NameInMap("FallbackOffset")]
        [Validation(Required=false)]
        public string FallbackOffset { get; set; }

        /// <summary>
        /// <para>Kafka group name</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_name</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Job configuration file, required for professional mode.</para>
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
        /// <para>Job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-job</para>
        /// </summary>
        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// <para>Job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>Match columns, usually all primary key columns of the target table. If all column values in this configuration are the same, the two rows of data are considered duplicates.</para>
        /// </summary>
        [NameInMap("MatchColumns")]
        [Validation(Required=false)]
        public List<string> MatchColumns { get; set; }

        /// <summary>
        /// <para>Password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pwd123</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> API to view available region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Source data field list.</para>
        /// </summary>
        [NameInMap("SrcColumns")]
        [Validation(Required=false)]
        public List<string> SrcColumns { get; set; }

        /// <summary>
        /// <para>Specifies whether to test the real-time job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TryRun")]
        [Validation(Required=false)]
        public bool? TryRun { get; set; }

        /// <summary>
        /// <para>Update columns, usually all non-primary key columns of the target table. When data duplication is determined through MatchColumns, updating the UpdateColumns column values will result in new data overwriting old data.</para>
        /// </summary>
        [NameInMap("UpdateColumns")]
        [Validation(Required=false)]
        public List<string> UpdateColumns { get; set; }

        /// <summary>
        /// <para>The write mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MERGE</description></item>
        /// <item><description>INSERT</description></item>
        /// <item><description>UPDATE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INSERT/UPDATE/MERGE</para>
        /// </summary>
        [NameInMap("WriteMode")]
        [Validation(Required=false)]
        public string WriteMode { get; set; }

    }

}
