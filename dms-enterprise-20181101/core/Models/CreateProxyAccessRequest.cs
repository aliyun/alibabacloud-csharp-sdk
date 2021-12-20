// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateProxyAccessRequest : TeaModel {
        [NameInMap("IndepAccount")]
        [Validation(Required=false)]
        public string IndepAccount { get; set; }

        [NameInMap("IndepPassword")]
        [Validation(Required=false)]
        public string IndepPassword { get; set; }

        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public long? ProxyId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
