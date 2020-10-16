// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UpdateProfileCatalogResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public UpdateProfileCatalogResponseData Data { get; set; }
        public class UpdateProfileCatalogResponseData : TeaModel {
            [NameInMap("IsvSubId")]
            [Validation(Required=true)]
            public string IsvSubId { get; set; }
            [NameInMap("ParentCatalogId")]
            [Validation(Required=true)]
            public string ParentCatalogId { get; set; }
            [NameInMap("ProfileCount")]
            [Validation(Required=true)]
            public long ProfileCount { get; set; }
            [NameInMap("CatalogId")]
            [Validation(Required=true)]
            public long CatalogId { get; set; }
            [NameInMap("CatalogName")]
            [Validation(Required=true)]
            public string CatalogName { get; set; }
        };

    }

}
