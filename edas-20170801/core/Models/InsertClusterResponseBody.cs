// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cluster that was created.</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public InsertClusterResponseBodyCluster Cluster { get; set; }
        public class InsertClusterResponseBodyCluster : TeaModel {
            /// <summary>
            /// <para>The ID of cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8705ad13-5d86-47fc-b68f-257b59ed****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>****_product_test2</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: ECS cluster</description></item>
            /// <item><description>3: self-managed Kubernetes cluster in EDAS</description></item>
            /// <item><description>5: Kubernetes cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            /// <summary>
            /// <para>The provider of the IaaS resources that are used in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("IaasProvider")]
            [Validation(Required=false)]
            public string IaasProvider { get; set; }

            /// <summary>
            /// <para>The network type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: classic network</description></item>
            /// <item><description>2\. VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public int? NetworkMode { get; set; }

            /// <summary>
            /// <para><b>This parameter is deprecated.</b> The CPU overcommit ratio supported by the Docker cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: 1:2, which means that resources are overcommitted by 1:2.</description></item>
            /// <item><description>4: 1:4, which means that resources are overcommitted by 1:4.</description></item>
            /// <item><description>8: 1:8, which means that resources are overcommitted by 1:8.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the cluster resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zef6ob8mrlzv8x3q****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
