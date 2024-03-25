// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessPointResponseBody : TeaModel {
        [NameInMap("AccessPoint")]
        [Validation(Required=false)]
        public CreateAccessPointResponseBodyAccessPoint AccessPoint { get; set; }
        public class CreateAccessPointResponseBodyAccessPoint : TeaModel {
            [NameInMap("AccessPointDomain")]
            [Validation(Required=false)]
            public string AccessPointDomain { get; set; }

            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
