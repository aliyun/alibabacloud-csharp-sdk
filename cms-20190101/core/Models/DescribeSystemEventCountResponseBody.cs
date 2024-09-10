// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventCountResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status codes.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// If the request was successful, a success message is returned. If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The details of the system event.
        /// </summary>
        [NameInMap("SystemEventCounts")]
        [Validation(Required=false)]
        public DescribeSystemEventCountResponseBodySystemEventCounts SystemEventCounts { get; set; }
        public class DescribeSystemEventCountResponseBodySystemEventCounts : TeaModel {
            [NameInMap("SystemEventCount")]
            [Validation(Required=false)]
            public List<DescribeSystemEventCountResponseBodySystemEventCountsSystemEventCount> SystemEventCount { get; set; }
            public class DescribeSystemEventCountResponseBodySystemEventCountsSystemEventCount : TeaModel {
                /// <summary>
                /// The description of the system event.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The level of the system event. Valid values:
                /// 
                /// *   Critical
                /// *   Warn
                /// *   Info
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The name of the system event.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of times that the system event has occurred.
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

                /// <summary>
                /// The name of the cloud service in which the system event occurred.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource ID.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The status of the system event.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the system event occurred. The value is a timestamp. Unit: milliseconds.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

        }

    }

}
