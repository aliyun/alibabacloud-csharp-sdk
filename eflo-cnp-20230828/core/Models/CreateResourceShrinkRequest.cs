// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CreateResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Cluster Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppu集群</para>
        /// </summary>
        [NameInMap("ClusterDesc")]
        [Validation(Required=false)]
        public string ClusterDesc { get; set; }

        /// <summary>
        /// <para>Cluster ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-sh-fj71c0ycfw</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Cluster Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tre-1-ppu</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>Machine Types</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypesShrink { get; set; }

        /// <summary>
        /// <para>User Access Parameters</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserAccessParam")]
        [Validation(Required=false)]
        public string UserAccessParamShrink { get; set; }

    }

}
