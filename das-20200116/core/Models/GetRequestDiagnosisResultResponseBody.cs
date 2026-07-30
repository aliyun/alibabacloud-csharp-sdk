// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRequestDiagnosisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRequestDiagnosisResultResponseBodyData Data { get; set; }
        public class GetRequestDiagnosisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2093****</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>das</para>
            /// </summary>
            [NameInMap("dbSchema")]
            [Validation(Required=false)]
            public string DbSchema { get; set; }

            /// <summary>
            /// <para>The database engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MySQL</b></para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>SQL Server</b></para>
            /// </description></item>
            /// <item><description><para><b>PolarDB-X</b></para>
            /// </description></item>
            /// <item><description><para><b>PolarDB for Oracle</b></para>
            /// </description></item>
            /// <item><description><para><b>MongoDB</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The creation time of the SQL diagnosis, provided as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633071840000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the SQL diagnosis, provided as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633071850000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The unique ID of the diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>61820b594664275c4429****</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>The details of the SQL diagnosis result, returned as a JSON-formatted string.</para>
            /// <list type="bullet">
            /// <item><description><para><b>endTime</b>: The end time of the SQL diagnosis.</para>
            /// </description></item>
            /// <item><description><para><b>errorCode</b>: The error code.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0001</b>: The diagnosis was successful.</para>
            /// </description></item>
            /// <item><description><para><b>0003</b>: The diagnosis failed.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>errorMessage</b>: The error message.</para>
            /// </description></item>
            /// <item><description><para><b>estimateCost</b>: The estimated cost.</para>
            /// <list type="bullet">
            /// <item><description><para><b>cpu</b>: The estimated CPU cost of the query.</para>
            /// </description></item>
            /// <item><description><para><b>io</b>: The estimated I/O cost of the query.</para>
            /// </description></item>
            /// <item><description><para><b>rows</b>: The estimated number of rows returned by the query.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>improvement</b>: The performance improvement ratio.</para>
            /// </description></item>
            /// <item><description><para><b>indexAdvices</b>: The index suggestions.</para>
            /// <list type="bullet">
            /// <item><description><para><b>columns</b>: The index columns.</para>
            /// </description></item>
            /// <item><description><para><b>ddlAddIndex</b>: The DDL statement for creating the index.</para>
            /// </description></item>
            /// <item><description><para><b>indexName</b>: The index name.</para>
            /// </description></item>
            /// <item><description><para><b>schemaName</b>: The schema name.</para>
            /// </description></item>
            /// <item><description><para><b>tableName</b>: The table name.</para>
            /// </description></item>
            /// <item><description><para><b>unique</b>: Indicates whether the index is a unique index.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>ip</b>: The instance IP address.</para>
            /// </description></item>
            /// <item><description><para><b>messageId</b>: The diagnosis ID.</para>
            /// </description></item>
            /// <item><description><para><b>port</b>: The instance port.</para>
            /// </description></item>
            /// <item><description><para><b>sqlTag</b>: The SQL tags.</para>
            /// <list type="bullet">
            /// <item><description><para><b>PRED_EQUAL</b>: Equality predicate.</para>
            /// </description></item>
            /// <item><description><para><b>CNT_QB</b>: Number of query blocks.</para>
            /// </description></item>
            /// <item><description><para><b>CNT_TB</b>: Number of tables.</para>
            /// </description></item>
            /// <item><description><para><b>JOIN_LEFT</b>: Left join.</para>
            /// </description></item>
            /// <item><description><para><b>SEL_SMALL</b>: Small result set selection.</para>
            /// </description></item>
            /// <item><description><para><b>AGGR_SEL</b>: Aggregate selection.</para>
            /// </description></item>
            /// <item><description><para><b>PRED_LT_EQ / PRED_GT_EQ</b>: Less-than-or-equal-to / greater-than-or-equal-to predicate.</para>
            /// </description></item>
            /// <item><description><para><b>PRED_LIKE_PREFIX</b>: LIKE prefix match.</para>
            /// </description></item>
            /// <item><description><para><b>ORDER_BY</b>: Contains an ORDER BY clause.</para>
            /// </description></item>
            /// <item><description><para><b>LIMIT</b>: Contains a LIMIT clause.</para>
            /// </description></item>
            /// <item><description><para><b>GROUP_BY</b>: Contains a GROUP BY clause.</para>
            /// </description></item>
            /// <item><description><para><b>JOIN_INNER</b>: Inner join.</para>
            /// </description></item>
            /// <item><description><para><b>JOIN_RIGHT</b>: Right join.</para>
            /// </description></item>
            /// <item><description><para><b>HAVING</b>: Contains a HAVING clause.</para>
            /// </description></item>
            /// <item><description><para><b>UNION</b>: Contains a UNION operation.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>startTime</b>: The start time of the SQL diagnosis.</para>
            /// </description></item>
            /// <item><description><para><b>success</b>: Indicates whether the diagnosis was successful.</para>
            /// </description></item>
            /// <item><description><para><b>support</b>: Indicates whether the SQL statement can be diagnosed.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tuningAdvices</b>: The SQL rewrite suggestions.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;endTime&quot;:1636354256000, &quot;errorCode&quot;:&quot;0001&quot;, &quot;errorMessage&quot;:&quot;TFX成功&quot;, &quot;estimateCost&quot;:{ &quot;cpu&quot;:1.7878745150389268, &quot;io&quot;:9.948402604746128, &quot;rows&quot;:8.889372575194633 }, &quot;improvement&quot;:12933.97, &quot;indexAdvices&quot;:[ { &quot;columns&quot;:[ &quot;work_no&quot; ], &quot;ddlAddIndex&quot;:&quot;ALTER TABLE <c>test</c>.<c>work_order</c> ADD INDEX <c>idx_workno</c> (<c>work_no</c>)&quot;, &quot;indexName&quot;:&quot;idx_workno&quot;, &quot;schemaName&quot;:&quot;test&quot;, &quot;tableName&quot;:&quot;work_order&quot;, &quot;unique&quot;:false } ], &quot;ip&quot;:&quot;<b><b>.mysql.rds.aliyuncs.com&quot;, &quot;messageId&quot;:&quot;6188c8cb2f1365b16aee</b></b>&quot;, &quot;port&quot;:3306, &quot;sqlTag&quot;:&quot;{\&quot;PRED_EQUAL\&quot;:\&quot;Y\&quot;,\&quot;CNT_QB\&quot;:\&quot;1\&quot;,\&quot;CNT_TB\&quot;:\&quot;1\&quot;}&quot;, &quot;startTime&quot;:1636354252000, &quot;success&quot;:true, &quot;support&quot;:true, &quot;tuningAdvices&quot;:[ ] }</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The SQL template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c95dae3afef77be06572612df9b****</para>
            /// </summary>
            [NameInMap("sqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// <para>The diagnosis status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: In progress.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Diagnosis error.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Completed.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: SQL error.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Engine error.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// <para>The unique identifier of the diagnosed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdm_51fe9bc19ec413f4d530431af87a****</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>This parameter returns <c>Successful</c> if the request succeeds. If the request fails, it returns an error message, which may include an error code.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800FBAF5-A539-5B97-A09E-C63AB2F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
