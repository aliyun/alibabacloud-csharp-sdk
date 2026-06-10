// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstancesWithEcsInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstancesWithEcsInfoResponseBodyData> Data { get; set; }
        public class ListInstancesWithEcsInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Cluster ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbf7a37bc905d4682a3338b3744810269</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp118piqcio9tiwgh84b</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allowed-repos-r2tzl</para>
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>tags of instances</para>
            /// </summary>
            [NameInMap("instance_tag")]
            [Validation(Required=false)]
            public List<ListInstancesWithEcsInfoResponseBodyDataInstanceTag> InstanceTag { get; set; }
            public class ListInstancesWithEcsInfoResponseBodyDataInstanceTag : TeaModel {
                /// <summary>
                /// <para>Name of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tag_key</para>
                /// </summary>
                [NameInMap("tag_key")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>Tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tag_value</para>
                /// </summary>
                [NameInMap("tag_value")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Milvus version</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.10.134-14.an8.x86_64</para>
            /// </summary>
            [NameInMap("kernel_version")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>ECS instance architecture</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86</para>
            /// </summary>
            [NameInMap("os_arch")]
            [Validation(Required=false)]
            public string OsArch { get; set; }

            /// <summary>
            /// <para>Instance health score</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("os_health_score")]
            [Validation(Required=false)]
            public string OsHealthScore { get; set; }

            /// <summary>
            /// <para>The operating system name of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Linux  3.2104 LTS 64bit</para>
            /// </summary>
            [NameInMap("os_name")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>Instance private IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("private_ip")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>Instance Internet IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("public_ip")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <para>Resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxxx</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Resource group name</para>
            /// 
            /// <b>Example:</b>
            /// <para>default resource group</para>
            /// </summary>
            [NameInMap("resource_group_name")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The running status of the instance. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: The instance is running.  </description></item>
            /// <item><description><b>Offline</b>: The instance is offline.</description></item>
            /// </list>
            /// <remarks>
            /// <para>An instance in the Offline state indicates that the heartbeat from the edge zone to the SysOM Server has been lost. This does not mean that the corresponding ECS instance is not running.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Error message. An empty value indicates that the data has been read completely.</para>
        /// 
        /// <b>Example:</b>
        /// <para>result: code=1 msg=(Request failed, status_code != 200)</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>35F91AAB-5FDF-5A22-B211-C7C6B00817D0</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>319</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
