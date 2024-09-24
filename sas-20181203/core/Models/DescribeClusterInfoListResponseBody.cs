// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterInfoListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about clusters.</para>
        /// </summary>
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public List<DescribeClusterInfoListResponseBodyClusterList> ClusterList { get; set; }
        public class DescribeClusterInfoListResponseBodyClusterList : TeaModel {
            /// <summary>
            /// <para>The ID of the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cfeb7a9f99ce740e98c5595d0fe37****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test111</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ManagedKubernetes</b>: managed Kubernetes cluster.</description></item>
            /// <item><description><b>NotManagedKubernetes</b>: non-managed Kubernetes cluster.</description></item>
            /// <item><description><b>PrivateKubernetes</b>: private cluster.</description></item>
            /// <item><description><b>kubernetes</b>: dedicated Kubernetes cluster.</description></item>
            /// <item><description><b>ask</b>: dedicated serverless Kubernetes (ASK) cluster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The region in which the cluster resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>unavailable</b>: The cluster is unavailable.</description></item>
            /// <item><description><b>Available</b>: The cluster is available.</description></item>
            /// <item><description><b>Creating</b>: The cluster is being created.</description></item>
            /// <item><description><b>CreateFailed</b>: The cluster failed to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Indicates whether container network topology was enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TargetResult")]
            [Validation(Required=false)]
            public bool? TargetResult { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
