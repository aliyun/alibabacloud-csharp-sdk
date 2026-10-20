// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListNodePoolComponentInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node component instances.</para>
        /// </summary>
        [NameInMap("component_instances")]
        [Validation(Required=false)]
        public List<ListNodePoolComponentInstancesResponseBodyComponentInstances> ComponentInstances { get; set; }
        public class ListNodePoolComponentInstancesResponseBodyComponentInstances : TeaModel {
            /// <summary>
            /// <para>The configuration of the component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ListNodePoolComponentInstancesResponseBodyComponentInstancesConfig Config { get; set; }
            public class ListNodePoolComponentInstancesResponseBodyComponentInstancesConfig : TeaModel {
                /// <summary>
                /// <para>The custom configuration of the component.</para>
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
                public List<ListNodePoolComponentInstancesResponseBodyComponentInstancesConfigEnvs> Envs { get; set; }
                public class ListNodePoolComponentInstancesResponseBodyComponentInstancesConfigEnvs : TeaModel {
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
            /// <para>The version number of the component configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("config_revision")]
            [Validation(Required=false)]
            public string ConfigRevision { get; set; }

            /// <summary>
            /// <para>The name of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The state of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The version of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.33.3-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to return. Default value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
