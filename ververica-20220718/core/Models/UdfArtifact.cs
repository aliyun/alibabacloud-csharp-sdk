// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UdfArtifact : TeaModel {
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("dependencyJarUris")]
        [Validation(Required=false)]
        public List<string> DependencyJarUris { get; set; }

        [NameInMap("jarUrl")]
        [Validation(Required=false)]
        public string JarUrl { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("udfClasses")]
        [Validation(Required=false)]
        public List<UdfClass> UdfClasses { get; set; }

    }

}
