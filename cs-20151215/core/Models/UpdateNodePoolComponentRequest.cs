// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateNodePoolComponentRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the node component.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentRequestConfig Config { get; set; }
        public class UpdateNodePoolComponentRequestConfig : TeaModel {
            /// <summary>
            /// <para>The custom configuration of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
            /// </summary>
            [NameInMap("customConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomConfig { get; set; }

            /// <summary>
            /// <para>The environment variables of the node component.</para>
            /// </summary>
            [NameInMap("envs")]
            [Validation(Required=false)]
            public List<UpdateNodePoolComponentRequestConfigEnvs> Envs { get; set; }
            public class UpdateNodePoolComponentRequestConfigEnvs : TeaModel {
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
        /// <para>Specifies whether to disable log rotation. Default value: false. Updating the baseline configuration triggers log rotation on nodes.</para>
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
        /// <para>The list of nodes for log rotation. By default, all nodes are included.</para>
        /// </summary>
        [NameInMap("nodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>The log rotation configuration.</para>
        /// </summary>
        [NameInMap("rollingPolicy")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentRequestRollingPolicy RollingPolicy { get; set; }
        public class UpdateNodePoolComponentRequestRollingPolicy : TeaModel {
            /// <summary>
            /// <para>The upgrade interval between batches. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("batchInterval")]
            [Validation(Required=false)]
            public long? BatchInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes that can fail during the rolling update. Default value: 0, which means the task fails if any node fails. If the value is greater than 0, the task fails and stops when the cumulative number of failed nodes exceeds this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("maxFailedNodes")]
            [Validation(Required=false)]
            public long? MaxFailedNodes { get; set; }

            /// <summary>
            /// <para>The maximum number of parallel operations per batch. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("maxParallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

            /// <summary>
            /// <para>The automatic pause policy during node upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NotPause</para>
            /// </summary>
            [NameInMap("pausePolicy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

        /// <summary>
        /// <para>The version of the node component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.28.9-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
