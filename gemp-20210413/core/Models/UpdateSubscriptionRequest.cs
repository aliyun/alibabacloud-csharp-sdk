// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateSubscriptionRequest : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("expiredType")]
        [Validation(Required=false)]
        public string ExpiredType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("notifyObjectList")]
        [Validation(Required=false)]
        public List<UpdateSubscriptionRequestNotifyObjectList> NotifyObjectList { get; set; }
        public class UpdateSubscriptionRequestNotifyObjectList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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
        public string NotifyObjectType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("notifyStrategyList")]
        [Validation(Required=false)]
        public List<UpdateSubscriptionRequestNotifyStrategyList> NotifyStrategyList { get; set; }
        public class UpdateSubscriptionRequestNotifyStrategyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public long? InstanceType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("strategies")]
            [Validation(Required=false)]
            public List<UpdateSubscriptionRequestNotifyStrategyListStrategies> Strategies { get; set; }
            public class UpdateSubscriptionRequestNotifyStrategyListStrategies : TeaModel {
                [NameInMap("channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<UpdateSubscriptionRequestNotifyStrategyListStrategiesConditions> Conditions { get; set; }
                public class UpdateSubscriptionRequestNotifyStrategyListStrategiesConditions : TeaModel {
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
                public string Id { get; set; }

                [NameInMap("periodChannel")]
                [Validation(Required=false)]
                public UpdateSubscriptionRequestNotifyStrategyListStrategiesPeriodChannel PeriodChannel { get; set; }
                public class UpdateSubscriptionRequestNotifyStrategyListStrategiesPeriodChannel : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scopeObjectList")]
        [Validation(Required=false)]
        public List<UpdateSubscriptionRequestScopeObjectList> ScopeObjectList { get; set; }
        public class UpdateSubscriptionRequestScopeObjectList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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
        [NameInMap("subscriptionId")]
        [Validation(Required=false)]
        public long? SubscriptionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subscriptionTitle")]
        [Validation(Required=false)]
        public string SubscriptionTitle { get; set; }

    }

}
