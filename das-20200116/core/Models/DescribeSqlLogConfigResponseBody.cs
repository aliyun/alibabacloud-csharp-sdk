// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogConfigResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// SqlLogConfig
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogConfigResponseBodyData Data { get; set; }
        public class DescribeSqlLogConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The cold storage duration.
            /// </summary>
            [NameInMap("ColdEnable")]
            [Validation(Required=false)]
            public bool? ColdEnable { get; set; }

            /// <summary>
            /// The cold storage duration.
            /// </summary>
            [NameInMap("ColdRetention")]
            [Validation(Required=false)]
            public int? ColdRetention { get; set; }

            /// <summary>
            /// The time when cold storage was enabled.
            /// </summary>
            [NameInMap("ColdStartTime")]
            [Validation(Required=false)]
            public long? ColdStartTime { get; set; }

            /// <summary>
            /// The version of the collector.
            /// </summary>
            [NameInMap("CollectorVersion")]
            [Validation(Required=false)]
            public string CollectorVersion { get; set; }

            /// <summary>
            /// Indicates whether hot storage was enabled.
            /// </summary>
            [NameInMap("HotEnable")]
            [Validation(Required=false)]
            public bool? HotEnable { get; set; }

            /// <summary>
            /// The hot storage duration.
            /// </summary>
            [NameInMap("HotRetention")]
            [Validation(Required=false)]
            public int? HotRetention { get; set; }

            /// <summary>
            /// The time when hot storage was enabled.
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
            /// Indicates whether SQL Explorer and Audit was enabled.
            /// </summary>
            [NameInMap("RequestEnable")]
            [Validation(Required=false)]
            public bool? RequestEnable { get; set; }

            /// <summary>
            /// The time when SQL Explorer and Audit was enabled.
            /// </summary>
            [NameInMap("RequestStartTime")]
            [Validation(Required=false)]
            public long? RequestStartTime { get; set; }

            /// <summary>
            /// The time when SQL Explorer and Audit was disabled.
            /// 
            /// >  If DAS Enterprise Edition V1 was enabled, this parameter indicates the time when DAS Enterprise Edition expired.
            /// </summary>
            [NameInMap("RequestStopTime")]
            [Validation(Required=false)]
            public long? RequestStopTime { get; set; }

            /// <summary>
            /// The storage duration of the SQL Explorer and Audit data.
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// Indicates whether DAS Enterprise Edition was enabled.
            /// </summary>
            [NameInMap("SqlLogEnable")]
            [Validation(Required=false)]
            public bool? SqlLogEnable { get; set; }

            /// <summary>
            /// The status of data migration.
            /// </summary>
            [NameInMap("SqlLogState")]
            [Validation(Required=false)]
            public string SqlLogState { get; set; }

            /// <summary>
            /// The time when SQL Explorer and Audit was enabled.
            /// </summary>
            [NameInMap("SqlLogVisibleTime")]
            [Validation(Required=false)]
            public long? SqlLogVisibleTime { get; set; }

            /// <summary>
            /// The supported versions of Database Autonomy Service (DAS) Enterprise Edition.
            /// </summary>
            [NameInMap("SupportVersion")]
            [Validation(Required=false)]
            public string SupportVersion { get; set; }

            /// <summary>
            /// The version of SQL Explorer and Audit.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request is successful, **Successful** is returned. If the request fails, an error message that contains information such as an error code is returned.
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
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
