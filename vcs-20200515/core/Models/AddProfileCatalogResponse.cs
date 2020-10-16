// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class AddProfileCatalogResponse : TeaModel {
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
        public AddProfileCatalogResponseData Data { get; set; }
        public class AddProfileCatalogResponseData : TeaModel {
            [NameInMap("CatalogId")]
            [Validation(Required=true)]
            public long CatalogId { get; set; }
            [NameInMap("CatalogName")]
            [Validation(Required=true)]
            public string CatalogName { get; set; }
            [NameInMap("IsvSubId")]
            [Validation(Required=true)]
            public string IsvSubId { get; set; }
        };

    }

}
