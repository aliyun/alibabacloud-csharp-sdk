// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class CreateSessionRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Asset")]
        [Validation(Required=false)]
        public string Asset { get; set; }

        [NameInMap("TTL")]
        [Validation(Required=false)]
        public int? TTL { get; set; }

        [NameInMap("LoginSession")]
        [Validation(Required=false)]
        public string LoginSession { get; set; }

    }

}
