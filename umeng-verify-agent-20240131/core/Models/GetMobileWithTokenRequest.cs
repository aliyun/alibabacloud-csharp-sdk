// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_verify_agent20240131.Models
{
    public class GetMobileWithTokenRequest : TeaModel {
        [NameInMap("apiCode")]
        [Validation(Required=false)]
        public int? ApiCode { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public int? OperatorId { get; set; }

        [NameInMap("osType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("schemeCode")]
        [Validation(Required=false)]
        public string SchemeCode { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
