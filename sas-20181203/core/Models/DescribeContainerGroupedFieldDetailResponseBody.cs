// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerGroupedFieldDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContainerGroupedFieldDetailResponseBodyData Data { get; set; }
        public class DescribeContainerGroupedFieldDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-local-dns</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The version of the current online server in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.14.8-aliyun.1</para>
            /// </summary>
            [NameInMap("ClusterCurrentVersion")]
            [Validation(Required=false)]
            public string ClusterCurrentVersion { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8ca91e0907d94efaba7fb0827eb9****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhhtest</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The cluster status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STARTING: Starting.</description></item>
            /// <item><description>START_FAILED: Failed to start.</description></item>
            /// <item><description>BOOTSTRAPPING: Initializing bootstrap actions.</description></item>
            /// <item><description>RUNNING: Running.</description></item>
            /// <item><description>TERMINATING: Terminating.</description></item>
            /// <item><description>TERMINATED: Terminated.</description></item>
            /// <item><description>TERMINATED_WITH_ERRORS: Terminated due to an exception.</description></item>
            /// <item><description>TERMINATE_FAILED: Failed to terminate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Kubernetes</b>: dedicated Kubernetes cluster.</description></item>
            /// <item><description><b>ManagedKubernetes</b>: standard managed cluster (edge cluster).</description></item>
            /// <item><description><b>Ask</b>: standard serverless cluster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The number of containers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContainerCount")]
            [Validation(Required=false)]
            public int? ContainerCount { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1702433618301</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shangliang-test</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The POD name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-local-dns-zwsxl</para>
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// <para>The number of PODs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// <para>The IP address of the POD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
