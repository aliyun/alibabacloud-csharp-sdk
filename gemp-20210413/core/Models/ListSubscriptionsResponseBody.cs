// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSubscriptionsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSubscriptionsResponseBodyData> Data { get; set; }
        public class ListSubscriptionsResponseBodyData : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("expiredType")]
            [Validation(Required=false)]
            public string ExpiredType { get; set; }

            [NameInMap("notifyObjectList")]
            [Validation(Required=false)]
            public List<ListSubscriptionsResponseBodyDataNotifyObjectList> NotifyObjectList { get; set; }
            public class ListSubscriptionsResponseBodyDataNotifyObjectList : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("isValid")]
                [Validation(Required=false)]
                public long? IsValid { get; set; }

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
            public long? NotifyObjectType { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public long? Scope { get; set; }

            [NameInMap("scopeObjectList")]
            [Validation(Required=false)]
            public List<ListSubscriptionsResponseBodyDataScopeObjectList> ScopeObjectList { get; set; }
            public class ListSubscriptionsResponseBodyDataScopeObjectList : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("isValid")]
                [Validation(Required=false)]
                public long? IsValid { get; set; }

                [NameInMap("scope")]
                [Validation(Required=false)]
                public long? Scope { get; set; }

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

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
