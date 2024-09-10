// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventAttributeRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// 
        /// The value must be a UNIX timestamp. It is the number of seconds that have elapsed since 00:00:00 UTC, January 1, 1970.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the system event.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html) operation to query the types of system events.
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
        /// *   CRITICAL: critical
        /// *   WARN: warning
        /// *   INFO: information
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The name of the system event.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html) operation to query the names of system events.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Valid values: 1 to 100000000.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The abbreviation of the service name.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html) operation to query the abbreviations of service names.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The keywords that are used to search for the system event. Valid values:
        /// 
        /// *   If you want to search for the system event whose content contains a and b, set the value to `a and b`.
        /// *   If you want to search for the system event whose content contains a or b, set the value to `a or b`.
        /// </summary>
        [NameInMap("SearchKeywords")]
        [Validation(Required=false)]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// The value must be a UNIX timestamp. It is the number of seconds that have elapsed since 00:00:00 UTC, January 1, 1970.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the system event.
        /// 
        /// >  You can call the [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html) operation to query the statuses of system events.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
