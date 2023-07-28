// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventHistogramRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the system event.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](~~114972~~) operation to view the types of system events.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The level of the system event. Valid values:
        /// 
        /// *   CRITICAL
        /// *   WARN
        /// *   INFO
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The name of the system event.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](~~114972~~) operation to view the names of system events.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the service name.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](~~114972~~) operation to view the abbreviations of service names.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The keywords contained in the content of the system event to query. You can use a logical operator between keywords. Examples:
        /// 
        /// *   If you need to query the system event whose content contains a and b, set the value to `a and b`.
        /// *   If you need to query the system event whose content contains a or b, set the value to `a or b`.
        /// </summary>
        [NameInMap("SearchKeywords")]
        [Validation(Required=false)]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the system event.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](~~114972~~) operation to view the statuses of system events.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
