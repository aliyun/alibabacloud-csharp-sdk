// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAnomalySQLListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of suspicious SQL statements.</para>
        /// </summary>
        [NameInMap("AnomalySQLList")]
        [Validation(Required=false)]
        public List<DescribeAnomalySQLListResponseBodyAnomalySQLList> AnomalySQLList { get; set; }
        public class DescribeAnomalySQLListResponseBodyAnomalySQLList : TeaModel {
            /// <summary>
            /// <para>The average CPU time, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50.13</para>
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public float? CpuTime { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database1</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The diagnosis information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Total number of executions = 80199, Average CPU time = 6.8 ms, Overall CPU utilization = 87%</para>
            /// </summary>
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public string Diagnosis { get; set; }

            /// <summary>
            /// <para>The diagnostic rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Utilization above threshold</para>
            /// </summary>
            [NameInMap("DiagnosisRule")]
            [Validation(Required=false)]
            public string DiagnosisRule { get; set; }

            /// <summary>
            /// <para>The number of executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89043</para>
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// <para>The sequence number of the returned SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            /// <summary>
            /// <para>The request time, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50.00</para>
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public float? RequestTime { get; set; }

            /// <summary>
            /// <para>The request time in UTC +0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-11T07:08:00Z</para>
            /// </summary>
            [NameInMap("RequestTimeUTCString")]
            [Validation(Required=false)]
            public string RequestTimeUTCString { get; set; }

            /// <summary>
            /// <para>SQLID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99E9D3BF<b><b>B486239E6C7BC79B</b></b></para>
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            /// <summary>
            /// <para>The SQL text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT  ****   FROM ****   WHERE **** = ? AND **** = ?   ORDER BY **** ASC</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The suggestions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Check your business scenarios, data distribution changes, request surges, and execution plan changes.</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tester</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
