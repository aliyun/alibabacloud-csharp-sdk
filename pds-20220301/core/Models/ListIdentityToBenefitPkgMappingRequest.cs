// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListIdentityToBenefitPkgMappingRequest : TeaModel {
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        [NameInMap("include_expired")]
        [Validation(Required=false)]
        public bool? IncludeExpired { get; set; }

    }

}
