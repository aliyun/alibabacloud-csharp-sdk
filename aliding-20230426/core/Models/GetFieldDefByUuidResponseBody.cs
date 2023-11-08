// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFieldDefByUuidResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetFieldDefByUuidResponseBodyResult> Result { get; set; }
        public class GetFieldDefByUuidResponseBodyResult : TeaModel {
            [NameInMap("Behavior")]
            [Validation(Required=false)]
            public string Behavior { get; set; }

            [NameInMap("Children")]
            [Validation(Required=false)]
            public string Children { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("FieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public object Label { get; set; }

            [NameInMap("Props")]
            [Validation(Required=false)]
            public object Props { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
