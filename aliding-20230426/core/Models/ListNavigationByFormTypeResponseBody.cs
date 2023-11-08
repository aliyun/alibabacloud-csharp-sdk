// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListNavigationByFormTypeResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListNavigationByFormTypeResponseBodyResult> Result { get; set; }
        public class ListNavigationByFormTypeResponseBodyResult : TeaModel {
            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("ProcessCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public ListNavigationByFormTypeResponseBodyResultTitle Title { get; set; }
            public class ListNavigationByFormTypeResponseBodyResultTitle : TeaModel {
                [NameInMap("NameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                [NameInMap("NameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
