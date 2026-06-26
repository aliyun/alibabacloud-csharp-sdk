// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class JuiceFsConfig : TeaModel {
        /// <summary>
        /// <para>A map of environment variables (key-value pairs) to set for the JuiceFS client.</para>
        /// </summary>
        [NameInMap("envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>An array of JuiceFsMountConfig objects, each specifying the configuration for a mount point.</para>
        /// </summary>
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<JuiceFsMountConfig> MountPoints { get; set; }

    }

}
