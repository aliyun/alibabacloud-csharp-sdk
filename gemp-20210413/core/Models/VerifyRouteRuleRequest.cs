// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class VerifyRouteRuleRequest : TeaModel {
        /// <summary>
        /// 规则id
        /// </summary>
        [NameInMap("routeRuleId")]
        [Validation(Required=false)]
        public long? RouteRuleId { get; set; }

        /// <summary>
        /// 测试告警
        /// </summary>
        [NameInMap("testSourceEvents")]
        [Validation(Required=false)]
        public List<VerifyRouteRuleRequestTestSourceEvents> TestSourceEvents { get; set; }
        public class VerifyRouteRuleRequestTestSourceEvents : TeaModel {
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
            /// 监控告警源ID
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            /// <summary>
            /// 监控告警源名称
            /// </summary>
            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

        }

    }

}
