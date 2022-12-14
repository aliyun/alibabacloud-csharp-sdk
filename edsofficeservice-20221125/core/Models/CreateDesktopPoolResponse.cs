// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EdsOfficeService20221125.Models
{
    public class CreateDesktopPoolResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public CreateDesktopPoolResponseBody Body { get; set; }

    }

}
