// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSourceEventsForMonitorSourceResponseBody : TeaModel {
        /// <summary>
        /// 告警列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSourceEventsForMonitorSourceResponseBodyData> Data { get; set; }
        public class ListSourceEventsForMonitorSourceResponseBodyData : TeaModel {
            /// <summary>
            /// 告警内容
            /// </summary>
            [NameInMap("eventJson")]
            [Validation(Required=false)]
            public string EventJson { get; set; }

            /// <summary>
            /// 告警上报时间
            /// </summary>
            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// 监控源ID
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public bool? MonitorSourceId { get; set; }

            /// <summary>
            /// 监控源名称
            /// </summary>
            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
