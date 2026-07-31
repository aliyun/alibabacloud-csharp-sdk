// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkBatchSQLStatement : TeaModel {
        /// <summary>
        /// <para>The ID of the Spark job that executes the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s20240122jsdx****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The text of the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT 100</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution end timestamp of the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The error message for the SQL statement execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table is not found</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The execution result of the SQL statement. The content is in the response format of the <c>DataFrame Show</c> statement in Spark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+---+-----+
        /// |age| name|
        /// +---+-----+
        /// | 14|  Tom|
        /// | 23|Alice|
        /// +---+-----+</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) location where the execution results of the SQL statement are stored. If you do not specify a storage location, null is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://yourbucket/result.json</para>
        /// </summary>
        [NameInMap("ResultUri")]
        [Validation(Required=false)]
        public string ResultUri { get; set; }

        /// <summary>
        /// <para>The execution start timestamp of the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723521767000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The execution status of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FAILED</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>CANCELED</description></item>
        /// <item><description>PENDING</description></item>
        /// <item><description>FINISHED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The ID of the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sq1723521767****-0001</para>
        /// </summary>
        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public string StatementId { get; set; }

    }

}
