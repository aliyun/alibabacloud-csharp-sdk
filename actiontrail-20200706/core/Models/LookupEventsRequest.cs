// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class LookupEventsRequest : TeaModel {
        /// <summary>
        /// The order in which details of events are to be retrieved. Valid values:
        /// 
        /// *   FORWARD: ascending order.
        /// *   BACKWARD: descending order. This is the default value.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The end of the time range to query. The default time is the current time. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Query conditions.
        /// </summary>
        [NameInMap("LookupAttribute")]
        [Validation(Required=false)]
        public List<LookupEventsRequestLookupAttribute> LookupAttribute { get; set; }
        public class LookupEventsRequestLookupAttribute : TeaModel {
            /// <summary>
            /// The key of the query condition. Valid values:
            /// 
            /// *  ServiceName: the name of a specific Alibaba Cloud service.
            /// *  EventName: the name of a specific event.
            /// *  User: the name of the RAM user who calls a specific operation.
            /// *  EventId: the ID of a specific event.
            /// *  ResourceType: the type of resources.
            /// *   ResourceName: the name of a specific resource.
            /// *   EventRW: the read/write type of events.
            /// *  EventAccessKeyId: the AccessKey ID used in events.
            /// 
            /// > You can use only one query condition for each query.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the query condition. Valid values:
            /// 
            /// *   When the LookupAttribute.N.Key parameter is set to ServiceName, you can set this parameter to a value such as `Ecs`.
            /// *   When the LookupAttribute.N.Key parameter is set to EventName, you can set this parameter to a value such as `ConsoleSignin`.
            /// *   When the LookupAttribute.N.Key parameter is set to User, you can set this parameter to a value such as `Alice`.
            /// *   When the LookupAttribute.N.Key parameter is set to EventId, you can set this parameter to a value such as `B702AFA3-FD4B-40E3-88E4-C0752FAA****`.
            /// *   When the LookupAttribute.N.Key parameter is set to ResourceType, you can set this parameter to a value such as `ACS::ECS::Instance`.
            /// *   When the LookupAttribute.N.Key parameter is set to ResourceName, you can set this parameter to a value such as `i-bp14664y88udkt45****`.
            /// *   When the LookupAttribute.N.Key parameter is set to EventRW, you can set this parameter to `Read` or `Write`.
            /// *   When the LookupAttribute.N.Key parameter is set to EventAccessKeyId, you can set this parameter to a value such as `LTAI4FoDkCf4DU1bic1V****`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The maximum number of entries to be returned.
        /// 
        /// Valid values: 0 to 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// The token used to request the next page of query results.
        /// 
        /// > The request parameters must be the same as those of the last request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The default time is seven days prior to the current time. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
