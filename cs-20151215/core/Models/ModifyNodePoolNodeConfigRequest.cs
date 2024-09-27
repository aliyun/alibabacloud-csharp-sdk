// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyNodePoolNodeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The parameter settings of the kubelet.</para>
        /// </summary>
        [NameInMap("kubelet_config")]
        [Validation(Required=false)]
        public KubeletConfig KubeletConfig { get; set; }

        [NameInMap("os_config")]
        [Validation(Required=false)]
        public ModifyNodePoolNodeConfigRequestOsConfig OsConfig { get; set; }
        public class ModifyNodePoolNodeConfigRequestOsConfig : TeaModel {
            [NameInMap("sysctl")]
            [Validation(Required=false)]
            public Dictionary<string, object> Sysctl { get; set; }

        }

        /// <summary>
        /// <para>The rotation configurations.</para>
        /// </summary>
        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public ModifyNodePoolNodeConfigRequestRollingPolicy RollingPolicy { get; set; }
        public class ModifyNodePoolNodeConfigRequestRollingPolicy : TeaModel {
            /// <summary>
            /// <para>The maximum number of unavailable nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

        }

    }

}
