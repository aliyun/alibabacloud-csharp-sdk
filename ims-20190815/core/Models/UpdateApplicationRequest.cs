// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateApplicationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        [NameInMap("NewRedirectUris")]
        [Validation(Required=false)]
        public string NewRedirectUris { get; set; }

        [NameInMap("NewPredefinedScopes")]
        [Validation(Required=false)]
        public string NewPredefinedScopes { get; set; }

        [NameInMap("NewSecretRequired")]
        [Validation(Required=false)]
        public bool? NewSecretRequired { get; set; }

        [NameInMap("NewAccessTokenValidity")]
        [Validation(Required=false)]
        public int? NewAccessTokenValidity { get; set; }

        [NameInMap("NewRefreshTokenValidity")]
        [Validation(Required=false)]
        public int? NewRefreshTokenValidity { get; set; }

        [NameInMap("NewIsMultiTenant")]
        [Validation(Required=false)]
        public bool? NewIsMultiTenant { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

    }

}
