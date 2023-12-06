/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ComponentVersion : TeaModel {
        [NameInMap("appVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("componentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("componentUID")]
        [Validation(Required=false)]
        public string ComponentUID { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("documents")]
        [Validation(Required=false)]
        public string Documents { get; set; }

        [NameInMap("imagesMapping")]
        [Validation(Required=false)]
        public string ImagesMapping { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("orchestrationType")]
        [Validation(Required=false)]
        public string OrchestrationType { get; set; }

        [NameInMap("orchestrationValues")]
        [Validation(Required=false)]
        public string OrchestrationValues { get; set; }

        [NameInMap("packageURL")]
        [Validation(Required=false)]
        public string PackageURL { get; set; }

        [NameInMap("parentComponent")]
        [Validation(Required=false)]
        public bool? ParentComponent { get; set; }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public List<Platform> Platforms { get; set; }

        [NameInMap("readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

        [NameInMap("resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
