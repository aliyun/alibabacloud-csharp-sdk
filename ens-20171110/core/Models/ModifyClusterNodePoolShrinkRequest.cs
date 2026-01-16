// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyClusterNodePoolShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("KubernetesConfig")]
        [Validation(Required=false)]
        public string KubernetesConfigShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodepoolInfo")]
        [Validation(Required=false)]
        public string NodepoolInfoShrink { get; set; }

        [NameInMap("ScalingGroup")]
        [Validation(Required=false)]
        public string ScalingGroupShrink { get; set; }

    }

}
