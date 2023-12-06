// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListComponentsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComponentsResponseBodyData Data { get; set; }
        public class ListComponentsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyDataList> List { get; set; }
            public class ListComponentsResponseBodyDataList : TeaModel {
                [NameInMap("annotations")]
                [Validation(Required=false)]
                public ListComponentsResponseBodyDataListAnnotations Annotations { get; set; }
                public class ListComponentsResponseBodyDataListAnnotations : TeaModel {
                    [NameInMap("annotations")]
                    [Validation(Required=false)]
                    public string Annotations { get; set; }

                }

                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("documents")]
                [Validation(Required=false)]
                public string Documents { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                [NameInMap("public")]
                [Validation(Required=false)]
                public bool? Public { get; set; }

                [NameInMap("singleton")]
                [Validation(Required=false)]
                public bool? Singleton { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

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
