// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ProductComponentRelationDetail : TeaModel {
        [NameInMap("appVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("class")]
        [Validation(Required=false)]
        public string Class { get; set; }

        [NameInMap("componentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("componentOrchestrationValues")]
        [Validation(Required=false)]
        public string ComponentOrchestrationValues { get; set; }

        [NameInMap("componentUID")]
        [Validation(Required=false)]
        public string ComponentUID { get; set; }

        [NameInMap("componentVersionSpecUID")]
        [Validation(Required=false)]
        public string ComponentVersionSpecUID { get; set; }

        [NameInMap("componentVersionSpecValues")]
        [Validation(Required=false)]
        public string ComponentVersionSpecValues { get; set; }

        [NameInMap("componentVersionUID")]
        [Validation(Required=false)]
        public string ComponentVersionUID { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("documents")]
        [Validation(Required=false)]
        public string Documents { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("imagesMapping")]
        [Validation(Required=false)]
        public string ImagesMapping { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("orchestrationType")]
        [Validation(Required=false)]
        public string OrchestrationType { get; set; }

        [NameInMap("parentComponent")]
        [Validation(Required=false)]
        public bool? ParentComponent { get; set; }

        [NameInMap("parentComponentVersionRelationUID")]
        [Validation(Required=false)]
        public string ParentComponentVersionRelationUID { get; set; }

        [NameInMap("parentComponentVersionUID")]
        [Validation(Required=false)]
        public string ParentComponentVersionUID { get; set; }

        [NameInMap("policy")]
        [Validation(Required=false)]
        public ProductComponentRelationDetailPolicy Policy { get; set; }
        public class ProductComponentRelationDetailPolicy : TeaModel {
            [NameInMap("multiCluster")]
            [Validation(Required=false)]
            public ProductComponentRelationDetailPolicyMultiCluster MultiCluster { get; set; }
            public class ProductComponentRelationDetailPolicyMultiCluster : TeaModel {
                [NameInMap("targetClusters")]
                [Validation(Required=false)]
                public List<string> TargetClusters { get; set; }

            }

        }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

        [NameInMap("readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

        [NameInMap("relationUID")]
        [Validation(Required=false)]
        public string RelationUID { get; set; }

        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        [NameInMap("resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        [NameInMap("sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        [NameInMap("singleton")]
        [Validation(Required=false)]
        public bool? Singleton { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
