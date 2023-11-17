// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class GetAccountByIdRequest : TeaModel {
        [NameInMap("IdentityId")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("OpenId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

        [NameInMap("OpenIdAppKey")]
        [Validation(Required=false)]
        public string OpenIdAppKey { get; set; }

    }

}
