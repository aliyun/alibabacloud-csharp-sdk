// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateApplicationRequest : TeaModel {
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("AppPrincipalName")]
        [Validation(Required=false)]
        public string AppPrincipalName { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("RedirectUris")]
        [Validation(Required=false)]
        public string RedirectUris { get; set; }

        [NameInMap("SecretRequired")]
        [Validation(Required=false)]
        public bool? SecretRequired { get; set; }

        [NameInMap("AccessTokenValidity")]
        [Validation(Required=false)]
        public int? AccessTokenValidity { get; set; }

        [NameInMap("RefreshTokenValidity")]
        [Validation(Required=false)]
        public int? RefreshTokenValidity { get; set; }

        [NameInMap("PredefinedScopes")]
        [Validation(Required=false)]
        public string PredefinedScopes { get; set; }

        [NameInMap("IsMultiTenant")]
        [Validation(Required=false)]
        public bool? IsMultiTenant { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

    }

}
