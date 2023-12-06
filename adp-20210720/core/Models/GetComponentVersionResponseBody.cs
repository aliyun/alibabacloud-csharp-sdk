// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetComponentVersionResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetComponentVersionResponseBodyData> Data { get; set; }
        public class GetComponentVersionResponseBodyData : TeaModel {
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

            [NameInMap("orchestrationValues")]
            [Validation(Required=false)]
            public string OrchestrationValues { get; set; }

            [NameInMap("packageURL")]
            [Validation(Required=false)]
            public string PackageURL { get; set; }

            [NameInMap("parentComponent")]
            [Validation(Required=false)]
            public bool? ParentComponent { get; set; }

            [NameInMap("productComponentVersionUID")]
            [Validation(Required=false)]
            public string ProductComponentVersionUID { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }

            [NameInMap("resources")]
            [Validation(Required=false)]
            public GetComponentVersionResponseBodyDataResources Resources { get; set; }
            public class GetComponentVersionResponseBodyDataResources : TeaModel {
                [NameInMap("limits")]
                [Validation(Required=false)]
                public Dictionary<string, object> Limits { get; set; }

                [NameInMap("requests")]
                [Validation(Required=false)]
                public Dictionary<string, object> Requests { get; set; }

            }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
