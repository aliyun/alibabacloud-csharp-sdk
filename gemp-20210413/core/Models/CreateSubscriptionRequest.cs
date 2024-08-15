// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateSubscriptionRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("expiredType")]
        [Validation(Required=false)]
        public long? ExpiredType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("notifyObjectList")]
        [Validation(Required=false)]
        public List<CreateSubscriptionRequestNotifyObjectList> NotifyObjectList { get; set; }
        public class CreateSubscriptionRequestNotifyObjectList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("notifyObjectId")]
            [Validation(Required=false)]
            public long? NotifyObjectId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("notifyObjectType")]
        [Validation(Required=false)]
        public long? NotifyObjectType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("notifyStrategyList")]
        [Validation(Required=false)]
        public List<CreateSubscriptionRequestNotifyStrategyList> NotifyStrategyList { get; set; }
        public class CreateSubscriptionRequestNotifyStrategyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("channels")]
            [Validation(Required=false)]
            public string Channels { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public long? InstanceType { get; set; }

            [NameInMap("periodChannel")]
            [Validation(Required=false)]
            public CreateSubscriptionRequestNotifyStrategyListPeriodChannel PeriodChannel { get; set; }
            public class CreateSubscriptionRequestNotifyStrategyListPeriodChannel : TeaModel {
                [NameInMap("nonWorkday")]
                [Validation(Required=false)]
                public string NonWorkday { get; set; }

                [NameInMap("workday")]
                [Validation(Required=false)]
                public string Workday { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("strategies")]
            [Validation(Required=false)]
            public List<CreateSubscriptionRequestNotifyStrategyListStrategies> Strategies { get; set; }
            public class CreateSubscriptionRequestNotifyStrategyListStrategies : TeaModel {
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<CreateSubscriptionRequestNotifyStrategyListStrategiesConditions> Conditions { get; set; }
                public class CreateSubscriptionRequestNotifyStrategyListStrategiesConditions : TeaModel {
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

            }

        }

        [NameInMap("period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public long? Scope { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scopeObjectList")]
        [Validation(Required=false)]
        public List<CreateSubscriptionRequestScopeObjectList> ScopeObjectList { get; set; }
        public class CreateSubscriptionRequestScopeObjectList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scopeObjectId")]
            [Validation(Required=false)]
            public long? ScopeObjectId { get; set; }

        }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subscriptionTitle")]
        [Validation(Required=false)]
        public string SubscriptionTitle { get; set; }

    }

}
