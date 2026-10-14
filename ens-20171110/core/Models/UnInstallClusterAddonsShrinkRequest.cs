// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnInstallClusterAddonsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The add-on information.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public string AddonsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>The target cluster must be in the running state. You can call DescribeClustersV1 to query the cluster state.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
