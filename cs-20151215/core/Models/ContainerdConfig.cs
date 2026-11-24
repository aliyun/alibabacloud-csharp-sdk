// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ContainerdConfig : TeaModel {
        /// <summary>
        /// <para>The configuration to ignore volumes defined in the image.</para>
        /// </summary>
        [NameInMap("ignoreImageDefinedVolume")]
        [Validation(Required=false)]
        public bool? IgnoreImageDefinedVolume { get; set; }

        /// <summary>
        /// <para>The registries that skip certificate verification.</para>
        /// </summary>
        [NameInMap("insecureRegistries")]
        [Validation(Required=false)]
        public List<string> InsecureRegistries { get; set; }

        /// <summary>
        /// <para>The core dump size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limitCore")]
        [Validation(Required=false)]
        public long? LimitCore { get; set; }

        /// <summary>
        /// <para>The maximum memory lock limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65536</para>
        /// </summary>
        [NameInMap("limitMemLock")]
        [Validation(Required=false)]
        public long? LimitMemLock { get; set; }

        /// <summary>
        /// <para>The maximum number of file handles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("limitNoFile")]
        [Validation(Required=false)]
        public long? LimitNoFile { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent downloads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxConcurrentDownloads")]
        [Validation(Required=false)]
        public long? MaxConcurrentDownloads { get; set; }

        /// <summary>
        /// <para>The registry mirror configuration.</para>
        /// </summary>
        [NameInMap("registryMirrors")]
        [Validation(Required=false)]
        public List<string> RegistryMirrors { get; set; }

    }

}
