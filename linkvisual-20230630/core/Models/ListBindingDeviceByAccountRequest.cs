// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class ListBindingDeviceByAccountRequest : TeaModel {
        [NameInMap("IdentityId")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("OpenId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

        [NameInMap("OpenIdAppKey")]
        [Validation(Required=false)]
        public string OpenIdAppKey { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SubDevice")]
        [Validation(Required=false)]
        public bool? SubDevice { get; set; }

    }

}
