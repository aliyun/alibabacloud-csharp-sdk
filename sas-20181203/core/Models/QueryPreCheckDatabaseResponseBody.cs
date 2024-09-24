// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryPreCheckDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the precheck task was complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657524396</para>
        /// </summary>
        [NameInMap("CompletedTime")]
        [Validation(Required=false)]
        public long? CompletedTime { get; set; }

        /// <summary>
        /// <para>The time when the precheck task was started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660448660</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>The status of the precheck task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>completed</b>: complete</description></item>
        /// <item><description><b>created</b>: started</description></item>
        /// <item><description><b>error</b>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The precheck progress in percentage. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the precheck task. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>instanceId</b>: the ID of the server that hosts the database</para>
        /// </description></item>
        /// <item><description><para><b>checkTime</b>: the precheck time</para>
        /// </description></item>
        /// <item><description><para><b>sourceType</b>: the database type</para>
        /// </description></item>
        /// <item><description><para><b>results</b>: the precheck item and result</para>
        /// <list type="bullet">
        /// <item><description><b>item</b>: the precheck item</description></item>
        /// <item><description><b>result</b>: the precheck result</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The following section describes the precheck items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>MSSQL</para>
        /// <list type="bullet">
        /// <item><description><b>OSS_INTERNAL_ENDPOINT_CONNECTIVITY</b>: OSS connectivity check</description></item>
        /// <item><description><b>SERVICE_CONNECTIVITY</b>: control network connectivity check</description></item>
        /// <item><description><b>SQL_SERVER_DB_IN_SIMPLE_RECOVERY_MODE</b>: recovery mode check</description></item>
        /// <item><description><b>SQL_SERVER_DB_NOT_ONLINE</b>: SQL Server database status check</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ORACLE</para>
        /// <list type="bullet">
        /// <item><description><b>OSS_INTERNAL_ENDPOINT_CONNECTIVITY</b>: OSS connectivity check</description></item>
        /// <item><description><b>SERVICE_CONNECTIVITY</b>: control network connectivity check</description></item>
        /// <item><description><b>ORACLE_INSTANCE_STATUS</b>: Oracle instance status check</description></item>
        /// <item><description><b>ORACLE_DB_STATUS</b>: Oracle database status check</description></item>
        /// <item><description><b>ARCHIVELOG</b>: archive mode check</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>MYSQL</para>
        /// <list type="bullet">
        /// <item><description><b>OSS_INTERNAL_ENDPOINT_CONNECTIVITY</b>: OSS connectivity check</description></item>
        /// <item><description><b>SERVICE_CONNECTIVITY</b>: control network connectivity check</description></item>
        /// <item><description><b>MYSQL_VERSION</b>: Supports full backup version checking</description></item>
        /// <item><description><b>MYSQL_BINLOG</b>: BINLOG check</description></item>
        /// </list>
        /// </description></item>
        /// </list>
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
        /// <para>The time when the precheck task was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671084106</para>
        /// </summary>
        [NameInMap("UpdatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

    }

}
