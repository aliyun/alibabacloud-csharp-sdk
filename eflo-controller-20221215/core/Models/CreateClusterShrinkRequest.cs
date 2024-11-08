// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateClusterShrinkRequest : TeaModel {
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Lite</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        [NameInMap("Networks")]
        [Validation(Required=false)]
        public string NetworksShrink { get; set; }

        [NameInMap("NimizVSwitches")]
        [Validation(Required=false)]
        public string NimizVSwitchesShrink { get; set; }

        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public string NodeGroupsShrink { get; set; }

        [NameInMap("OpenEniJumboFrame")]
        [Validation(Required=false)]
        public bool? OpenEniJumboFrame { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek2xdkc6icwfha</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterShrinkRequestTag> Tag { get; set; }
        public class CreateClusterShrinkRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>env-name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
