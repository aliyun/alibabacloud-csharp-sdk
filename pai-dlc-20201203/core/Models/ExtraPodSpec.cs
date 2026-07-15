// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ExtraPodSpec : TeaModel {
        /// <summary>
        /// <para>A list of init containers that run to completion before the main container starts.</para>
        /// </summary>
        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> InitContainers { get; set; }

        /// <summary>
        /// <para>Defines lifecycle hooks for the main container.</para>
        /// </summary>
        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public Lifecycle Lifecycle { get; set; }

        /// <summary>
        /// <para>Defines the security context for the main container.</para>
        /// </summary>
        [NameInMap("MainContainerSecurityContext")]
        [Validation(Required=false)]
        public SecurityContext MainContainerSecurityContext { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Key-value pairs to apply to the pod as annotations. Use annotations to attach arbitrary, non-identifying metadata.</para>
        /// </summary>
        [NameInMap("PodAnnotations")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> PodAnnotations { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Key-value pairs to apply to the pod as labels. Use labels to organize and select pods.</para>
        /// </summary>
        [NameInMap("PodLabels")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> PodLabels { get; set; }

        /// <summary>
        /// <para>A list of local directory paths to mount and share among all containers in the pod.</para>
        /// </summary>
        [NameInMap("SharedVolumeMountPaths")]
        [Validation(Required=false)]
        public List<string> SharedVolumeMountPaths { get; set; }

        /// <summary>
        /// <para>A list of sidecar containers.</para>
        /// </summary>
        [NameInMap("SideCarContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> SideCarContainers { get; set; }

    }

}
