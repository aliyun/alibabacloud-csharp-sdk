// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCCloudAssistantStatusResponseBody : TeaModel {
        [NameInMap("InstanceCloudAssistantStatusSet")]
        [Validation(Required=false)]
        public List<DescribeRCCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet> InstanceCloudAssistantStatusSet { get; set; }
        public class DescribeRCCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet : TeaModel {
            [NameInMap("ActiveTaskCount")]
            [Validation(Required=false)]
            public int? ActiveTaskCount { get; set; }

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
            public int? InvocationCount { get; set; }

            [NameInMap("LastHeartbeatTime")]
            [Validation(Required=false)]
            public string LastHeartbeatTime { get; set; }

            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            [NameInMap("SupportSessionManager")]
            [Validation(Required=false)]
            public bool? SupportSessionManager { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
