// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateK8sResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the self-managed Kubernetes clusters.</para>
        /// </summary>
        [NameInMap("PrivateK8sInfos")]
        [Validation(Required=false)]
        public List<ListPrivateK8sResponseBodyPrivateK8sInfos> PrivateK8sInfos { get; set; }
        public class ListPrivateK8sResponseBodyPrivateK8sInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The IP address of the API server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ApiServerIp")]
            [Validation(Required=false)]
            public string ApiServerIp { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The version of Kubernetes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.18</para>
            /// </summary>
            [NameInMap("K8sVersion")]
            [Validation(Required=false)]
            public string K8sVersion { get; set; }

            /// <summary>
            /// <para>The server configuration of Kubernetes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("KubeConfig")]
            [Validation(Required=false)]
            public string KubeConfig { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Internet.</description></item>
            /// <item><description><b>2</b>: VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public long? NetType { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zet5l358k6z0gnz*****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52870893-48A7-5A9E-9E05-6253E5B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
