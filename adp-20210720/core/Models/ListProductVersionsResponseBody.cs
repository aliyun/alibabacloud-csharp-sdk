// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductVersionsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProductVersionsResponseBodyData Data { get; set; }
        public class ListProductVersionsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListProductVersionsResponseBodyDataList> List { get; set; }
            public class ListProductVersionsResponseBodyDataList : TeaModel {
                [NameInMap("annotations")]
                [Validation(Required=false)]
                public ListProductVersionsResponseBodyDataListAnnotations Annotations { get; set; }
                public class ListProductVersionsResponseBodyDataListAnnotations : TeaModel {
                    [NameInMap("additionalProp1")]
                    [Validation(Required=false)]
                    public string AdditionalProp1 { get; set; }

                    [NameInMap("additionalProp2")]
                    [Validation(Required=false)]
                    public string AdditionalProp2 { get; set; }

                    [NameInMap("additionalProp3")]
                    [Validation(Required=false)]
                    public string AdditionalProp3 { get; set; }

                }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("packageURL")]
                [Validation(Required=false)]
                public string PackageURL { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("productUID")]
                [Validation(Required=false)]
                public string ProductUID { get; set; }

                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                [NameInMap("releasedAt")]
                [Validation(Required=false)]
                public string ReleasedAt { get; set; }

                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<ListProductVersionsResponseBodyDataListTags> Tags { get; set; }
                public class ListProductVersionsResponseBodyDataListTags : TeaModel {
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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
