// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ReimageNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i15dfa12e8f27c44f4a006c2c8bb</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Whether to allow skipping failed node tasks, default value is False</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>Node list</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string NodesShrink { get; set; }

        /// <summary>
        /// <para>Custom data</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/sh
        /// echo &quot;Hello World. The time is now $(date -R)!&quot; | tee /root/userdata_test.txt</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
