// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantStatusResponseBody : TeaModel {
        [NameInMap("InstanceCloudAssistantStatusSet")]
        [Validation(Required=false)]
        public DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet InstanceCloudAssistantStatusSet { get; set; }
        public class DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet : TeaModel {
            [NameInMap("InstanceCloudAssistantStatus")]
            [Validation(Required=false)]
            public List<DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSetInstanceCloudAssistantStatus> InstanceCloudAssistantStatus { get; set; }
            public class DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSetInstanceCloudAssistantStatus : TeaModel {
                [NameInMap("ActiveTaskCount")]
                [Validation(Required=false)]
                public long? ActiveTaskCount { get; set; }

                [NameInMap("CloudAssistantStatus")]
                [Validation(Required=false)]
                public string CloudAssistantStatus { get; set; }

                [NameInMap("CloudAssistantVersion")]
                [Validation(Required=false)]
                public string CloudAssistantVersion { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InvocationCount")]
                [Validation(Required=false)]
                public long? InvocationCount { get; set; }

                [NameInMap("LastHeartbeatTime")]
                [Validation(Required=false)]
                public string LastHeartbeatTime { get; set; }

                [NameInMap("LastInvokedTime")]
                [Validation(Required=false)]
                public string LastInvokedTime { get; set; }

                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                [NameInMap("SupportSessionManager")]
                [Validation(Required=false)]
                public bool? SupportSessionManager { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
