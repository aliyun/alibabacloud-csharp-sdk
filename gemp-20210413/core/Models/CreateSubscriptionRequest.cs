// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateSubscriptionRequest : TeaModel {
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
        public long? Scope { get; set; }

        /// <summary>
        /// 通知对象类型
        /// </summary>
        [NameInMap("notifyObjectType")]
        [Validation(Required=false)]
        public long? NotifyObjectType { get; set; }

        /// <summary>
        /// 订阅时效
        /// </summary>
        [NameInMap("expiredType")]
        [Validation(Required=false)]
        public long? ExpiredType { get; set; }

        /// <summary>
        /// 订阅范围列表
        /// </summary>
        [NameInMap("scopeObjectList")]
        [Validation(Required=false)]
        public List<CreateSubscriptionRequestScopeObjectList> ScopeObjectList { get; set; }
        public class CreateSubscriptionRequestScopeObjectList : TeaModel {
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
        public List<CreateSubscriptionRequestNotifyObjectList> NotifyObjectList { get; set; }
        public class CreateSubscriptionRequestNotifyObjectList : TeaModel {
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
        public List<CreateSubscriptionRequestNotifyStrategyList> NotifyStrategyList { get; set; }
        public class CreateSubscriptionRequestNotifyStrategyList : TeaModel {
            /// <summary>
            /// 订阅实例类型，事件、报警、故障
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public long? InstanceType { get; set; }

            /// <summary>
            /// 条件。json格式，包含多个条件，比如级别、影响程度 kv格式
            /// </summary>
            [NameInMap("strategies")]
            [Validation(Required=false)]
            public List<CreateSubscriptionRequestNotifyStrategyListStrategies> Strategies { get; set; }
            public class CreateSubscriptionRequestNotifyStrategyListStrategies : TeaModel {
                /// <summary>
                /// 通知策略条件
                /// </summary>
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<CreateSubscriptionRequestNotifyStrategyListStrategiesConditions> Conditions { get; set; }
                public class CreateSubscriptionRequestNotifyStrategyListStrategiesConditions : TeaModel {
                    /// <summary>
                    /// 影响范围
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
                    /// 等级
                    /// </summary>
                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

            }

            /// <summary>
            /// 渠道，多个逗号分隔
            /// </summary>
            [NameInMap("channels")]
            [Validation(Required=false)]
            public string Channels { get; set; }

        }

        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
