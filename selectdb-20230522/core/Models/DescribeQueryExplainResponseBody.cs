// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeQueryExplainResponseBody : TeaModel {
        /// <summary>
        /// <para>The Explain result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+-----------------------------------------------------------------------+
        /// | Explain String|
        /// +-----------------------------------------------------------------------+
        /// | PLAN FRAGMENT 0                                                       |
        /// |OUTPUT EXPRS:                                                        |
        /// |    name[#1]                                                           |
        /// |    age[#2]                                                            |
        /// |  PARTITION: UNPARTITIONED                                |
        /// |                                                                        |
        /// |  VRESULT SINK                                                         |
        /// |                                                                        |
        /// |  1:VEXCHANGE                                                          |
        /// |     offset: 0                                                        |
        /// |                                                                        |
        /// | PLAN FRAGMENT 1                                                       |
        /// |                                                                        |
        /// |  PARTITION: HASH_PARTITIONED: id[#0]                                  |
        /// |                                                                        |
        /// |  STREAM DATA SINK                                                     |
        /// |    EXCHANGE ID: 01|
        /// |    UNPARTITIONED                                |
        /// |                                                                        |
        /// |  0:VOlapScanNode                                                      |
        /// |     TABLE: example_db.example_tbl(example_tbl)                        |
        /// |     PREAGGREGATION: ON                                                |
        /// |     PREDICATES: (age[#2] &gt; 18)                                        |
        /// |     cardinality=1, avgRowSize=20.0, numNodes=1                        |
        /// |     tablet list: 10023, 10025, 10027                |
        /// +-----------------------------------------------------------------------+</para>
        /// </summary>
        [NameInMap("ExplainResult")]
        [Validation(Required=false)]
        public string ExplainResult { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8900A96-67F7-5274-A41B-7722E1ECF8C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SQL statement for which the execution plan is retrieved. Excessively long SQL statements in audit logs may be truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM example_db.example_tbl</para>
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
