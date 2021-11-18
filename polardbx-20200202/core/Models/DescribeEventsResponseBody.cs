// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// 事件体
        /// </summary>
        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEventItems> EventItems { get; set; }
        public class DescribeEventsResponseBodyEventItems : TeaModel {
            /// <summary>
            /// 事件ID
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// 事件名称
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// 补充信息
            /// </summary>
            [NameInMap("EventPayload")]
            [Validation(Required=false)]
            public string EventPayload { get; set; }

            /// <summary>
            /// 原因
            /// </summary>
            [NameInMap("EventReason")]
            [Validation(Required=false)]
            public string EventReason { get; set; }

            /// <summary>
            /// 记录时间
            /// </summary>
            [NameInMap("EventRecordTime")]
            [Validation(Required=false)]
            public string EventRecordTime { get; set; }

            /// <summary>
            /// 事件时间
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// 事件类型
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// 事件用户类型
            /// </summary>
            [NameInMap("EventUserType")]
            [Validation(Required=false)]
            public string EventUserType { get; set; }

            /// <summary>
            /// 区域ID
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 资源名
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// 资源类型
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// 页面下标
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
