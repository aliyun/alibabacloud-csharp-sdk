// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The list of namespaces.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeNamespaceListResponseBodyData> Data { get; set; }
        public class DescribeNamespaceListResponseBodyData : TeaModel {
            /// <summary>
            /// The command that was run to install the agent.
            /// </summary>
            [NameInMap("AgentInstall")]
            [Validation(Required=false)]
            public string AgentInstall { get; set; }

            /// <summary>
            /// This parameter is no longer valid.
            /// </summary>
            [NameInMap("Current")]
            [Validation(Required=false)]
            public bool? Current { get; set; }

            /// <summary>
            /// Indicates whether custom namespaces are returned. Valid values:
            /// 
            /// *   **true**: Custom namespaces are returned.
            /// *   **false**: Custom namespaces are not returned.
            /// </summary>
            [NameInMap("Custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// Specifies whether hybrid cloud namespaces are excluded. Valid values:
            /// 
            /// *   **true**: Hybrid cloud namespaces are excluded.
            /// *   **false**: Hybrid cloud namespaces are included.
            /// </summary>
            [NameInMap("HybridCloudEnable")]
            [Validation(Required=false)]
            public bool? HybridCloudEnable { get; set; }

            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// The region to which the namespace belongs.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The returned error code. Valid values:
        /// 
        /// *   If the call is successful, the **ErrorCode** parameter is not returned.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned information. Valid values:
        /// 
        /// *   success: If the call is successful, **success** is returned.
        /// *   An error code: If the call fails, an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the namespaces were obtained. Valid values:
        /// 
        /// *   **true**: The namespaces were obtained.
        /// *   **false**: The namespaces failed to be obtained.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
