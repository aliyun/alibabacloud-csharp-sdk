// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListNodesResponseBodyHeaders Headers { get; set; }
        public class ListNodesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of returned records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1FD7642-7C40-4FF2-9C0F-21F1A1746F70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyResult> Result { get; set; }
        public class ListNodesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The status of each collector on the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>heartOk: normal heartbeat.</description></item>
            /// <item><description>heartLost: abnormal heartbeat.</description></item>
            /// <item><description>uninstalled: not installed.</description></item>
            /// <item><description>failed: installation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>heartOk</para>
            /// </summary>
            [NameInMap("agentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether Cloud Assistant is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// <para>The ECS instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp13y63575oypr****</para>
            /// </summary>
            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The ECS instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_beat</para>
            /// </summary>
            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            /// <summary>
            /// <para>The list of IP address information of the ECS instance.</para>
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
                /// <item><description>public: public IP address.</description></item>
                /// <item><description>private: private IP address.</description></item>
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
            /// <item><description>windows: Windows Server.</description></item>
            /// <item><description>linux: Linux.</description></item>
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
            /// <item><description>running: running.</description></item>
            /// <item><description>starting: starting.</description></item>
            /// <item><description>stopping: stopping.</description></item>
            /// <item><description>stopped: stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag information of the ECS instance.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyResultTags> Tags { get; set; }
            public class ListNodesResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
