// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserIdRequest : TeaModel {
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public GetUserIdRequestExternalId ExternalId { get; set; }
        public class GetUserIdRequestExternalId : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

        }

    }

}
