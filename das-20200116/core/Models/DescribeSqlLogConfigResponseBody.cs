// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
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
        public DescribeSqlLogConfigResponseBodyData Data { get; set; }
        public class DescribeSqlLogConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether cold data storage is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ColdEnable")]
            [Validation(Required=false)]
            public bool? ColdEnable { get; set; }

            /// <summary>
            /// <para>The cold data storage duration. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("ColdRetention")]
            [Validation(Required=false)]
            public int? ColdRetention { get; set; }

            /// <summary>
            /// <para>The start time of cold data storage. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683712800000</para>
            /// </summary>
            [NameInMap("ColdStartTime")]
            [Validation(Required=false)]
            public long? ColdStartTime { get; set; }

            /// <summary>
            /// <para>The collector version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MYSQL_V0</b>: MySQL V0.</description></item>
            /// <item><description><b>MYSQL_V1</b>: MySQL V1.</description></item>
            /// <item><description><b>MYSQL_V2</b>: MySQL V2.</description></item>
            /// <item><description><b>MYSQL_V3</b>: MySQL V3.</description></item>
            /// <item><description><b>PG_V1</b>: PostgreSQL V1.</description></item>
            /// <item><description><b>rdspg_v1</b>: ApsaraDB RDS for PostgreSQL V1.</description></item>
            /// <item><description><b>polarpg_v1</b>: PolarDB for PostgreSQL V1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MYSQL_V3</para>
            /// </summary>
            [NameInMap("CollectorVersion")]
            [Validation(Required=false)]
            public string CollectorVersion { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Indicates whether hot data storage is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HotEnable")]
            [Validation(Required=false)]
            public bool? HotEnable { get; set; }

            /// <summary>
            /// <para>The hot data storage duration. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("HotRetention")]
            [Validation(Required=false)]
            public int? HotRetention { get; set; }

            /// <summary>
            /// <para>The start time of hot data storage. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683712800000</para>
            /// </summary>
            [NameInMap("HotStartTime")]
            [Validation(Required=false)]
            public long? HotStartTime { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("LogFilter")]
            [Validation(Required=false)]
            public string LogFilter { get; set; }

            /// <summary>
            /// <para>Indicates whether SQL Explorer is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequestEnable")]
            [Validation(Required=false)]
            public bool? RequestEnable { get; set; }

            /// <summary>
            /// <para>The time when SQL Explorer was enabled. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683712800000</para>
            /// </summary>
            [NameInMap("RequestStartTime")]
            [Validation(Required=false)]
            public long? RequestStartTime { get; set; }

            /// <summary>
            /// <para>The expiration time of DAS Enterprise Edition V1. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715335200000</para>
            /// </summary>
            [NameInMap("RequestStopTime")]
            [Validation(Required=false)]
            public long? RequestStopTime { get; set; }

            /// <summary>
            /// <para>The total data storage duration, which is the sum of <b>HotRetention</b> and <b>ColdRetention</b>. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// <para>Indicates whether DAS Enterprise Edition is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SqlLogEnable")]
            [Validation(Required=false)]
            public bool? SqlLogEnable { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("SqlLogSource")]
            [Validation(Required=false)]
            public string SqlLogSource { get; set; }

            /// <summary>
            /// <para>The data migration status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FINISH</b>: Historical data migration is complete.</description></item>
            /// <item><description><b>RUNNING</b>: Historical data migration is in progress.</description></item>
            /// <item><description><b>FAILURE</b>: Historical data migration failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("SqlLogState")]
            [Validation(Required=false)]
            public string SqlLogState { get; set; }

            /// <summary>
            /// <para>The time when DAS Enterprise Edition was enabled. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683712800000</para>
            /// </summary>
            [NameInMap("SqlLogVisibleTime")]
            [Validation(Required=false)]
            public long? SqlLogVisibleTime { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("SupportMigration")]
            [Validation(Required=false)]
            public bool? SupportMigration { get; set; }

            [NameInMap("SupportSecurityAudit")]
            [Validation(Required=false)]
            public bool? SupportSecurityAudit { get; set; }

            /// <summary>
            /// <para>The latest DAS Enterprise Edition version supported by the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SQL_LOG_V0</b>: Enterprise Edition V0.</description></item>
            /// <item><description><b>SQL_LOG_V1</b>: Enterprise Edition V1.</description></item>
            /// <item><description><b>SQL_LOG_V2</b>: Enterprise Edition V2.</description></item>
            /// <item><description><b>SQL_LOG_V3</b>: Enterprise Edition V3.</description></item>
            /// <item><description><b>SQL_LOG_NOT_ENABLE</b>: Enterprise Edition is not enabled.</description></item>
            /// <item><description><b>SQL_LOG_NOT_SUPPORT</b>: Enterprise Edition is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL_LOG_V3</para>
            /// </summary>
            [NameInMap("SupportVersion")]
            [Validation(Required=false)]
            public string SupportVersion { get; set; }

            /// <summary>
            /// <para>The current DAS Enterprise Edition version that is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SQL_LOG_V0</b>: Enterprise Edition V0.</description></item>
            /// <item><description><b>SQL_LOG_V1</b>: Enterprise Edition V1.</description></item>
            /// <item><description><b>SQL_LOG_V2</b>: Enterprise Edition V2.</description></item>
            /// <item><description><b>SQL_LOG_V3</b>: Enterprise Edition V3.</description></item>
            /// <item><description><b>SQL_LOG_NOT_ENABLE</b>: Enterprise Edition is not enabled.</description></item>
            /// <item><description><b>SQL_LOG_NOT_SUPPORT</b>: Enterprise Edition is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL_LOG_V3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message that contains information such as an error code is returned.</para>
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
        /// <para>0A74B755-98B7-59DB-8724-1321B394****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
