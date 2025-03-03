// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class StopNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Whether to allow skipping failed node tasks, default value is False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>List of nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string NodesShrink { get; set; }

    }

}
