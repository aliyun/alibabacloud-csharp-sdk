// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstallNodePoolComponentsRequest : TeaModel {
        /// <summary>
        /// <para>The list of node components.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<InstallNodePoolComponentsRequestComponents> Components { get; set; }
        public class InstallNodePoolComponentsRequestComponents : TeaModel {
            /// <summary>
            /// <para>The component configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public InstallNodePoolComponentsRequestComponentsConfig Config { get; set; }
            public class InstallNodePoolComponentsRequestComponentsConfig : TeaModel {
                /// <summary>
                /// <para>The custom configuration of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
                /// </summary>
                [NameInMap("customConfig")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomConfig { get; set; }

            }

            /// <summary>
            /// <para>The component name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The component version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.28.9-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The list of node names for the rolling update. By default, all nodes are included.</para>
        /// </summary>
        [NameInMap("nodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>The rolling update configuration.</para>
        /// </summary>
        [NameInMap("rollingPolicy")]
        [Validation(Required=false)]
        public InstallNodePoolComponentsRequestRollingPolicy RollingPolicy { get; set; }
        public class InstallNodePoolComponentsRequestRollingPolicy : TeaModel {
            /// <summary>
            /// <para>The interval between batches during the upgrade. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("batchInterval")]
            [Validation(Required=false)]
            public long? BatchInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes that can be processed in parallel per batch. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("maxParallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

            /// <summary>
            /// <para>The automatic pause policy during the node upgrade process.</para>
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
