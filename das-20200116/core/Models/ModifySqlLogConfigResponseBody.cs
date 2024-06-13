// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySqlLogConfigResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifySqlLogConfigResponseBodyData Data { get; set; }
        public class ModifySqlLogConfigResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the cold data storage is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ColdEnable")]
            [Validation(Required=false)]
            public bool? ColdEnable { get; set; }

            /// <summary>
            /// The number of days for which the SQL Explorer and Audit data is stored in cold storage. The value is calculated by using the following formula: Value of ColdRetention = Value of Retention - Value of HotRetention.``
            /// </summary>
            [NameInMap("ColdRetention")]
            [Validation(Required=false)]
            public int? ColdRetention { get; set; }

            /// <summary>
            /// The time when the cold data storage was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("ColdStartTime")]
            [Validation(Required=false)]
            public long? ColdStartTime { get; set; }

            /// <summary>
            /// The collector version. Valid values:
            /// 
            /// *   **MYSQL_V0**
            /// *   **MYSQL_V1**
            /// *   **MYSQL_V2**
            /// *   **MYSQL_V3**
            /// *   **PG_V1**
            /// *   **rdspg_v1**
            /// *   **polarpg_v1**
            /// </summary>
            [NameInMap("CollectorVersion")]
            [Validation(Required=false)]
            public string CollectorVersion { get; set; }

            /// <summary>
            /// Indicates whether the hot data storage is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HotEnable")]
            [Validation(Required=false)]
            public bool? HotEnable { get; set; }

            /// <summary>
            /// The number of days for which the SQL Explorer and Audit data is stored in hot storage.
            /// </summary>
            [NameInMap("HotRetention")]
            [Validation(Required=false)]
            public int? HotRetention { get; set; }

            /// <summary>
            /// The time when the hot data storage was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("HotStartTime")]
            [Validation(Required=false)]
            public long? HotStartTime { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("LogFilter")]
            [Validation(Required=false)]
            public string LogFilter { get; set; }

            /// <summary>
            /// Indicates whether the SQL Explorer feature is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("RequestEnable")]
            [Validation(Required=false)]
            public bool? RequestEnable { get; set; }

            /// <summary>
            /// The time when the SQL Explorer feature was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("RequestStartTime")]
            [Validation(Required=false)]
            public long? RequestStartTime { get; set; }

            /// <summary>
            /// The time when DAS Enterprise Edition V1 expired. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("RequestStopTime")]
            [Validation(Required=false)]
            public long? RequestStopTime { get; set; }

            /// <summary>
            /// The total storage duration of the SQL Explorer and Audit data. Unit: day.
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// Indicates whether DAS Enterprise Edition is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("SqlLogEnable")]
            [Validation(Required=false)]
            public bool? SqlLogEnable { get; set; }

            /// <summary>
            /// The state of data migration. Valid values:
            /// 
            /// *   **FINISH**: The historical data is migrated.
            /// *   **RUNNING**: The historical data is being migrated.
            /// *   **FAILURE**: The historical data fails to be migrated.
            /// </summary>
            [NameInMap("SqlLogState")]
            [Validation(Required=false)]
            public string SqlLogState { get; set; }

            /// <summary>
            /// The time when DAS Enterprise Edition was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("SqlLogVisibleTime")]
            [Validation(Required=false)]
            public long? SqlLogVisibleTime { get; set; }

            /// <summary>
            /// The latest version of DAS Enterprise Edition that supports the database instance. Valid values:
            /// 
            /// *   **SQL_LOG_V0**: DAS Enterprise Edition V0.
            /// *   **SQL_LOG_V1**: DAS Enterprise Edition V1.
            /// *   **SQL_LOG_V2**: DAS Enterprise Edition V2.
            /// *   **SQL_LOG_V3**: DAS Enterprise Edition V3.
            /// *   **SQL_LOG_NOT_ENABLE**: DAS Enterprise Edition is not enabled.
            /// *   **SQL_LOG_NOT_SUPPORT**: DAS Enterprise Edition is not supported.
            /// </summary>
            [NameInMap("SupportVersion")]
            [Validation(Required=false)]
            public string SupportVersion { get; set; }

            /// <summary>
            /// The version of DAS Enterprise Edition that is enabled for the database instance. Valid values:
            /// 
            /// *   **SQL_LOG_V0**: DAS Enterprise Edition V0.
            /// *   **SQL_LOG_V1**: DAS Enterprise Edition V1.
            /// *   **SQL_LOG_V2**: DAS Enterprise Edition V2.
            /// *   **SQL_LOG_V3**: DAS Enterprise Edition V3.
            /// *   **SQL_LOG_NOT_ENABLE**: DAS Enterprise Edition is not enabled.
            /// *   **SQL_LOG_NOT_SUPPORT**: DAS Enterprise Edition is not supported.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
