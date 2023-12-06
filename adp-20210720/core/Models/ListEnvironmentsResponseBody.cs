// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListEnvironmentsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListEnvironmentsResponseBodyData Data { get; set; }
        public class ListEnvironmentsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListEnvironmentsResponseBodyDataList> List { get; set; }
            public class ListEnvironmentsResponseBodyDataList : TeaModel {
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("expireAt")]
                [Validation(Required=false)]
                public string ExpireAt { get; set; }

                [NameInMap("instanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("platform")]
                [Validation(Required=false)]
                public ListEnvironmentsResponseBodyDataListPlatform Platform { get; set; }
                public class ListEnvironmentsResponseBodyDataListPlatform : TeaModel {
                    [NameInMap("architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    [NameInMap("os")]
                    [Validation(Required=false)]
                    public string Os { get; set; }

                }

                [NameInMap("platformList")]
                [Validation(Required=false)]
                public List<Platform> PlatformList { get; set; }

                [NameInMap("platformStatus")]
                [Validation(Required=false)]
                public string PlatformStatus { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("productVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("productVersionUID")]
                [Validation(Required=false)]
                public string ProductVersionUID { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("vendorType")]
                [Validation(Required=false)]
                public string VendorType { get; set; }

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
