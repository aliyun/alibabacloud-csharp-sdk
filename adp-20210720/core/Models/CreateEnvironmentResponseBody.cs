// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateEnvironmentResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateEnvironmentResponseBodyData Data { get; set; }
        public class CreateEnvironmentResponseBodyData : TeaModel {
            [NameInMap("environmentUID")]
            [Validation(Required=false)]
            public string EnvironmentUID { get; set; }

            [NameInMap("vendorConfig")]
            [Validation(Required=false)]
            public string VendorConfig { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
