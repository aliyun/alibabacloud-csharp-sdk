// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeRCClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeRCClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-30T02:16:04Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// <para>The cluster status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b></description></item>
            /// <item><description><b>Running</b></description></item>
            /// <item><description><b>Starting</b></description></item>
            /// <item><description><b>Stopping</b></description></item>
            /// <item><description><b>Stopped</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2875D608-A228-53D7-B8C9-35F13EDCF36D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
