// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateNodePoolComponentRequest : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentRequestConfig Config { get; set; }
        public class UpdateNodePoolComponentRequestConfig : TeaModel {
            [NameInMap("customConfig")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomConfig { get; set; }

        }

        [NameInMap("disableRolling")]
        [Validation(Required=false)]
        public bool? DisableRolling { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kubelet</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        [NameInMap("rollingPolicy")]
        [Validation(Required=false)]
        public UpdateNodePoolComponentRequestRollingPolicy RollingPolicy { get; set; }
        public class UpdateNodePoolComponentRequestRollingPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("batchInterval")]
            [Validation(Required=false)]
            public long? BatchInterval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("maxParallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NotPause</para>
            /// </summary>
            [NameInMap("pausePolicy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.28.9-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
