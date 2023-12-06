// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductDeploymentsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProductDeploymentsResponseBodyData Data { get; set; }
        public class ListProductDeploymentsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListProductDeploymentsResponseBodyDataList> List { get; set; }
            public class ListProductDeploymentsResponseBodyDataList : TeaModel {
                [NameInMap("envParams")]
                [Validation(Required=false)]
                public string EnvParams { get; set; }

                [NameInMap("envUID")]
                [Validation(Required=false)]
                public string EnvUID { get; set; }

                [NameInMap("oldProductVersion")]
                [Validation(Required=false)]
                public string OldProductVersion { get; set; }

                [NameInMap("packageContentType")]
                [Validation(Required=false)]
                public string PackageContentType { get; set; }

                [NameInMap("packageInfoUID")]
                [Validation(Required=false)]
                public string PackageInfoUID { get; set; }

                [NameInMap("packageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("productVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
