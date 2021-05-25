// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSaTokenRequest : TeaModel {
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ServiceAccountName")]
        [Validation(Required=false)]
        public string ServiceAccountName { get; set; }

        [NameInMap("NeedRefresh")]
        [Validation(Required=false)]
        public bool? NeedRefresh { get; set; }

    }

}
