// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ExtraPodSpec : TeaModel {
        /// <summary>
        /// <para>The containers to be initialized.</para>
        /// </summary>
        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> InitContainers { get; set; }

        /// <summary>
        /// <para>The lifecycle object.</para>
        /// </summary>
        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public Lifecycle Lifecycle { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The pod annotations.</para>
        /// </summary>
        [NameInMap("PodAnnotations")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> PodAnnotations { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The pod labels.</para>
        /// </summary>
        [NameInMap("PodLabels")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> PodLabels { get; set; }

        /// <summary>
        /// <para>The local paths shared between containers.</para>
        /// </summary>
        [NameInMap("SharedVolumeMountPaths")]
        [Validation(Required=false)]
        public List<string> SharedVolumeMountPaths { get; set; }

        /// <summary>
        /// <para>The sidecar containers.</para>
        /// </summary>
        [NameInMap("SideCarContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> SideCarContainers { get; set; }

    }

}
