// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListComponentVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComponentVersionsResponseBodyData Data { get; set; }
        public class ListComponentVersionsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListComponentVersionsResponseBodyDataList> List { get; set; }
            public class ListComponentVersionsResponseBodyDataList : TeaModel {
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

                [NameInMap("orchestrationValues")]
                [Validation(Required=false)]
                public string OrchestrationValues { get; set; }

                [NameInMap("packageURL")]
                [Validation(Required=false)]
                public string PackageURL { get; set; }

                [NameInMap("parentComponent")]
                [Validation(Required=false)]
                public bool? ParentComponent { get; set; }

                [NameInMap("readme")]
                [Validation(Required=false)]
                public string Readme { get; set; }

                [NameInMap("resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
