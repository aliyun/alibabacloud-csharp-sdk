// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogConfigResponseBody : TeaModel {
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
            [NameInMap("ColdEnable")]
            [Validation(Required=false)]
            public bool? ColdEnable { get; set; }

            [NameInMap("ColdRetention")]
            [Validation(Required=false)]
            public int? ColdRetention { get; set; }

            [NameInMap("ColdStartTime")]
            [Validation(Required=false)]
            public long? ColdStartTime { get; set; }

            [NameInMap("CollectorVersion")]
            [Validation(Required=false)]
            public string CollectorVersion { get; set; }

            [NameInMap("HotEnable")]
            [Validation(Required=false)]
            public bool? HotEnable { get; set; }

            [NameInMap("HotRetention")]
            [Validation(Required=false)]
            public int? HotRetention { get; set; }

            [NameInMap("HotStartTime")]
            [Validation(Required=false)]
            public long? HotStartTime { get; set; }

            [NameInMap("LogFilter")]
            [Validation(Required=false)]
            public string LogFilter { get; set; }

            [NameInMap("RequestEnable")]
            [Validation(Required=false)]
            public bool? RequestEnable { get; set; }

            [NameInMap("RequestStartTime")]
            [Validation(Required=false)]
            public long? RequestStartTime { get; set; }

            [NameInMap("RequestStopTime")]
            [Validation(Required=false)]
            public long? RequestStopTime { get; set; }

            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            [NameInMap("SqlLogEnable")]
            [Validation(Required=false)]
            public bool? SqlLogEnable { get; set; }

            [NameInMap("SqlLogState")]
            [Validation(Required=false)]
            public string SqlLogState { get; set; }

            [NameInMap("SqlLogVisibleTime")]
            [Validation(Required=false)]
            public long? SqlLogVisibleTime { get; set; }

            [NameInMap("SupportVersion")]
            [Validation(Required=false)]
            public string SupportVersion { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
