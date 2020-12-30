// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UpdateProfileCatalogResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateProfileCatalogResponseBodyData Data { get; set; }
        public class UpdateProfileCatalogResponseBodyData : TeaModel {
            [NameInMap("CatalogId")]
            [Validation(Required=false)]
            public long? CatalogId { get; set; }
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }
            [NameInMap("IsvSubId")]
            [Validation(Required=false)]
            public string IsvSubId { get; set; }
            [NameInMap("ParentCatalogId")]
            [Validation(Required=false)]
            public string ParentCatalogId { get; set; }
            [NameInMap("ProfileCount")]
            [Validation(Required=false)]
            public long? ProfileCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
