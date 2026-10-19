// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyClusterNodePoolShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>Only ECK cluster IDs with the eck- prefix are supported. You can obtain the ID by calling the DescribeClustersV1 operation. Serverless cluster IDs returned by the DescribeCluster operation are not supported. The cluster must be in the running state. After creation, it usually takes 10 to 20 minutes to complete initialization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The Kubernetes configuration.</para>
        /// </summary>
        [NameInMap("KubernetesConfig")]
        [Validation(Required=false)]
        public string KubernetesConfigShrink { get; set; }

        /// <summary>
        /// <para>The node pool information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodepoolInfo")]
        [Validation(Required=false)]
        public string NodepoolInfoShrink { get; set; }

        /// <summary>
        /// <para>The scaling group configuration.</para>
        /// </summary>
        [NameInMap("ScalingGroup")]
        [Validation(Required=false)]
        public string ScalingGroupShrink { get; set; }

    }

}
