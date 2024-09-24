// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkBatchSQL : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>amv-xxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>schema is not found</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>query</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public long? QueryEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>amv-202401-xx</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public long? QueryStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("QueryState")]
        [Validation(Required=false)]
        public string QueryState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("QuerySubmissionTime")]
        [Validation(Required=false)]
        public long? QuerySubmissionTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>spark_rg</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        [NameInMap("Statements")]
        [Validation(Required=false)]
        public List<SparkBatchSQLStatement> Statements { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12222222</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
