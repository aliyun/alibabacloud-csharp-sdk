// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteClusterNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the ENS instance where the node resides. Default value: true.</para>
        /// </summary>
        [NameInMap("ReleaseNode")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
