// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCloudAssistantAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The installation status of Cloud Assistant on the instances.</para>
        /// </summary>
        [NameInMap("CloudAssistant")]
        [Validation(Required=false)]
        public List<DescribeCloudAssistantAttributesResponseBodyCloudAssistant> CloudAssistant { get; set; }
        public class DescribeCloudAssistantAttributesResponseBodyCloudAssistant : TeaModel {
            /// <summary>
            /// <para>The number of running tasks of Cloud Assistant on the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveTaskCount")]
            [Validation(Required=false)]
            public long? ActiveTaskCount { get; set; }

            /// <summary>
            /// <para>Indicates whether Cloud Assistant is running on the instance. Valid values:</para>
            /// <para>true: A heartbeat was detected within the last 2 minutes.</para>
            /// <para>false: No heartbeat was detected within the last 2 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// <para>The version number of the Cloud Assistant Agent. This value is empty if the Cloud Assistant Agent is not installed or is not running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.0.106</para>
            /// </summary>
            [NameInMap("CloudAssistantVersion")]
            [Validation(Required=false)]
            public string CloudAssistantVersion { get; set; }

            /// <summary>
            /// <para>The instance ID of the simple application server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85dbe3e7cc7b49e1a3df4af3bfa4ebbf</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of completed tasks of Cloud Assistant on the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            /// <summary>
            /// <para>The time of the last heartbeat of Cloud Assistant. This value is updated approximately every minute, with a random fluctuation of up to 5 seconds (minimum 55 seconds, maximum 65 seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-15T09:00:00Z</para>
            /// </summary>
            [NameInMap("LastHeartbeatTime")]
            [Validation(Required=false)]
            public string LastHeartbeatTime { get; set; }

            /// <summary>
            /// <para>The time when the last command was executed. The time is displayed in UTC (Z) in the YYYY-MM-DDThh:mm:ssZ format.</para>
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
            /// <item><description>Windows.</description></item>
            /// <item><description>Linux.</description></item>
            /// <item><description>FreeBSD.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// <para>Indicates whether Cloud Assistant on the instance supports the session management feature. If session management is not supported, the Cloud Assistant version is outdated. Update the client to the latest version.</para>
            /// <para>The minimum Cloud Assistant versions that support session management are as follows:</para>
            /// <para>Linux: 2.2.3.189
            /// Windows: 2.1.3.189</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportSessionManager")]
            [Validation(Required=false)]
            public bool? SupportSessionManager { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
