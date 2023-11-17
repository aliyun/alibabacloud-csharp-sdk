// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentAssetsResponseBody : TeaModel {
        [NameInMap("ComponentAssets")]
        [Validation(Required=false)]
        public List<DescribeComponentAssetsResponseBodyComponentAssets> ComponentAssets { get; set; }
        public class DescribeComponentAssetsResponseBodyComponentAssets : TeaModel {
            [NameInMap("AssetUuid")]
            [Validation(Required=false)]
            public string AssetUuid { get; set; }

            [NameInMap("Componentname")]
            [Validation(Required=false)]
            public string Componentname { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
