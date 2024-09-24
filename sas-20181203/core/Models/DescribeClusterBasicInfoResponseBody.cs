// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the cluster.</para>
        /// </summary>
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterBasicInfoResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterBasicInfoResponseBodyClusterInfo : TeaModel {
            /// <summary>
            /// <para>The ID of cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c870ec78ecbcb41d2a35c679823ef****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testackpro</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ManagedKubernetes</b>: managed Kubernetes cluster</description></item>
            /// <item><description><b>NotManagedKubernetes</b>: non-managed Kubernetes cluster</description></item>
            /// <item><description><b>PrivateKubernetes</b>: private cluster</description></item>
            /// <item><description><b>kubernetes</b>: dedicated Kubernetes cluster</description></item>
            /// <item><description><b>ask</b>: dedicated ASK cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kubernetes</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The timestamp when the cluster was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1662038134000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.22.10-aliyun.1</para>
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The number of instances in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the cluster is deployed.</para>
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
            /// <item><description><b>unavailable</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>CreateFailed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The cluster is enabled.</description></item>
            /// <item><description><b>false</b>: The cluster is disabled.</description></item>
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
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
