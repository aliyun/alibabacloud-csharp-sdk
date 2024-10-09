// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCloudAssistantAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The Command Assistant information.</para>
        /// </summary>
        [NameInMap("CloudAssistant")]
        [Validation(Required=false)]
        public List<DescribeCloudAssistantAttributesResponseBodyCloudAssistant> CloudAssistant { get; set; }
        public class DescribeCloudAssistantAttributesResponseBodyCloudAssistant : TeaModel {
            /// <summary>
            /// <para>The number of active tasks in Command Assistant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveTaskCount")]
            [Validation(Required=false)]
            public long? ActiveTaskCount { get; set; }

            /// <summary>
            /// <para>Indicates whether Command Assistant is running. Valid values:</para>
            /// <para>true: Heartbeats are detected in the last 2 minutes.</para>
            /// <para>false: Heartbeats are not detected in the last 2 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// <para>The version number of the Command Assistant agent. Null is returned if the Command Assistant agent is not installed or is not running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.0.106</para>
            /// </summary>
            [NameInMap("CloudAssistantVersion")]
            [Validation(Required=false)]
            public string CloudAssistantVersion { get; set; }

            /// <summary>
            /// <para>The ID of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85dbe3e7cc7b49e1a3df4af3bfa4ebbf</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of completed tasks in Command Assistant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            /// <summary>
            /// <para>The time when the last heartbeat of Command Assistant was detected. The value is updated every minute on average. The interval can be 55, 60, or 65 seconds.</para>
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
            /// <para>The OS type of the simple application server. Valid values:</para>
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
            /// <para>Indicates whether Command Assistant supports session management. If Command Assistant does not support session management, the version of the Command Assistant agent is too earlier. We recommend that you update your Command Assistant agent to the latest version.</para>
            /// <para>To use the session management feature, you must make sure that the version of your Command Assistant agent meets one of the following requirements:</para>
            /// <para>If your simple application server runs Linux, the version of the Command Assistant agent on the server must be 2.2.3.189 or later. If your simple application server runs Windows, the version of the Command Assistant agent on the server must be 2.1.3.189 or later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportSessionManager")]
            [Validation(Required=false)]
            public bool? SupportSessionManager { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
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
