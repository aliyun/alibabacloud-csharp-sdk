// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductFoundationReferencesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListProductFoundationReferencesResponseBodyData> Data { get; set; }
        public class ListProductFoundationReferencesResponseBodyData : TeaModel {
            [NameInMap("foundationReferenceUID")]
            [Validation(Required=false)]
            public string FoundationReferenceUID { get; set; }

            [NameInMap("foundationVersion")]
            [Validation(Required=false)]
            public string FoundationVersion { get; set; }

            [NameInMap("foundationVersionName")]
            [Validation(Required=false)]
            public string FoundationVersionName { get; set; }

            [NameInMap("foundationVersionType")]
            [Validation(Required=false)]
            public string FoundationVersionType { get; set; }

            [NameInMap("foundationVersionUID")]
            [Validation(Required=false)]
            public string FoundationVersionUID { get; set; }

            [NameInMap("productVersionUID")]
            [Validation(Required=false)]
            public string ProductVersionUID { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
