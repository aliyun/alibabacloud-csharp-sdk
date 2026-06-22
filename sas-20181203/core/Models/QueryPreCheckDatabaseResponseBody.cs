// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryPreCheckDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the pre-check was completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657524396</para>
        /// </summary>
        [NameInMap("CompletedTime")]
        [Validation(Required=false)]
        public long? CompletedTime { get; set; }

        /// <summary>
        /// <para>The time when the pre-check started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660448660</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>The status description of the pre-check task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>completed</b>: Completed.</description></item>
        /// <item><description><b>created</b>: Started.</description></item>
        /// <item><description><b>error</b>: Pre-check failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The pre-check progress. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task result of the dry run node. The value is a JSON string. The KEY valid values are:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: the instance ID of the server where the database resides.</description></item>
        /// <item><description><b>checkTime</b>: the dry run time.</description></item>
        /// <item><description><b>sourceType</b>: the database type.</description></item>
        /// <item><description><b>results</b>: the dry run items and task results.<list type="bullet">
        /// <item><description><b>item</b>: the dry run item.</description></item>
        /// <item><description><b>result</b>: the dry run task result.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Dry run item description</para>
        /// <list type="bullet">
        /// <item><description>MSSQL<list type="bullet">
        /// <item><description><b>OSS_INTERNAL_ENDPOINT_CONNECTIVITY</b>: OSS connectivity check.	</description></item>
        /// <item><description><b>SERVICE_CONNECTIVITY</b>: control network connectivity check.</description></item>
        /// <item><description><b>SQL_SERVER_DB_IN_SIMPLE_RECOVERY_MODE</b>: recovery mode check.</description></item>
        /// <item><description><b>SQL_SERVER_DB_NOT_ONLINE</b>: SQL Server database status check.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>ORACLE<list type="bullet">
        /// <item><description><b>OSS_INTERNAL_ENDPOINT_CONNECTIVITY</b>: OSS connectivity check.	</description></item>
        /// <item><description><b>SERVICE_CONNECTIVITY</b>: control network connectivity check.</description></item>
        /// <item><description><b>ORACLE_INSTANCE_STATUS</b>: Oracle instance status check.</description></item>
        /// <item><description><b>ORACLE_DB_STATUS</b>: Oracle database status check.</description></item>
        /// <item><description><b>ARCHIVELOG</b>: archive mode check.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>MYSQL<list type="bullet">
        /// <item><description><b>OSS_INTERNAL_ENDPOINT_CONNECTIVITY</b>: OSS connectivity check.	</description></item>
        /// <item><description><b>SERVICE_CONNECTIVITY</b>: control network connectivity check.</description></item>
        /// <item><description><b>MYSQL_VERSION</b>: version check for full backup support.</description></item>
        /// <item><description><b>MYSQL_BINLOG</b>: BINLOG check.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;instanceId&quot;: &quot;i-wz91if83t97xgtn2****&quot;,
        ///         &quot;checkTime&quot;: 1671245753,
        ///         &quot;sourceType&quot;: &quot;MSSQL&quot;,
        ///         &quot;results&quot;:
        ///         [
        ///             {
        ///                 &quot;item&quot;: &quot;OSS_INTERNAL_ENDPOINT_CONNECTIVITY&quot;,
        ///                 &quot;result&quot;: &quot;PASSED&quot;
        ///             },
        ///             {
        ///                 &quot;item&quot;: &quot;SERVICE_CONNECTIVITY&quot;,
        ///                 &quot;result&quot;: &quot;PASSED&quot;
        ///             },
        ///             {
        ///                 &quot;item&quot;: &quot;SQL_SERVER_DB_IN_SIMPLE_RECOVERY_MODE&quot;,
        ///                 &quot;result&quot;: &quot;WARNING&quot;
        ///             },
        ///             {
        ///                 &quot;item&quot;: &quot;SQL_SERVER_DB_NOT_ONLINE&quot;,
        ///                 &quot;result&quot;: &quot;PASSED&quot;
        ///             }
        ///         ]
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The time when the pre-check was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671084106</para>
        /// </summary>
        [NameInMap("UpdatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

    }

}
