// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstallNodePoolComponentsRequest : TeaModel {
        /// <summary>
        /// <para>A list of node components to be installed.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<InstallNodePoolComponentsRequestComponents> Components { get; set; }
        public class InstallNodePoolComponentsRequestComponents : TeaModel {
            /// <summary>
            /// <para>The configuration details for the component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public InstallNodePoolComponentsRequestComponentsConfig Config { get; set; }
            public class InstallNodePoolComponentsRequestComponentsConfig : TeaModel {
                /// <summary>
                /// <para>Custom parameters for the component.</para>
                /// </summary>
                [NameInMap("customConfig")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomConfig { get; set; }

            }

            /// <summary>
            /// <para>The name of the component.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.28.9-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>A list of specific node names where the component should be installed. If not specified, the component will be installed on all nodes in the node pool.</para>
        /// </summary>
        [NameInMap("nodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>Configuration for the rolling update process.</para>
        /// </summary>
        [NameInMap("rollingPolicy")]
        [Validation(Required=false)]
        public InstallNodePoolComponentsRequestRollingPolicy RollingPolicy { get; set; }
        public class InstallNodePoolComponentsRequestRollingPolicy : TeaModel {
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
            /// <para>The maximum number of nodes that can be updated concurrently in each batch. Default: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("maxParallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

            /// <summary>
            /// <para>The strategy for automatic pausing during the update process. Valid values: NotPause, FirstBatchPause, EveryBatchPause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NotPause</para>
            /// </summary>
            [NameInMap("pausePolicy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

    }

}
