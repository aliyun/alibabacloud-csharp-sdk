// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceCloudAssistantStatusSet")]
        [Validation(Required=false)]
        public List<DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet> InstanceCloudAssistantStatusSet { get; set; }
        public class DescribeCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet : TeaModel {
            [NameInMap("CloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            [NameInMap("CloudAssistantVersion")]
            [Validation(Required=false)]
            public string CloudAssistantVersion { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
