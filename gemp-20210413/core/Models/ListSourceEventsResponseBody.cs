// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSourceEventsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSourceEventsResponseBodyData> Data { get; set; }
        public class ListSourceEventsResponseBodyData : TeaModel {
            [NameInMap("eventJson")]
            [Validation(Required=false)]
            public string EventJson { get; set; }

            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            [NameInMap("tenantRamId")]
            [Validation(Required=false)]
            public long? TenantRamId { get; set; }

        }

        /// <summary>
        /// firstRowKey
        /// </summary>
        [NameInMap("firstRowKey")]
        [Validation(Required=false)]
        public string FirstRowKey { get; set; }

        /// <summary>
        /// lastRowKey
        /// </summary>
        [NameInMap("lastRowKey")]
        [Validation(Required=false)]
        public string LastRowKey { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
