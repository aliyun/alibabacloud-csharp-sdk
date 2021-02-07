// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAppSecretRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppSecretId")]
        [Validation(Required=false)]
        public string AppSecretId { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

    }

}
