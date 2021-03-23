// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListClientSdksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientSdks")]
        [Validation(Required=false)]
        public List<ListClientSdksResponseBodyClientSdks> ClientSdks { get; set; }
        public class ListClientSdksResponseBodyClientSdks : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            [NameInMap("PkgType")]
            [Validation(Required=false)]
            public int? PkgType { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public int? OsType { get; set; }

        }

    }

}
