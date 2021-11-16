// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetSubscriptionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSubscriptionResponseBodyData Data { get; set; }
        public class GetSubscriptionResponseBodyData : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("expiredType")]
            [Validation(Required=false)]
            public string ExpiredType { get; set; }
            [NameInMap("notifyObjectList")]
            [Validation(Required=false)]
            public List<GetSubscriptionResponseBodyDataNotifyObjectList> NotifyObjectList { get; set; }
            public class GetSubscriptionResponseBodyDataNotifyObjectList : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
                public long? NotifyObjectId { get; set; }
                public long? NotifyObjectType { get; set; }
            }
            [NameInMap("notifyObjectType")]
            [Validation(Required=false)]
            public string NotifyObjectType { get; set; }
            [NameInMap("notifyStrategyList")]
            [Validation(Required=false)]
            public List<GetSubscriptionResponseBodyDataNotifyStrategyList> NotifyStrategyList { get; set; }
            public class GetSubscriptionResponseBodyDataNotifyStrategyList : TeaModel {
                public long? InstanceType { get; set; }
                public List<GetSubscriptionResponseBodyDataNotifyStrategyListStrategies> Strategies { get; set; }
                public class GetSubscriptionResponseBodyDataNotifyStrategyListStrategies : TeaModel {
                    public string Channels { get; set; }
                    public List<GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesConditions> Conditions { get; set; }
                    public class GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesConditions : TeaModel {
                        public string Action { get; set; }
                        public string Effection { get; set; }
                        public string Level { get; set; }
                        public string ProblemNotifyType { get; set; }
                    }
                    public long? Id { get; set; }
                    public GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesPeriodChannel PeriodChannel { get; set; }
                    public class GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesPeriodChannel : TeaModel {
                        /// <summary>
                        /// 非工作时间
                        /// </summary>
                        [NameInMap("nonWorkday")]
                        [Validation(Required=false)]
                        public string NonWorkday { get; set; }

                        /// <summary>
                        /// 工作时间
                        /// </summary>
                        [NameInMap("workday")]
                        [Validation(Required=false)]
                        public string Workday { get; set; }

                    }
                }
            }
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }
            [NameInMap("scopeObjectList")]
            [Validation(Required=false)]
            public List<GetSubscriptionResponseBodyDataScopeObjectList> ScopeObjectList { get; set; }
            public class GetSubscriptionResponseBodyDataScopeObjectList : TeaModel {
                public long? Id { get; set; }
                public string Scope { get; set; }
                public string ScopeObject { get; set; }
                public long? ScopeObjectId { get; set; }
            }
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("subscriptionId")]
            [Validation(Required=false)]
            public long? SubscriptionId { get; set; }
            [NameInMap("subscriptionTitle")]
            [Validation(Required=false)]
            public string SubscriptionTitle { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
