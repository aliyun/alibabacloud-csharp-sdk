// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The header of the response.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListNodesResponseBodyHeaders Headers { get; set; }
        public class ListNodesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1FD7642-7C40-4FF2-9C0F-21F1A1746F70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyResult> Result { get; set; }
        public class ListNodesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The status of the shipper on the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>heartOk: The heartbeat is normal.</description></item>
            /// <item><description>heartLost: The heartbeat is abnormal.</description></item>
            /// <item><description>uninstalled: The shipper is not installed.</description></item>
            /// <item><description>failed: The shipper fails to be installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>heartOk</para>
            /// </summary>
            [NameInMap("agentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the Cloud Assistant client is installed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: installed</description></item>
            /// <item><description>false: not installed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp13y63575oypr****</para>
            /// </summary>
            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_beat</para>
            /// </summary>
            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            /// <summary>
            /// <para>The IP addresses of the ECS instance.</para>
            /// </summary>
            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyResultIpAddress> IpAddress { get; set; }
            public class ListNodesResponseBodyResultIpAddress : TeaModel {
                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.xx.xx</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The type of the IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>public: public IP address</description></item>
                /// <item><description>private: private IP address</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("ipType")]
                [Validation(Required=false)]
                public string IpType { get; set; }

            }

            /// <summary>
            /// <para>The operating system type of the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows: Windows Server</description></item>
            /// <item><description>linux: Linux</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("osType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The status of the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: The instance is running.</description></item>
            /// <item><description>starting: The instance is being started.</description></item>
            /// <item><description>stopping: The instance is being stopped.</description></item>
            /// <item><description>stopped: The instance is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the ECS instance.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyResultTags> Tags { get; set; }
            public class ListNodesResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xyz</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
