// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupEventsRequest : TeaModel {
        /// <summary>
        /// The IDs of the elastic container instances. You can specify up to 20 IDs. Each ID must be a JSON string.
        /// </summary>
        [NameInMap("ContainerGroupIds")]
        [Validation(Required=false)]
        public string ContainerGroupIds { get; set; }

        /// <summary>
        /// The event source. Valid values:
        /// 
        /// *   EciService
        /// *   K8sAgent
        /// 
        /// This parameter is empty by default. This indicates that all events are queried.
        /// </summary>
        [NameInMap("EventSource")]
        [Validation(Required=false)]
        public string EventSource { get; set; }

        /// <summary>
        /// The maximum number of elastic container instances to be returned for this request. Default value: 200.
        /// 
        /// >  The number of elastic container instances to be returned is no greater than this parameter value.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// 
        /// You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// A relative time in seconds before the current time from which to show event information. This parameter is used to poll incremental events.
        /// </summary>
        [NameInMap("SinceSecond")]
        [Validation(Required=false)]
        public int? SinceSecond { get; set; }

        /// <summary>
        /// The tag that is added to the elastic container instances.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupEventsRequestTag> Tag { get; set; }
        public class DescribeContainerGroupEventsRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The vSwitch ID.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
