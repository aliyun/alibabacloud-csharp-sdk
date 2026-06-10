// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ContainerdConfig : TeaModel {
        /// <summary>
        /// <para>Whether to ignore volumes defined in the image.</para>
        /// </summary>
        [NameInMap("ignoreImageDefinedVolume")]
        [Validation(Required=false)]
        public bool? IgnoreImageDefinedVolume { get; set; }

        /// <summary>
        /// <para>A list of insecure registries that skip TLS certificate verification.</para>
        /// </summary>
        [NameInMap("insecureRegistries")]
        [Validation(Required=false)]
        public List<string> InsecureRegistries { get; set; }

        /// <summary>
        /// <para>Maximum core dump size in bytes.</para>
        /// </summary>
        [NameInMap("limitCore")]
        [Validation(Required=false)]
        public long? LimitCore { get; set; }

        /// <summary>
        /// <para>Maximum locked memory in bytes.</para>
        /// </summary>
        [NameInMap("limitMemLock")]
        [Validation(Required=false)]
        public long? LimitMemLock { get; set; }

        /// <summary>
        /// <para>Maximum number of open file handles.</para>
        /// </summary>
        [NameInMap("limitNoFile")]
        [Validation(Required=false)]
        public long? LimitNoFile { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent image layer downloads.</para>
        /// </summary>
        [NameInMap("maxConcurrentDownloads")]
        [Validation(Required=false)]
        public long? MaxConcurrentDownloads { get; set; }

        /// <summary>
        /// <para>A list of registry mirrors to accelerate image pulls.</para>
        /// </summary>
        [NameInMap("registryMirrors")]
        [Validation(Required=false)]
        public List<string> RegistryMirrors { get; set; }

    }

}
