// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRequestDiagnosisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
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
            /// <para>The name of the database.</para>
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
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>PostgreSQL</b></description></item>
            /// <item><description><b>SQLServer</b></description></item>
            /// <item><description><b>PolarDBMySQL</b></description></item>
            /// <item><description><b>PolarDBOracle</b></description></item>
            /// <item><description><b>MongoDB</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The time when the SQL diagnostics task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633071840000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the SQL diagnostics task was modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633071850000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The unique ID of the diagnostics task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>61820b594664275c4429****</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>The result of the SQL diagnostics task. The result includes the following information:</para>
            /// <list type="bullet">
            /// <item><description><para><b>endTime</b>: the end time of the SQL diagnostics task.</para>
            /// </description></item>
            /// <item><description><para><b>errorCode</b>: the error code.</para>
            /// <list type="bullet">
            /// <item><description><b>0001</b>: The SQL diagnostics task is complete.</description></item>
            /// <item><description><b>0003</b>: The SQL diagnostics task failed.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>errorMessage</b>: the error message.</para>
            /// </description></item>
            /// <item><description><para><b>estimateCost</b>: the estimated cost.</para>
            /// <list type="bullet">
            /// <item><description><b>cpu</b>: the estimated CPU utilization of the index.</description></item>
            /// <item><description><b>io</b>: the estimated I/O usage of the index.</description></item>
            /// <item><description><b>rows</b>: the estimated values of the rows returned for the index.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>improvement</b>: the performance improvement ratio.</para>
            /// </description></item>
            /// <item><description><para><b>indexAdvices</b>: the index recommendations, which include the following information:</para>
            /// <list type="bullet">
            /// <item><description><b>columns</b>: the index columns.</description></item>
            /// <item><description><b>ddlAddIndex</b>: the DDL statement for the index.</description></item>
            /// <item><description><b>indexName</b>: the name of the index.</description></item>
            /// <item><description><b>schemaName</b>: the name of the database.</description></item>
            /// <item><description><b>tableName</b>: the name of the table.</description></item>
            /// <item><description><b>unique</b>: indicates whether the index is unique.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>ip</b>: the IP address of the instance.</para>
            /// </description></item>
            /// <item><description><para><b>messageId</b>: the ID of the diagnostics task.</para>
            /// </description></item>
            /// <item><description><para><b>port</b>: the port used to connect to the instance.</para>
            /// </description></item>
            /// <item><description><para><b>sqlTag</b>: the SQL tag.</para>
            /// </description></item>
            /// <item><description><para><b>startTime</b>: the start time of the SQL diagnostics task.</para>
            /// </description></item>
            /// <item><description><para><b>success</b>: indicates whether the request was successful.</para>
            /// </description></item>
            /// <item><description><para><b>support</b>: indicates whether the SQL statement can be diagnosed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tuningAdvices</b> : the SQL rewrite suggestions.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;endTime&quot;:1636354256000, &quot;errorCode&quot;:&quot;0001&quot;, &quot;errorMessage&quot;:&quot;TFX succeeded&quot;, &quot;estimateCost&quot;:{ &quot;cpu&quot;:1.7878745150389268, &quot;io&quot;:9.948402604746128, &quot;rows&quot;:8.889372575194633 }, &quot;improvement&quot;:12933.97, &quot;indexAdvices&quot;:[ { &quot;columns&quot;:[ &quot;work_no&quot; ], &quot;ddlAddIndex&quot;:&quot;ALTER TABLE <c>test</c>.<c>work_order</c> ADD INDEX <c>idx_workno</c> (<c>work_no</c>)&quot;, &quot;indexName&quot;:&quot;idx_workno&quot;, &quot;schemaName&quot;:&quot;test&quot;, &quot;tableName&quot;:&quot;work_order&quot;, &quot;unique&quot;:false } ], &quot;ip&quot;:&quot;<b><b>.mysql.rds.aliyuncs.com&quot;, &quot;messageId&quot;:&quot;6188c8cb2f1365b16aee</b></b>&quot;, &quot;port&quot;:3306, &quot;sqlTag&quot;:&quot;{\&quot;PRED_EQUAL\&quot;:\&quot;Y\&quot;,\&quot;CNT_QB\&quot;:\&quot;1\&quot;,\&quot;CNT_TB\&quot;:\&quot;1\&quot;}&quot;, &quot;startTime&quot;:1636354252000, &quot;success&quot;:true, &quot;support&quot;:true, &quot;tuningAdvices&quot;:[ ] }</para>
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
            /// <para>The state of the diagnostics task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The diagnostics task is in progress.</description></item>
            /// <item><description><b>1</b>: A diagnostics error occurred.</description></item>
            /// <item><description><b>2</b>: The diagnostics task is complete.</description></item>
            /// <item><description><b>3</b>: An SQL error occurred.</description></item>
            /// <item><description><b>4</b>: An engine error occurred.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// <para>The unique ID of the diagnostics instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdm_51fe9bc19ec413f4d530431af87a****</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
