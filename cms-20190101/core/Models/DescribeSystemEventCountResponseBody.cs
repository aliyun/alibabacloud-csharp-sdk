// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventCountResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The details of the system event.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the system event.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The timestamp when the system event occurred. Unit: milliseconds.
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
                /// The ID of the region.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// This topic provides an example on how to query the number of times that a system event occurred for Elastic Compute Service (`ECS`). The returned result indicates that the number of times that the specified system event occurred is 3.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The level of the system event. Valid values:
                /// 
                /// *   Critical
                /// *   Warn
                /// *   Info
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the system event.
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

                /// <summary>
                /// The number of times that the system event occurred.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The description of the system event.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The name of the cloud service in which the system event occurred.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

        }

    }

}
