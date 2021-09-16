// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateSubscriptionRequest : TeaModel {
        /// <summary>
        /// 主键
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
        /// 订阅范围类型
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// 通知对象类型
        /// </summary>
        [NameInMap("notifyObjectType")]
        [Validation(Required=false)]
        public string NotifyObjectType { get; set; }

        /// <summary>
        /// 订阅时效
        /// </summary>
        [NameInMap("expiredType")]
        [Validation(Required=false)]
        public string ExpiredType { get; set; }

        /// <summary>
        /// 订阅范围列表
        /// </summary>
        [NameInMap("scopeObjectList")]
        [Validation(Required=false)]
        public List<UpdateSubscriptionRequestScopeObjectList> ScopeObjectList { get; set; }
        public class UpdateSubscriptionRequestScopeObjectList : TeaModel {
            /// <summary>
            /// 主键id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 订阅范围对象id
            /// </summary>
            [NameInMap("scopeObjectId")]
            [Validation(Required=false)]
            public long? ScopeObjectId { get; set; }

        }

        /// <summary>
        /// 通知对象列表
        /// </summary>
        [NameInMap("notifyObjectList")]
        [Validation(Required=false)]
        public List<UpdateSubscriptionRequestNotifyObjectList> NotifyObjectList { get; set; }
        public class UpdateSubscriptionRequestNotifyObjectList : TeaModel {
            /// <summary>
            /// 主键id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 通知对象id
            /// </summary>
            [NameInMap("notifyObjectId")]
            [Validation(Required=false)]
            public long? NotifyObjectId { get; set; }

        }

        /// <summary>
        /// 通知策略列表
        /// </summary>
        [NameInMap("notifyStrategyList")]
        [Validation(Required=false)]
        public List<UpdateSubscriptionRequestNotifyStrategyList> NotifyStrategyList { get; set; }
        public class UpdateSubscriptionRequestNotifyStrategyList : TeaModel {
            /// <summary>
            /// 订阅实例类型，事件、报警、故障
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public long? InstanceType { get; set; }

            /// <summary>
            /// 通知策略
            /// </summary>
            [NameInMap("strategies")]
            [Validation(Required=false)]
            public List<UpdateSubscriptionRequestNotifyStrategyListStrategies> Strategies { get; set; }
            public class UpdateSubscriptionRequestNotifyStrategyListStrategies : TeaModel {
                /// <summary>
                /// id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 故障等级
                /// </summary>
                [NameInMap("channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// 影响程度
                /// </summary>
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<UpdateSubscriptionRequestNotifyStrategyListStrategiesConditions> Conditions { get; set; }
                public class UpdateSubscriptionRequestNotifyStrategyListStrategiesConditions : TeaModel {
                    /// <summary>
                    /// 等级
                    /// </summary>
                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// 影响程度
                    /// </summary>
                    [NameInMap("effection")]
                    [Validation(Required=false)]
                    public string Effection { get; set; }

                    /// <summary>
                    /// 故障通知类型
                    /// </summary>
                    [NameInMap("problemNotifyType")]
                    [Validation(Required=false)]
                    public string ProblemNotifyType { get; set; }

                    /// <summary>
                    /// 事件动作
                    /// </summary>
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                }

            }

        }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

    }

}
