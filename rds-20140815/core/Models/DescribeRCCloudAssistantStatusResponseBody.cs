// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCCloudAssistantStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the installation status of Cloud Assistant on the instances.</para>
        /// </summary>
        [NameInMap("InstanceCloudAssistantStatusSet")]
        [Validation(Required=false)]
        public List<DescribeRCCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet> InstanceCloudAssistantStatusSet { get; set; }
        public class DescribeRCCloudAssistantStatusResponseBodyInstanceCloudAssistantStatusSet : TeaModel {
            /// <summary>
            /// <para>The number of tasks that Cloud Assistant was running on the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveTaskCount")]
            [Validation(Required=false)]
            public int? ActiveTaskCount { get; set; }

            /// <summary>
            /// <para>Indicates whether Cloud Assistant is running on the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Heartbeats are detected in the last 2 minutes.</description></item>
            /// <item><description><b>false</b>: No heartbeat is detected in the last 2 minutes.</description></item>
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
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-e2g521l55k038cr8****</para>
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
            public int? InvocationCount { get; set; }

            /// <summary>
            /// <para>The last heartbeat time of Cloud Assistant. The value is updated every minute on average. The interval can be 55, 60, or 65 seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-15T09:00:00Z</para>
            /// </summary>
            [NameInMap("LastHeartbeatTime")]
            [Validation(Required=false)]
            public string LastHeartbeatTime { get; set; }

            /// <summary>
            /// <para>The time when commands were last run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-15T09:00:00Z</para>
            /// </summary>
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            /// <summary>
            /// <para>The operating system type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// <para>Indicates whether Cloud Assistant supports Session Manager on the instance. If Session Manager is not supported, the version of Cloud Assistant Agent is outdated. Update Cloud Assistant Agent to the latest version.</para>
            /// <para>To support Session Manager, the version of Cloud Assistant Agent cannot be earlier than 2.2.3.189.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportSessionManager")]
            [Validation(Required=false)]
            public bool? SupportSessionManager { get; set; }

        }

        /// <summary>
        /// <para>The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.</para>
        /// <para>This parameter is required.</para>
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
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0688F1D2-CDA8-5617-A43C-ADAC61D80D43</para>
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
        public int? TotalCount { get; set; }

    }

}
