// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded.  </description></item>
        /// <item><description>Any other status code indicates that authorization failed. When authorization fails, check the <c>message</c> field for detailed error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyData> Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Cluster ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>c2218ca2b76ec45e7b7ee1693f6fcd374</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>ECS instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9d00ut2ska3mlyhn6j</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>Milvus version of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.10.134-16.1.an8.x86_64</para>
            /// </summary>
            [NameInMap("kernel_version")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>Metadata of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;uname&quot;: &quot;Linux&quot;,
            ///     &quot;oncpu&quot;: &quot;off&quot;,
            ///     &quot;release&quot;: &quot;5.10.134-16.3.al8.aarch64&quot;,
            ///     &quot;monitor&quot;: &quot;on&quot;,
            ///     &quot;version_id&quot;: &quot;3&quot;,
            ///     &quot;version&quot;: &quot;3 (Soaring Falcon)&quot;,
            ///     &quot;podNs&quot;: [</para>
            /// <pre><c>],
            /// &quot;machine&quot;: &quot;aarch64&quot;,
            /// &quot;name&quot;: &quot;Alibaba Cloud Linux&quot;,
            /// &quot;sysak&quot;: &quot;3.4.0-1&quot;,
            /// &quot;id&quot;: &quot;alinux&quot;,
            /// &quot;region&quot;: &quot;cn-hangzhou&quot;,
            /// &quot;centos-release&quot;: &quot;Alibaba Cloud Linux release 3 (Soaring Falcon)&quot;
            /// </c></pre>
            /// <para>}</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public object Meta { get; set; }

            /// <summary>
            /// <para>Architecture of the ECS instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86</para>
            /// </summary>
            [NameInMap("os_arch")]
            [Validation(Required=false)]
            public string OsArch { get; set; }

            /// <summary>
            /// <para>Health score of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("os_health_score")]
            [Validation(Required=false)]
            public string OsHealthScore { get; set; }

            /// <summary>
            /// <para>Operating system name of the instance (retrieved from /etc/os-release)</para>
            /// 
            /// <b>Example:</b>
            /// <para>Anolis OS</para>
            /// </summary>
            [NameInMap("os_name")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>Operating system name ID of the instance (retrieved from /etc/os-release)</para>
            /// 
            /// <b>Example:</b>
            /// <para>anolis</para>
            /// </summary>
            [NameInMap("os_name_id")]
            [Validation(Required=false)]
            public string OsNameId { get; set; }

            /// <summary>
            /// <para>Operating system version of the instance (obtained from /etc/os-release)</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.9</para>
            /// </summary>
            [NameInMap("os_version")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// <para>Operating system version ID of the instance (retrieved from /etc/os-release)</para>
            /// 
            /// <b>Example:</b>
            /// <para>rhel fedora centos</para>
            /// </summary>
            [NameInMap("os_version_id")]
            [Validation(Required=false)]
            public string OsVersionId { get; set; }

            /// <summary>
            /// <para>Region where the instance is located</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Status of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Requests for llm service failed</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>9515E5A0-8905-59B0-9BBF-5F0BE568C3A0</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>623</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
