// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// Object
        /// </summary>
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
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("notifyObjectId")]
                [Validation(Required=false)]
                public long? NotifyObjectId { get; set; }

                [NameInMap("notifyObjectType")]
                [Validation(Required=false)]
                public long? NotifyObjectType { get; set; }

            }

            [NameInMap("notifyObjectType")]
            [Validation(Required=false)]
            public string NotifyObjectType { get; set; }

            [NameInMap("notifyStrategyList")]
            [Validation(Required=false)]
            public List<GetSubscriptionResponseBodyDataNotifyStrategyList> NotifyStrategyList { get; set; }
            public class GetSubscriptionResponseBodyDataNotifyStrategyList : TeaModel {
                [NameInMap("instanceType")]
                [Validation(Required=false)]
                public long? InstanceType { get; set; }

                [NameInMap("strategies")]
                [Validation(Required=false)]
                public List<GetSubscriptionResponseBodyDataNotifyStrategyListStrategies> Strategies { get; set; }
                public class GetSubscriptionResponseBodyDataNotifyStrategyListStrategies : TeaModel {
                    [NameInMap("channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    [NameInMap("conditions")]
                    [Validation(Required=false)]
                    public List<GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesConditions> Conditions { get; set; }
                    public class GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesConditions : TeaModel {
                        [NameInMap("action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        [NameInMap("effection")]
                        [Validation(Required=false)]
                        public string Effection { get; set; }

                        [NameInMap("level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("problemNotifyType")]
                        [Validation(Required=false)]
                        public string ProblemNotifyType { get; set; }

                    }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("periodChannel")]
                    [Validation(Required=false)]
                    public GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesPeriodChannel PeriodChannel { get; set; }
                    public class GetSubscriptionResponseBodyDataNotifyStrategyListStrategiesPeriodChannel : TeaModel {
                        [NameInMap("nonWorkday")]
                        [Validation(Required=false)]
                        public string NonWorkday { get; set; }

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

            /// <summary>
            /// Array
            /// </summary>
            [NameInMap("scopeObjectList")]
            [Validation(Required=false)]
            public List<GetSubscriptionResponseBodyDataScopeObjectList> ScopeObjectList { get; set; }
            public class GetSubscriptionResponseBodyDataScopeObjectList : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("isValid")]
                [Validation(Required=false)]
                public long? IsValid { get; set; }

                [NameInMap("scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("scopeObject")]
                [Validation(Required=false)]
                public string ScopeObject { get; set; }

                [NameInMap("scopeObjectId")]
                [Validation(Required=false)]
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

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
