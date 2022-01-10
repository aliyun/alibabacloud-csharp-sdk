// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemActivityResponseBody : TeaModel {
        /// <summary>
        /// 动态信息
        /// </summary>
        [NameInMap("activities")]
        [Validation(Required=false)]
        public List<GetWorkItemActivityResponseBodyActivities> Activities { get; set; }
        public class GetWorkItemActivityResponseBodyActivities : TeaModel {
            /// <summary>
            /// 动作类型
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// 事件id
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// 事件时间
            /// </summary>
            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            /// <summary>
            /// 事件类型
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// 操作者
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// 父事件id
            /// </summary>
            [NameInMap("parentEventId")]
            [Validation(Required=false)]
            public long? ParentEventId { get; set; }

            /// <summary>
            /// 修改属性
            /// </summary>
            [NameInMap("property")]
            [Validation(Required=false)]
            public GetWorkItemActivityResponseBodyActivitiesProperty Property { get; set; }
            public class GetWorkItemActivityResponseBodyActivitiesProperty : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }
                [NameInMap("propertyIdentifier")]
                [Validation(Required=false)]
                public string PropertyIdentifier { get; set; }
                [NameInMap("propertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }
                [NameInMap("propertyType")]
                [Validation(Required=false)]
                public string PropertyType { get; set; }
            };

            /// <summary>
            /// 操作对象
            /// </summary>
            [NameInMap("resourceIdentifier")]
            [Validation(Required=false)]
            public string ResourceIdentifier { get; set; }

        }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
