// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ManageLoginResponseBody : TeaModel {
        [NameInMap("LoginInfo")]
        [Validation(Required=false)]
        public ManageLoginResponseBodyLoginInfo LoginInfo { get; set; }
        public class ManageLoginResponseBodyLoginInfo : TeaModel {
            [NameInMap("LoginHostname")]
            [Validation(Required=false)]
            public string LoginHostname { get; set; }

            [NameInMap("LoginPort")]
            [Validation(Required=false)]
            public int? LoginPort { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
