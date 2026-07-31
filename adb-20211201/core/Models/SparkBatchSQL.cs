// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkBatchSQL : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp17s73f016****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The error message for the query execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schema is not found</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The text of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM db.tb</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The execution end timestamp of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public long? QueryEndTime { get; set; }

        /// <summary>
        /// <para>The query ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sq172352176****</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>The execution start timestamp of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public long? QueryStartTime { get; set; }

        /// <summary>
        /// <para>The execution status of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FAILED</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>CANCELED</description></item>
        /// <item><description>PENDING</description></item>
        /// <item><description>SUBMITTED</description></item>
        /// <item><description>FINISHED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("QueryState")]
        [Validation(Required=false)]
        public string QueryState { get; set; }

        /// <summary>
        /// <para>The submission timestamp of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("QuerySubmissionTime")]
        [Validation(Required=false)]
        public long? QuerySubmissionTime { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark_rg</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The name of the database for the query execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The execution results of the SQL statements.</para>
        /// </summary>
        [NameInMap("Statements")]
        [Validation(Required=false)]
        public List<SparkBatchSQLStatement> Statements { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2198002412336****</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
