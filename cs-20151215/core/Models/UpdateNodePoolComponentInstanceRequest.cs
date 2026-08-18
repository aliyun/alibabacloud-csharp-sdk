// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateNodePoolComponentInstanceRequest : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentInstanceRequestConfig Config { get; set; }
        public class UpdateNodePoolComponentInstanceRequestConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
            /// </summary>
            [NameInMap("custom_config")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomConfig { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_rolling")]
        [Validation(Required=false)]
        public bool? DisableRolling { get; set; }

        [NameInMap("node_names")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentInstanceRequestRollingPolicy RollingPolicy { get; set; }
        public class UpdateNodePoolComponentInstanceRequestRollingPolicy : TeaModel {
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
            /// <para>NotPause</para>
            /// </summary>
            [NameInMap("pause_policy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.33.3-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
