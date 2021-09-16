// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetEventResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 告警
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEventResponseBodyData Data { get; set; }
        public class GetEventResponseBodyData : TeaModel {
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }
            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }
            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }
            [NameInMap("eventJson")]
            [Validation(Required=false)]
            public string EventJson { get; set; }
        };

    }

}
