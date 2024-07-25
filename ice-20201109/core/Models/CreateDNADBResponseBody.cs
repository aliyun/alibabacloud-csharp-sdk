// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateDNADBResponseBody : TeaModel {
        [NameInMap("DBInfo")]
        [Validation(Required=false)]
        public CreateDNADBResponseBodyDBInfo DBInfo { get; set; }
        public class CreateDNADBResponseBodyDBInfo : TeaModel {
            [NameInMap("DBId")]
            [Validation(Required=false)]
            public string DBId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
