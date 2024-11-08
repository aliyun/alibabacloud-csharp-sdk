// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ExtendClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i15b480fbd2fcdbc2869cd80</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        [NameInMap("IpAllocationPolicy")]
        [Validation(Required=false)]
        public string IpAllocationPolicyShrink { get; set; }

        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public string NodeGroupsShrink { get; set; }

        [NameInMap("VSwitchZoneId")]
        [Validation(Required=false)]
        public string VSwitchZoneId { get; set; }

        [NameInMap("VpdSubnets")]
        [Validation(Required=false)]
        public string VpdSubnetsShrink { get; set; }

    }

}
