// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListNodesResponseBodyHeaders Headers { get; set; }
        public class ListNodesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The number of entries returned.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyResult> Result { get; set; }
        public class ListNodesResponseBodyResult : TeaModel {
            /// <summary>
            /// The status of the shipper on the ECS instance. Valid values:
            /// 
            /// *   heartOk: The heartbeat is normal.
            /// *   heartLost: The heartbeat is abnormal.
            /// *   uninstalled: The shipper is not installed.
            /// *   failed: The shipper fails to be installed.
            /// </summary>
            [NameInMap("agentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// Indicates whether the Cloud Assistant client is installed. Valid values:
            /// 
            /// *   true: installed
            /// *   false: not installed
            /// </summary>
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// The ID of the ECS instance.
            /// </summary>
            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// The name of the ECS instance.
            /// </summary>
            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            /// <summary>
            /// The IP addresses of the ECS instance.
            /// </summary>
            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyResultIpAddress> IpAddress { get; set; }
            public class ListNodesResponseBodyResultIpAddress : TeaModel {
                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The type of the IP address. Valid values:
                /// 
                /// *   public: public IP address
                /// *   private: private IP address
                /// </summary>
                [NameInMap("ipType")]
                [Validation(Required=false)]
                public string IpType { get; set; }

            }

            /// <summary>
            /// The operating system type of the ECS instance. Valid values:
            /// 
            /// *   windows: Windows Server
            /// *   linux: Linux
            /// </summary>
            [NameInMap("osType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The status of the ECS instance. Valid values:
            /// 
            /// *   running: The instance is running.
            /// *   starting: The instance is being started.
            /// *   stopping: The instance is being stopped.
            /// *   stopped: The instance is stopped.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the ECS instance.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyResultTags> Tags { get; set; }
            public class ListNodesResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
