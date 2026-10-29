// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateNodePoolComponentInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The node component configuration.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentInstanceRequestConfig Config { get; set; }
        public class UpdateNodePoolComponentInstanceRequestConfig : TeaModel {
            /// <summary>
            /// <para>The custom configuration of the node component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
            /// </summary>
            [NameInMap("custom_config")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomConfig { get; set; }

            /// <summary>
            /// <para>The environment variables of the node component.</para>
            /// </summary>
            [NameInMap("envs")]
            [Validation(Required=false)]
            public List<UpdateNodePoolComponentInstanceRequestConfigEnvs> Envs { get; set; }
            public class UpdateNodePoolComponentInstanceRequestConfigEnvs : TeaModel {
                /// <summary>
                /// <para>The name of the environment variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LOG_LEVEL</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the environment variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies whether to disable rolling updates. Default value: false. Updating the baseline configuration triggers a rolling update of the nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_rolling")]
        [Validation(Required=false)]
        public bool? DisableRolling { get; set; }

        /// <summary>
        /// <para>The list of nodes to be updated in a rolling manner. Default value: all nodes.</para>
        /// </summary>
        [NameInMap("node_names")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>The rolling update configuration.</para>
        /// </summary>
        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentInstanceRequestRollingPolicy RollingPolicy { get; set; }
        public class UpdateNodePoolComponentInstanceRequestRollingPolicy : TeaModel {
            /// <summary>
            /// <para>The upgrade interval between batches, in seconds. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("batch_interval")]
            [Validation(Required=false)]
            public long? BatchInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes allowed to fail during the rolling update. Default value: 0. A value of 0 indicates that the task fails if any node fails. A value greater than 0 indicates that the task fails and stops if the cumulative number of failed nodes exceeds this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("max_failed_nodes")]
            [Validation(Required=false)]
            public long? MaxFailedNodes { get; set; }

            /// <summary>
            /// <para>The maximum number of parallel nodes per batch. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

            /// <summary>
            /// <para>The automatic pause policy during node upgrades. Valid values: NotPause, FirstBatch, and EveryBatch. Default value: NotPause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NotPause</para>
            /// </summary>
            [NameInMap("pause_policy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

        /// <summary>
        /// <para>The node component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.33.3-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
