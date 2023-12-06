// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetProductVersionPackageResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProductVersionPackageResponseBodyData Data { get; set; }
        public class GetProductVersionPackageResponseBodyData : TeaModel {
            [NameInMap("packageContentType")]
            [Validation(Required=false)]
            public string PackageContentType { get; set; }

            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public string PackageSize { get; set; }

            [NameInMap("packageStatus")]
            [Validation(Required=false)]
            public string PackageStatus { get; set; }

            [NameInMap("packageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            [NameInMap("packageUID")]
            [Validation(Required=false)]
            public string PackageUID { get; set; }

            [NameInMap("packageURL")]
            [Validation(Required=false)]
            public string PackageURL { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public Platform Platform { get; set; }

            [NameInMap("platformList")]
            [Validation(Required=false)]
            public List<Platform> PlatformList { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
