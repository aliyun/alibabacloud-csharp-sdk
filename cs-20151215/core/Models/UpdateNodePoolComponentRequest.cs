// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateNodePoolComponentRequest : TeaModel {
        /// <summary>
        /// <para>The configuration details for the component update.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentRequestConfig Config { get; set; }
        public class UpdateNodePoolComponentRequestConfig : TeaModel {
            /// <summary>
            /// <para>Custom configuration parameters for the component.</para>
            /// </summary>
            [NameInMap("customConfig")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomConfig { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to disable rolling updates. Default: false. If set to false, nodes will be rolled automatically to apply the new configuration.</para>
        /// </summary>
        [NameInMap("disableRolling")]
        [Validation(Required=false)]
        public bool? DisableRolling { get; set; }

        /// <summary>
        /// <para>The name of the node component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubelet</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A list of specific nodes to be rolled. If not specified, all nodes in the node pool will be updated.</para>
        /// </summary>
        [NameInMap("nodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>The rolling update configuration.</para>
        /// </summary>
        [NameInMap("rollingPolicy")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentRequestRollingPolicy RollingPolicy { get; set; }
        public class UpdateNodePoolComponentRequestRollingPolicy : TeaModel {
            /// <summary>
            /// <para>The time interval between update batches, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("batchInterval")]
            [Validation(Required=false)]
            public long? BatchInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes that can be updated concurrently. Default: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("maxParallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

            /// <summary>
            /// <para>The automatic pause strategy during the update process. Valid values: NotPause, FirstBatchPause, EveryBatchPause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NotPause</para>
            /// </summary>
            [NameInMap("pausePolicy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

        /// <summary>
        /// <para>The version of the node component to be updated to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.28.9-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
