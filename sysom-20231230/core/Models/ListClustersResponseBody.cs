// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>B149FD9C-ED5C-5765-B3AD-05AA4A4D64D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization succeeded.  </description></item>
        /// <item><description>Any other status code indicates authorization failed. When authorization fails, check the <c>message</c> field for detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyData> Data { get; set; }
        public class ListClustersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Actual cluster ID.  </para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>For <c>ACK</c> type clusters, this ID is the ACK cluster ID.  </description></item>
            /// <item><description>For <c>CUSTOM</c> type clusters, this ID serves as a UUID and has no additional meaning.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>c666d4774f0e2440b979bf917bf100e40</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><c>Running</c>: Cluster management is normal.  </description></item>
            /// <item><description><c>Installing</c>: An install job is in progress for the cluster.  </description></item>
            /// <item><description><c>Uninstalling</c>: An uninstall job is in progress for the cluster.  </description></item>
            /// <item><description><c>Upgrading</c>: An update job is in progress for the cluster.  </description></item>
            /// <item><description><c>Offline</c>: The cluster is offline and cluster management is abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("cluster_status")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><c>ACK</c>: ACK cluster  </description></item>
            /// <item><description><c>CUSTOM</c>: Custom cluster (default clusters are classified as custom clusters)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACK</para>
            /// </summary>
            [NameInMap("cluster_type")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-25T15:08:19</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Cluster ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>5389fba5-92a1-4ff4-9b26-773b97828144</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Cluster Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto-name-sbvCT</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Update Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-25T15:08:19</para>
            /// </summary>
            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
