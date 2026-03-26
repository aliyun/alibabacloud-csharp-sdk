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

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
