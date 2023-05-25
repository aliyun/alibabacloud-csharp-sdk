// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ValidateVpcConnectivityResponseBody : TeaModel {
        [NameInMap("Connected")]
        [Validation(Required=false)]
        public bool? Connected { get; set; }

        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
