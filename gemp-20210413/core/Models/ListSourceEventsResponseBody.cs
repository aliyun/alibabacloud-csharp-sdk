// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSourceEventsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSourceEventsResponseBodyData> Data { get; set; }
        public class ListSourceEventsResponseBodyData : TeaModel {
            /// <summary>
            /// 规则ID
            /// </summary>
            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            /// <summary>
            /// INCIDENT 事件、ALERT 报警、PROBLEM 故障
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// 关联对象ID
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

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

            /// <summary>
            /// 告警上报时间
            /// </summary>
            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// 租户ID
            /// </summary>
            [NameInMap("tenantRamId")]
            [Validation(Required=false)]
            public long? TenantRamId { get; set; }

            /// <summary>
            /// 告警内容json
            /// </summary>
            [NameInMap("eventJson")]
            [Validation(Required=false)]
            public string EventJson { get; set; }

        }

        /// <summary>
        /// lastRowKey
        /// </summary>
        [NameInMap("lastRowKey")]
        [Validation(Required=false)]
        public string LastRowKey { get; set; }

        /// <summary>
        /// firstRowKey
        /// </summary>
        [NameInMap("firstRowKey")]
        [Validation(Required=false)]
        public string FirstRowKey { get; set; }

    }

}
