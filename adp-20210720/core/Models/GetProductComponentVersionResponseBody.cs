// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetProductComponentVersionResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetProductComponentVersionResponseBodyData> Data { get; set; }
        public class GetProductComponentVersionResponseBodyData : TeaModel {
            [NameInMap("appVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("componentDescription")]
            [Validation(Required=false)]
            public string ComponentDescription { get; set; }

            [NameInMap("componentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("componentUID")]
            [Validation(Required=false)]
            public string ComponentUID { get; set; }

            [NameInMap("componentVersionDescription")]
            [Validation(Required=false)]
            public string ComponentVersionDescription { get; set; }

            [NameInMap("componentVersionUID")]
            [Validation(Required=false)]
            public string ComponentVersionUID { get; set; }

            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("orchestrationValues")]
            [Validation(Required=false)]
            public string OrchestrationValues { get; set; }

            [NameInMap("parentComponent")]
            [Validation(Required=false)]
            public bool? ParentComponent { get; set; }

            [NameInMap("parentComponentVersionRelationUID")]
            [Validation(Required=false)]
            public string ParentComponentVersionRelationUID { get; set; }

            [NameInMap("parentComponentVersionUID")]
            [Validation(Required=false)]
            public string ParentComponentVersionUID { get; set; }

            [NameInMap("productVersionUID")]
            [Validation(Required=false)]
            public string ProductVersionUID { get; set; }

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

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public string Values { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
