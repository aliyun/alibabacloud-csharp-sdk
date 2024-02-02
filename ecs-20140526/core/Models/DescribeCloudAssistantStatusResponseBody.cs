// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantStatusResponseBody : TeaModel {
        /// <summary>
        /// Details about the installation status of Cloud Assistant Agent on the instances.
        /// </summary>
        [NameInMap("InstanceCloudAssistantStatusSet")]
        [Validation(Required=false)]
        public DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet InstanceCloudAssistantStatusSet { get; set; }
        public class DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet : TeaModel {
            [NameInMap("InstanceCloudAssistantStatus")]
            [Validation(Required=false)]
            public List<DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSetInstanceCloudAssistantStatus> InstanceCloudAssistantStatus { get; set; }
            public class DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSetInstanceCloudAssistantStatus : TeaModel {
                /// <summary>
                /// The number of tasks that were being run by Cloud Assistant on the instance.
                /// </summary>
                [NameInMap("ActiveTaskCount")]
                [Validation(Required=false)]
                public long? ActiveTaskCount { get; set; }

                /// <summary>
                /// Indicates whether Cloud Assistant is running on the instance. Valid values:
                /// 
                /// *   true: Heartbeats are detected within 2 minutes.
                /// *   false: Heartbeats are not detected within 2 minutes.
                /// </summary>
                [NameInMap("CloudAssistantStatus")]
                [Validation(Required=false)]
                public string CloudAssistantStatus { get; set; }

                /// <summary>
                /// The version number of Cloud Assistant Agent. This parameter is empty if Cloud Assistant Agent is not installed or is not running on the instance.
                /// </summary>
                [NameInMap("CloudAssistantVersion")]
                [Validation(Required=false)]
                public string CloudAssistantVersion { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The number of tasks that were completed by Cloud Assistant on the instance.
                /// </summary>
                [NameInMap("InvocationCount")]
                [Validation(Required=false)]
                public long? InvocationCount { get; set; }

                /// <summary>
                /// The last heartbeat time of Cloud Assistant. The value is updated every minute on average. The interval can be 55, 60, or 65 seconds.
                /// </summary>
                [NameInMap("LastHeartbeatTime")]
                [Validation(Required=false)]
                public string LastHeartbeatTime { get; set; }

                /// <summary>
                /// The time when commands were last run.
                /// </summary>
                [NameInMap("LastInvokedTime")]
                [Validation(Required=false)]
                public string LastInvokedTime { get; set; }

                /// <summary>
                /// The operating system type of the instance. Valid values:
                /// 
                /// *   Windows
                /// *   Linux
                /// *   FreeBSD
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                /// <summary>
                /// Indicates whether Cloud Assistant supports Session Manager on the instance. If Session Manager is not supported, the version of Cloud Assistant is outdated. Update Cloud Assistant Agent to the latest version.
                /// 
                /// To support Session Manager, the Cloud Assistant version must be no earlier than the following ones:
                /// 
                /// *   Linux: 2.2.3.189
                /// *   Windows: 2.1.3.189
                /// </summary>
                [NameInMap("SupportSessionManager")]
                [Validation(Required=false)]
                public bool? SupportSessionManager { get; set; }

            }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
