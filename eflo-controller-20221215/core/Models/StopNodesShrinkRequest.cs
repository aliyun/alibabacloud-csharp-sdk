// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class StopNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow skipping failed nodes. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>The nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string NodesShrink { get; set; }

    }

}
