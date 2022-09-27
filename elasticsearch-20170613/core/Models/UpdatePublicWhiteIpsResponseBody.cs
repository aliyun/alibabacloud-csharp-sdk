// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePublicWhiteIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdatePublicWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdatePublicWhiteIpsResponseBodyResult : TeaModel {
            [NameInMap("publicIpWhitelist")]
            [Validation(Required=false)]
            public List<string> PublicIpWhitelist { get; set; }

        }

    }

}
