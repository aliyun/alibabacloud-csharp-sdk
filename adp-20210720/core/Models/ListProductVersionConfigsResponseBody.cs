// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductVersionConfigsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProductVersionConfigsResponseBodyData Data { get; set; }
        public class ListProductVersionConfigsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListProductVersionConfigsResponseBodyDataList> List { get; set; }
            public class ListProductVersionConfigsResponseBodyDataList : TeaModel {
                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("componentReleaseName")]
                [Validation(Required=false)]
                public string ComponentReleaseName { get; set; }

                [NameInMap("componentVersionUID")]
                [Validation(Required=false)]
                public string ComponentVersionUID { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("parentComponentName")]
                [Validation(Required=false)]
                public string ParentComponentName { get; set; }

                [NameInMap("parentComponentReleaseName")]
                [Validation(Required=false)]
                public string ParentComponentReleaseName { get; set; }

                [NameInMap("parentComponentVersionUID")]
                [Validation(Required=false)]
                public string ParentComponentVersionUID { get; set; }

                [NameInMap("productVersionUID")]
                [Validation(Required=false)]
                public string ProductVersionUID { get; set; }

                [NameInMap("scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("valueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

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
