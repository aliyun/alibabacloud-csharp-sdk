// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductEnvironmentsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListProductEnvironmentsResponseBodyData> Data { get; set; }
        public class ListProductEnvironmentsResponseBodyData : TeaModel {
            [NameInMap("envName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }

            [NameInMap("envType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("envUID")]
            [Validation(Required=false)]
            public string EnvUID { get; set; }

            [NameInMap("instanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("oldProductVersion")]
            [Validation(Required=false)]
            public string OldProductVersion { get; set; }

            [NameInMap("oldProductVersionUID")]
            [Validation(Required=false)]
            public string OldProductVersionUID { get; set; }

            [NameInMap("platformStatus")]
            [Validation(Required=false)]
            public string PlatformStatus { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("productUID")]
            [Validation(Required=false)]
            public string ProductUID { get; set; }

            [NameInMap("productVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            [NameInMap("productVersionUID")]
            [Validation(Required=false)]
            public string ProductVersionUID { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("vendorConfig")]
            [Validation(Required=false)]
            public string VendorConfig { get; set; }

            [NameInMap("vendorType")]
            [Validation(Required=false)]
            public string VendorType { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
