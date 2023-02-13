// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// The status information of the instances.
        /// </summary>
        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public DescribeInstanceStatusResponseBodyInstanceStatuses InstanceStatuses { get; set; }
        public class DescribeInstanceStatusResponseBodyInstanceStatuses : TeaModel {
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public List<DescribeInstanceStatusResponseBodyInstanceStatusesInstanceStatus> InstanceStatus { get; set; }
            public class DescribeInstanceStatusResponseBodyInstanceStatusesInstanceStatus : TeaModel {
                /// <summary>
                /// The ID of instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The state of the instance. Valid values:
                /// 
                /// * Pending: The instance is being created.
                /// * Running: The instance is running.
                /// * Starting: The instance is being started.
                /// * Stopping: The instance is being stopped.
                /// * Stopped: The instance is stopped.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
