// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySqlLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
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
        public ModifySqlLogConfigResponseBodyData Data { get; set; }
        public class ModifySqlLogConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the cold data storage is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ColdEnable")]
            [Validation(Required=false)]
            public bool? ColdEnable { get; set; }

            /// <summary>
            /// <para>The retention period of the cold data. Unit: day. This value is calculated by using the following formula: <c>Retention - HotRetention</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("ColdRetention")]
            [Validation(Required=false)]
            public int? ColdRetention { get; set; }

            /// <summary>
            /// <para>The time when the cold data storage was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683712800000</para>
            /// </summary>
            [NameInMap("ColdStartTime")]
            [Validation(Required=false)]
            public long? ColdStartTime { get; set; }

            /// <summary>
            /// <para>The version of the database collector. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MYSQL_V0</b>: MySQL V0</para>
            /// </description></item>
            /// <item><description><para><b>MYSQL_V1</b>: MySQL V1</para>
            /// </description></item>
            /// <item><description><para><b>MYSQL_V2</b>: MySQL V2</para>
            /// </description></item>
            /// <item><description><para><b>MYSQL_V3</b>: MySQL V3</para>
            /// </description></item>
            /// <item><description><para><b>PG_V1</b>: PostgreSQL V1</para>
            /// </description></item>
            /// <item><description><para><b>rdspg_v1</b>: ApsaraDB RDS for PostgreSQL V1</para>
            /// </description></item>
            /// <item><description><para><b>polarpg_v1</b>: PolarDB for PostgreSQL V1</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MYSQL_V3</para>
            /// </summary>
            [NameInMap("CollectorVersion")]
            [Validation(Required=false)]
            public string CollectorVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the hot data storage is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HotEnable")]
            [Validation(Required=false)]
            public bool? HotEnable { get; set; }

            /// <summary>
            /// <para>The retention period of the hot data. Unit: day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("HotRetention")]
            [Validation(Required=false)]
            public int? HotRetention { get; set; }

            /// <summary>
            /// <para>The time when the hot data storage was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
            /// <para>Indicates whether SQL Explorer is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequestEnable")]
            [Validation(Required=false)]
            public bool? RequestEnable { get; set; }

            /// <summary>
            /// <para>The time when SQL Explorer was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683712800000</para>
            /// </summary>
            [NameInMap("RequestStartTime")]
            [Validation(Required=false)]
            public long? RequestStartTime { get; set; }

            /// <summary>
            /// <para>The expiration time of DAS Enterprise Edition. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715335200000</para>
            /// </summary>
            [NameInMap("RequestStopTime")]
            [Validation(Required=false)]
            public long? RequestStopTime { get; set; }

            /// <summary>
            /// <para>The total retention period of data. Unit: day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// <para>Indicates whether DAS Enterprise Edition is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SqlLogEnable")]
            [Validation(Required=false)]
            public bool? SqlLogEnable { get; set; }

            /// <summary>
            /// <para>The source of the audit log.</para>
            /// </summary>
            [NameInMap("SqlLogSource")]
            [Validation(Required=false)]
            public string SqlLogSource { get; set; }

            /// <summary>
            /// <para>The data migration state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>FINISH</b>: The historical data is migrated.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: The historical data is being migrated.</para>
            /// </description></item>
            /// <item><description><para><b>FAILURE</b>: The historical data fails to be migrated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("SqlLogState")]
            [Validation(Required=false)]
            public string SqlLogState { get; set; }

            /// <summary>
            /// <para>The time when DAS Enterprise Edition was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683712800000</para>
            /// </summary>
            [NameInMap("SqlLogVisibleTime")]
            [Validation(Required=false)]
            public long? SqlLogVisibleTime { get; set; }

            /// <summary>
            /// <para>The latest supported version of DAS Enterprise Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SQL_LOG_V0</b>: DAS Enterprise Edition V0</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_V1</b>: DAS Enterprise Edition V1</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_V2</b>: DAS Enterprise Edition V2</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_V3</b>: DAS Enterprise Edition V3</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_NOT_ENABLE</b>: DAS Enterprise Edition is not enabled.</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_NOT_SUPPORT</b>: DAS Enterprise Edition is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL_LOG_V3</para>
            /// </summary>
            [NameInMap("SupportVersion")]
            [Validation(Required=false)]
            public string SupportVersion { get; set; }

            /// <summary>
            /// <para>The current version of DAS Enterprise Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SQL_LOG_V0</b>: DAS Enterprise Edition V0</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_V1</b>: DAS Enterprise Edition V1</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_V2</b>: DAS Enterprise Edition V2</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_V3</b>: DAS Enterprise Edition V3</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_NOT_ENABLE</b>: DAS Enterprise Edition is not enabled.</para>
            /// </description></item>
            /// <item><description><para><b>SQL_LOG_NOT_SUPPORT</b>: DAS Enterprise Edition is not supported.</para>
            /// </description></item>
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
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. Otherwise, an error message is returned.</para>
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
        /// <para>03C88D8E-1541-518E-8BFF-BEC6589B6334</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
