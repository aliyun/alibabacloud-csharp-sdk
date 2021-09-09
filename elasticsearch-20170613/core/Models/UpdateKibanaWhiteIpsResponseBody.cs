// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaWhiteIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateKibanaWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdateKibanaWhiteIpsResponseBodyResult : TeaModel {
            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }
            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }
        };

    }

}
