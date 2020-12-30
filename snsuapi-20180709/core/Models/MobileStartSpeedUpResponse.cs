// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class MobileStartSpeedUpResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public MobileStartSpeedUpResponseBody Body { get; set; }

    }

}
