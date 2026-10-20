// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstallNodePoolComponentsRequest : Darabonba.Model {
        /// <summary>
        /// <para>The list of node components.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<InstallNodePoolComponentsRequestComponents> Components { get; set; }
        public class InstallNodePoolComponentsRequestComponents : Darabonba.Model {
            /// <summary>
            /// <para>The configuration of the component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public InstallNodePoolComponentsRequestComponentsConfig Config { get; set; }
            public class InstallNodePoolComponentsRequestComponentsConfig : Darabonba.Model {
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
                /// <para>The environment variables for the node component.</para>
                /// </summary>
                [NameInMap("envs")]
                [Validation(Required=false)]
                public List<InstallNodePoolComponentsRequestComponentsConfigEnvs> Envs { get; set; }
                public class InstallNodePoolComponentsRequestComponentsConfigEnvs : Darabonba.Model {
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
        /// <para>The list of node names specified for the rolling update. Default value: all nodes.</para>
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
        public class InstallNodePoolComponentsRequestRollingPolicy : Darabonba.Model {
            /// <summary>
            /// <para>The upgrade interval between batches, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("batchInterval")]
            [Validation(Required=false)]
            public long? BatchInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes that are allowed to fail during the rolling update. Default value: 0. A value of 0 indicates that the task fails if any node fails. A value greater than 0 indicates that the task fails and stops if the cumulative number of failed nodes exceeds this value.</para>
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

