// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListOpenAccountLinksRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("IdentityId")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("Idp")]
        [Validation(Required=false)]
        public string Idp { get; set; }

        [NameInMap("OpenId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

    }

}
