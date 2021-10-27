// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ListVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("versions")]
        [Validation(Required=false)]
        public ListVersionsResponseBodyVersions Versions { get; set; }
        public class ListVersionsResponseBodyVersions : TeaModel {
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<ListVersionsResponseBodyVersionsVersions> Versions { get; set; }
            public class ListVersionsResponseBodyVersionsVersions : TeaModel {
                public string DrdsVersion { get; set; }
                public bool? Latest { get; set; }
            }
        };

    }

}
