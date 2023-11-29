// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAnomalySQLListResponseBody : TeaModel {
        /// <summary>
        /// The list of suspicious SQL statements.
        /// </summary>
        [NameInMap("AnomalySQLList")]
        [Validation(Required=false)]
        public List<DescribeAnomalySQLListResponseBodyAnomalySQLList> AnomalySQLList { get; set; }
        public class DescribeAnomalySQLListResponseBodyAnomalySQLList : TeaModel {
            /// <summary>
            /// The average CPU time, in ms.
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public float? CpuTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The diagnosis information.
            /// </summary>
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public string Diagnosis { get; set; }

            /// <summary>
            /// The diagnostic rule.
            /// </summary>
            [NameInMap("DiagnosisRule")]
            [Validation(Required=false)]
            public string DiagnosisRule { get; set; }

            /// <summary>
            /// The number of executions.
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// The sequence number of the returned SQL statement.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            /// <summary>
            /// The request time, in ms.
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public float? RequestTime { get; set; }

            /// <summary>
            /// The request time in UTC +0.
            /// </summary>
            [NameInMap("RequestTimeUTCString")]
            [Validation(Required=false)]
            public string RequestTimeUTCString { get; set; }

            /// <summary>
            /// SQLID.
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            /// <summary>
            /// The SQL text.
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// The suggestions.
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// The username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total count.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
