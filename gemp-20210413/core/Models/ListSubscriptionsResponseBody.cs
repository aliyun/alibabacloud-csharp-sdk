// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSubscriptionsResponseBody : TeaModel {
        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSubscriptionsResponseBodyData> Data { get; set; }
        public class ListSubscriptionsResponseBodyData : TeaModel {
            /// <summary>
            /// 订阅id
            /// </summary>
            [NameInMap("subscriptionId")]
            [Validation(Required=false)]
            public long? SubscriptionId { get; set; }

            /// <summary>
            /// 通知订阅名称
            /// </summary>
            [NameInMap("subscriptionTitle")]
            [Validation(Required=false)]
            public string SubscriptionTitle { get; set; }

            /// <summary>
            /// 0 全部 1服务 2 流转规则
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public long? Scope { get; set; }

            /// <summary>
            /// 0服务组 1个人
            /// </summary>
            [NameInMap("notifyObjectType")]
            [Validation(Required=false)]
            public long? NotifyObjectType { get; set; }

            /// <summary>
            /// 有效期类型 0 长期 1短期
            /// </summary>
            [NameInMap("expiredType")]
            [Validation(Required=false)]
            public string ExpiredType { get; set; }

            /// <summary>
            /// 时效开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// 时效结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// ENABLE 启用 DISABLE禁用
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 订阅范围列表
            /// </summary>
            [NameInMap("scopeObjectList")]
            [Validation(Required=false)]
            public List<ListSubscriptionsResponseBodyDataScopeObjectList> ScopeObjectList { get; set; }
            public class ListSubscriptionsResponseBodyDataScopeObjectList : TeaModel {
                /// <summary>
                /// id主键
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 订阅范围类型 ALL全部 SERVICE服务 ROUTETULE流转规则
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public long? Scope { get; set; }

                /// <summary>
                /// 订阅范围对象关联表主键id
                /// </summary>
                [NameInMap("scopeObjectId")]
                [Validation(Required=false)]
                public long? ScopeObjectId { get; set; }

                /// <summary>
                /// 订阅范围对象名称
                /// </summary>
                [NameInMap("scopeObject")]
                [Validation(Required=false)]
                public string ScopeObject { get; set; }

            }

            /// <summary>
            /// 通知对象列表
            /// </summary>
            [NameInMap("notifyObjectList")]
            [Validation(Required=false)]
            public List<ListSubscriptionsResponseBodyDataNotifyObjectList> NotifyObjectList { get; set; }
            public class ListSubscriptionsResponseBodyDataNotifyObjectList : TeaModel {
                /// <summary>
                /// id主键
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 通知对象类型0服务组 1个人
                /// </summary>
                [NameInMap("notifyObjectType")]
                [Validation(Required=false)]
                public long? NotifyObjectType { get; set; }

                /// <summary>
                /// 关联主键id
                /// </summary>
                [NameInMap("notifyObjectId")]
                [Validation(Required=false)]
                public long? NotifyObjectId { get; set; }

                /// <summary>
                /// 通知对象名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
