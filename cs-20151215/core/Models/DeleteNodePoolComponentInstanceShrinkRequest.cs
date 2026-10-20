// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteNodePoolComponentInstanceShrinkRequest : Darabonba.Model {
        /// <summary>
        /// <para>The interval between batches, in seconds. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("batch_interval")]
        [Validation(Required=false)]
        public long? BatchInterval { get; set; }

        /// <summary>
        /// <para>The maximum number of nodes that can fail during the rolling process. Default value: 0. A value of 0 indicates that the task fails if any node fails. A value greater than 0 indicates that the task fails and stops if the cumulative number of failed nodes exceeds this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("max_failed_nodes")]
        [Validation(Required=false)]
        public long? MaxFailedNodes { get; set; }

        /// <summary>
        /// <para>The maximum number of parallel operations per batch. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("max_parallelism")]
        [Validation(Required=false)]
        public long? MaxParallelism { get; set; }

        /// <summary>
        /// <para>The list of nodes to rotate. Default value: all nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou.10.91.xx.xx&quot;]</para>
        /// </summary>
        [NameInMap("node_names")]
        [Validation(Required=false)]
        public string NodeNamesShrink { get; set; }

        /// <summary>
        /// <para>The auto-pause policy during a node upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NotPause</description></item>
        /// <item><description>FirstBatch</description></item>
        /// <item><description>EveryBatch</description></item>
        /// </list>
        /// <para>Default value: NotPause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotPause</para>
        /// </summary>
        [NameInMap("pause_policy")]
        [Validation(Required=false)]
        public string PausePolicy { get; set; }

    }

}

