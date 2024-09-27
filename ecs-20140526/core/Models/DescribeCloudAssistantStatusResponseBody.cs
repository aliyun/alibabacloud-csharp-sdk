// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the installation status of Cloud Assistant on the instances.</para>
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
                /// <para>The number of tasks that Cloud Assistant was running on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ActiveTaskCount")]
                [Validation(Required=false)]
                public long? ActiveTaskCount { get; set; }

                /// <summary>
                /// <para>Indicates whether Cloud Assistant is running on the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Heartbeats are detected in the last 2 minutes.</description></item>
                /// <item><description>false: No heartbeats are detected in the last 2 minutes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CloudAssistantStatus")]
                [Validation(Required=false)]
                public string CloudAssistantStatus { get; set; }

                /// <summary>
                /// <para>The version number of Cloud Assistant Agent. This parameter is empty if Cloud Assistant Agent is not installed or is not running on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.2.0.106</para>
                /// </summary>
                [NameInMap("CloudAssistantVersion")]
                [Validation(Required=false)]
                public string CloudAssistantVersion { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1iudwa5b1tqa****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The number of tasks that Cloud Assistant completed on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("InvocationCount")]
                [Validation(Required=false)]
                public long? InvocationCount { get; set; }

                /// <summary>
                /// <para>The last heartbeat time of Cloud Assistant. The value is updated every minute on average. The interval can be 55, 60, or 65 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-15T09:00:00Z</para>
                /// </summary>
                [NameInMap("LastHeartbeatTime")]
                [Validation(Required=false)]
                public string LastHeartbeatTime { get; set; }

                /// <summary>
                /// <para>The time when commands were last run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-15T08:00:00Z</para>
                /// </summary>
                [NameInMap("LastInvokedTime")]
                [Validation(Required=false)]
                public string LastInvokedTime { get; set; }

                /// <summary>
                /// <para>The operating system type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Windows</description></item>
                /// <item><description>Linux</description></item>
                /// <item><description>FreeBSD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                /// <summary>
                /// <para>Indicates whether Cloud Assistant supports Session Manager on the instance. If Session Manager is not supported, the version of Cloud Assistant Agent is outdated. Update Cloud Assistant Agent to the latest version.</para>
                /// <para>To support Session Manager, the version of Cloud Assistant Agent cannot be earlier than the following versions:</para>
                /// <list type="bullet">
                /// <item><description>Linux: 2.2.3.189</description></item>
                /// <item><description>Windows: 2.1.3.189</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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
