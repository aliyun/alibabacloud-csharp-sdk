// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteNodePoolComponentInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("batch_interval")]
        [Validation(Required=false)]
        public long? BatchInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("max_failed_nodes")]
        [Validation(Required=false)]
        public long? MaxFailedNodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("max_parallelism")]
        [Validation(Required=false)]
        public long? MaxParallelism { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou.10.91.xx.xx&quot;]</para>
        /// </summary>
        [NameInMap("node_names")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NotPause</para>
        /// </summary>
        [NameInMap("pause_policy")]
        [Validation(Required=false)]
        public string PausePolicy { get; set; }

    }

}
