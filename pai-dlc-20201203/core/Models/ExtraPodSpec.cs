// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ExtraPodSpec : TeaModel {
        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> InitContainers { get; set; }

        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public Lifecycle Lifecycle { get; set; }

        [NameInMap("PodAnnotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> PodAnnotations { get; set; }

        [NameInMap("PodLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> PodLabels { get; set; }

        [NameInMap("SharedVolumeMountPaths")]
        [Validation(Required=false)]
        public List<string> SharedVolumeMountPaths { get; set; }

        [NameInMap("SideCarContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> SideCarContainers { get; set; }

    }

}
