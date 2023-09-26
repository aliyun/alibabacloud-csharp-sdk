// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EttrafficIsp20230830.Models
{
    public class AkEnableResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public AkEnableResponseBody Body { get; set; }

    }

}
