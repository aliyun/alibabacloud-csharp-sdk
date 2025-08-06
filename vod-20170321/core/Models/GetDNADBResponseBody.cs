// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDNADBResponseBody : TeaModel {
        [NameInMap("DNADB")]
        [Validation(Required=false)]
        public GetDNADBResponseBodyDNADB DNADB { get; set; }
        public class GetDNADBResponseBodyDNADB : TeaModel {
            [NameInMap("DBDescription")]
            [Validation(Required=false)]
            public string DBDescription { get; set; }

            [NameInMap("DBId")]
            [Validation(Required=false)]
            public string DBId { get; set; }

            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            [NameInMap("DBRegion")]
            [Validation(Required=false)]
            public string DBRegion { get; set; }

            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
