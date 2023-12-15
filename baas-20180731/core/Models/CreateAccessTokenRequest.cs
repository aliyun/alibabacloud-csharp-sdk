// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateAccessTokenRequest : TeaModel {
        [NameInMap("AccessTokenLifetime")]
        [Validation(Required=false)]
        public string AccessTokenLifetime { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("RefreshTokenLifetime")]
        [Validation(Required=false)]
        public string RefreshTokenLifetime { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
