// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListPackagesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPackagesResponseBodyData Data { get; set; }
        public class ListPackagesResponseBodyData : TeaModel {
            [NameInMap("createdPackages")]
            [Validation(Required=false)]
            public List<ListPackagesResponseBodyDataCreatedPackages> CreatedPackages { get; set; }
            public class ListPackagesResponseBodyDataCreatedPackages : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("installedPackages")]
            [Validation(Required=false)]
            public List<ListPackagesResponseBodyDataInstalledPackages> InstalledPackages { get; set; }
            public class ListPackagesResponseBodyDataInstalledPackages : TeaModel {
                [NameInMap("installTime")]
                [Validation(Required=false)]
                public long? InstallTime { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sourceProject")]
                [Validation(Required=false)]
                public string SourceProject { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
