// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventCountRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the system event.
        /// 
        /// You can call the DescribeSystemEventMetaList operation to obtain the value of the response parameter `EventType`. The value of the EventType parameter indicates the types of system events that occurred for all cloud services in your Alibaba Cloud account. For more information, see [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html).
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
        /// *   Critical
        /// *   Warn
        /// *   Info
        /// 
        /// You can call the DescribeSystemEventMetaList operation to obtain the value of the response parameter `Level`. The value of the Level parameter indicates the levels of system events that occurred for all cloud services in your Alibaba Cloud account. For more information, see [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html).
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The name of the system event.
        /// 
        /// You can call the DescribeSystemEventMetaList operation to obtain the value of the response parameter `Name`. The value of the Name parameter indicates the names of system events that occurred for all cloud services in your Alibaba Cloud account. For more information, see [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the cloud service.
        /// 
        /// You can call the DescribeSystemEventMetaList operation to obtain the value of the response parameter `Product`. The value of the Product parameter indicates the names of all cloud services in which the system events of your Alibaba Cloud account occurred. For more information, see [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html).
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
        /// The beginning of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the system event.
        /// 
        /// You can call the DescribeSystemEventMetaList operation to obtain the value of the response parameter `Status`. The value of the Status parameter indicates the status of system events that occurred for all cloud services in your Alibaba Cloud account. For more information, see [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html).
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
